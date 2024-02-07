using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Util;
using iHub.Models;
using iHub.Models.ERP;


namespace iHub
{
    public class ERPHelper : BasicClass
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// 取出系統，所有同仁未完成各種單據資料筆數【TypeId：OA加班,LN假單,MS變形】
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="empNos">查詢員工</param>
        /// <param name="erp">ref 清單</param>
        /// <param name="erp_group">ref 統計</param>
        /// <returns></returns>
        public List<ErpCheckClass> GetUnDoneBill(List<string> empNos)
        {
            List<ErpCheckClass> result = null;
            
            try
            { 
                var dbContextT8ERP = new T8ERPModelContext();
                Dou.Models.DB.IModelEntity<wfBill> e_wfBill = new Dou.Models.DB.ModelEntity<wfBill>(dbContextT8ERP);                
                Dou.Models.DB.IModelEntity<wfActivity> e_wfActivity = new Dou.Models.DB.ModelEntity<wfActivity>(dbContextT8ERP);                
                Dou.Models.DB.IModelEntity<comGroupPerson> e_comGroupPerson = new Dou.Models.DB.ModelEntity<comGroupPerson>(dbContextT8ERP);                
                Dou.Models.DB.IModelEntity<capCommBillType> e_capCommBillType = new Dou.Models.DB.ModelEntity<capCommBillType>(dbContextT8ERP);

                var e_iquery = e_wfActivity.GetAll();

                //限定員工
                if (empNos != null)
                {
                    e_iquery = e_iquery.Where(a => empNos.Contains(a.UserId));
                }

                //員工系統條件查詢
                var tmp = e_iquery.Join(e_wfBill.GetAll(), a => a.TransactionId, b => b.TransactionId, (o, c) => new
                        {
                            o.TransactionId, o.LevelNO, o.UserId, o.kind, o.State, c.MakerId, c.MakeTime, c.TypeId, c.BillState, c.UpdateTime, c.BillPKValueText, c.SourceTag, c.BillPKValue,
                }).Join(e_comGroupPerson.GetAll(), a => a.UserId, b => b.PersonId, (o, c) => new 
                        { 
                            o.TransactionId, o.LevelNO, o.UserId, o.kind, o.State, o.MakerId, o.MakeTime, o.TypeId, o.BillState, o.UpdateTime, o.BillPKValueText, o.SourceTag, o.BillPKValue,
                            c.PersonName, c.EMail
                        })
                        .Where(a => a.kind == 1).Where(a => a.State == 0 || a.State == 1)
                        .Where(a => a.BillState == 2 && a.UpdateTime > 20210831000000)
                        .ToList()
                        .GroupJoin(Code.GetIHubBillType(), a => a.TypeId, b => b.TypeId, (o,c) => new
                        {
                            o.TransactionId, o.LevelNO, o.UserId, o.kind, o.State, o.MakerId, o.MakeTime, o.TypeId, o.BillState, o.UpdateTime, o.BillPKValueText, o.SourceTag, o.BillPKValue, o.PersonName, o.EMail,
                            TypeName = c.FirstOrDefault() == null ? "" : c.FirstOrDefault().TypeName
                        });

                //特殊(加班單)，送審人->主審->回送審人->主審，於第三步驗證(若"當下時間"超過"實際加班時間"，將於次一日開始提醒)
                Dou.Models.DB.IModelEntity<hrmOTApplyTime> e_hrmOTApplyTime = new Dou.Models.DB.ModelEntity<hrmOTApplyTime>(dbContextT8ERP);
                int nDay = 1;//隔天通知
                DateTime today = DateTime.Parse(DateTime.Now.ToShortDateString());
                List<string> BillNos = tmp.Where(a => a.TypeId == "OA")
                                        .Select(a => a.BillPKValueText).ToList();                                
                var hrms = e_hrmOTApplyTime.GetAll().Where(a => BillNos.Contains(a.BillNo))
                          .AsEnumerable()
                          .Where(a => (today - DateTime.ParseExact(a.BeginDate.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture)).Days >= nDay)
                          .Select(a => a.BillNo).ToList();

                tmp = tmp.Where(a => a.TypeId != "OA"
                                    || (a.TypeId == "OA" && a.UserId != a.MakerId)
                                    || (a.TypeId == "OA" && a.UserId == a.MakerId && hrms.Contains(a.BillPKValueText)));

                //輸出
                Dou.Models.DB.IModelEntity<webUrlAccess> e_webUrlAccess = new Dou.Models.DB.ModelEntity<webUrlAccess>(dbContextT8ERP);


                result = tmp.GroupJoin(e_comGroupPerson.GetAll(), a => a.MakerId, b => b.PersonId, (o, c) => new { 
                        o.TransactionId, o.LevelNO, o.UserId, o.kind, o.State, o.MakerId, o.MakeTime, o.TypeId, o.BillState, o.UpdateTime, o.BillPKValueText, o.SourceTag, o.BillPKValue, o.PersonName, o.EMail, o.TypeName,
                        MakerName = c.FirstOrDefault() == null? o.MakerId : c.FirstOrDefault().PersonName
                    })
                    .GroupJoin(e_webUrlAccess.GetAll().Where(a => empNos.Contains(a.UserId)), 
                        a => new { a.MakerId, a.SourceTag, BillPKValue = a.BillPKValue.ToString() },
                        b => new { MakerId = b.UserId, b.SourceTag, BillPKValue = b.PKValues }, (o, c) => new { 
                        o.TransactionId, o.LevelNO, o.UserId, o.kind, o.State, o.MakerId, o.MakeTime, o.TypeId, o.BillState, o.UpdateTime, o.BillPKValueText, o.SourceTag, o.BillPKValue, o.PersonName, o.EMail, o.TypeName, o.MakerName,
                        AccessId = c.FirstOrDefault() == null ? "" : c.FirstOrDefault().Id                        
                    })                    
                    .Select(a => new ErpCheckClass
                    {
                        TransactionId = a.TransactionId,
                        LevelNO = a.LevelNO,
                        UserId = a.UserId,
                        kind = a.kind,
                        State = a.State,
                        TypeId = a.TypeId,
                        BillState = a.BillState,
                        UpdateTime = a.UpdateTime,
                        PersonName = a.PersonName,
                        EMail = a.EMail,
                        TypeName = a.TypeName,
                        MakerName = a.MakerName,
                        MakeTime = a.MakeTime,
                        AccessId = a.AccessId,
                    }).ToList();
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
                _errorMessage = ex.Message;
                return null;
            }

            return result;
        }


