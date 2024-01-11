using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iHub.Models;


namespace iHub
{
    public class ERPHelper : BasicClass
    {

        /// <summary>
        /// 取出系統，所有同仁未完成各種單據資料筆數【TypeId：OA加班,LN假單,MS變形】
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="empNos">查詢員工</param>
        /// <param name="erp">ref 清單</param>
        /// <param name="erp_group">ref 統計</param>
        /// <returns></returns>
        public bool GetUnDoneBill<T>(List<string> empNos, ref List<object> Erps, ref List<object> ErpGroups)
        {
            bool result = false;

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

                var tmp = e_iquery.Join(e_wfBill.GetAll(), a => a.TransactionId, b => b.TransactionId, (o, c) => new
                        {
                            o.TransactionId, o.LevelNO, o.UserId, o.kind, o.State, c.TypeId, c.BillState, c.UpdateTime
                        }).Join(e_comGroupPerson.GetAll(), a => a.UserId, b => b.PersonId, (o, c) => new 
                        { 
                            o.TransactionId, o.LevelNO, o.UserId, o.kind, o.State, o.TypeId, o.BillState, o.UpdateTime,
                            c.PersonName, c.EMail
                        }).Where(a => a.kind == 1).Where(a => a.State == 0 || a.State == 1)
                        .Where(a => a.BillState == 2 && a.UpdateTime > 20210831000000);

                Erps = tmp.ToList<object>();

                ErpGroups = tmp.GroupBy(a => new { a.UserId, a.PersonName, a.EMail, a.TypeId })
                        .Select(a => new
                        {
                            a.Key.UserId, a.Key.PersonName, a.Key.EMail, a.Key.TypeId, cnt = a.Count(),
                        }).OrderBy(a => a.UserId)
                        .ToList<object>();                
            }
            catch(Exception ex)
            {
                _errorMessage = ex.Message;
                return result;
            }

            result = true;

            return result;
        }
    }
}