        /////// <summary>
        /////// 取出系統，所有同仁未完成各種單據資料筆數【TypeId：OA加班,LN假單,MS變形】
        /////// </summary>
        /////// <typeparam name="T"></typeparam>
        /////// <param name="empNos">查詢員工</param>
        /////// <param name="erp">ref 清單</param>
        /////// <param name="erp_group">ref 統計</param>
        /////// <returns></returns>
        ////public bool GetUnDoneBill<T>(List<string> empNos, ref List<object> Erps, ref List<object> ErpGroups)
        ////{
        ////    bool result = false;

        ////    try
        ////    { 
        ////        var dbContextT8ERP = new T8ERPModelContext();
        ////        Dou.Models.DB.IModelEntity<wfBill> e_wfBill = new Dou.Models.DB.ModelEntity<wfBill>(dbContextT8ERP);                
        ////        Dou.Models.DB.IModelEntity<wfActivity> e_wfActivity = new Dou.Models.DB.ModelEntity<wfActivity>(dbContextT8ERP);                
        ////        Dou.Models.DB.IModelEntity<comGroupPerson> e_comGroupPerson = new Dou.Models.DB.ModelEntity<comGroupPerson>(dbContextT8ERP);                
        ////        Dou.Models.DB.IModelEntity<capCommBillType> e_capCommBillType = new Dou.Models.DB.ModelEntity<capCommBillType>(dbContextT8ERP);

        ////        var e_iquery = e_wfActivity.GetAll();

        ////        //限定員工
        ////        if (empNos != null)
        ////        {
        ////            e_iquery = e_iquery.Where(a => empNos.Contains(a.UserId));
        ////        }

        ////        var tmp = e_iquery.Join(e_wfBill.GetAll(), a => a.TransactionId, b => b.TransactionId, (o, c) => new
        ////                {
        ////                    o.TransactionId, o.LevelNO, o.UserId, o.kind, o.State, c.TypeId, c.BillState, c.UpdateTime
        ////                }).Join(e_comGroupPerson.GetAll(), a => a.UserId, b => b.PersonId, (o, c) => new 
        ////                { 
        ////                    o.TransactionId, o.LevelNO, o.UserId, o.kind, o.State, o.TypeId, o.BillState, o.UpdateTime,
        ////                    c.PersonName, c.EMail
        ////                }).GroupJoin(e_capCommBillType.GetAll(), a => a.TypeId, b => b.TypeId, (o,c) => new
        ////                {
        ////                    o.TransactionId, o.LevelNO, o.UserId, o.kind, o.State, o.TypeId, o.BillState, o.UpdateTime, o.PersonName, o.EMail,
        ////                    TypeName = c.FirstOrDefault() == null ? "" : c.FirstOrDefault().TypeName
        ////                })
        ////                .Where(a => a.kind == 1).Where(a => a.State == 0 || a.State == 1)
        ////                .Where(a => a.BillState == 2 && a.UpdateTime > 20210831000000);

        ////        Erps = tmp.ToList<object>();

        ////        ErpGroups = tmp.GroupBy(a => new { a.UserId, a.PersonName, a.EMail, a.TypeId, a.TypeName })
        ////                .Select(a => new
        ////                {
        ////                    a.Key.UserId, a.Key.PersonName, a.Key.EMail, a.Key.TypeId, a.Key.TypeName, Counts = a.Count(),
        ////                }).OrderBy(a => a.UserId)
        ////                .ToList<object>();                
        ////    }
        ////    catch(Exception ex)
        ////    {
        ////        _errorMessage = ex.Message;
        ////        return result;
        ////    }

        ////    result = true;

        ////    return result;
        ////}
    }
}