using iHub.Models;
using iHub.Models.Mis;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;

namespace iHub
{
    /// <summary>
    /// (舊)員工管理系統
    /// </summary>
    public class MisHelper : BasicClass
    {
        /// <summary>
        /// 取出系統，履約到期提醒 部門主管
        /// </summary>
        /// <param name="empNos">查詢員工</param>
        /// <returns></returns>
        public List<MisPjClass> GetAlertPJ(List<string> empNos)
        {
            List<MisPjClass> result = null;
            
            try
            { 
                var dbContextMis = new MisModelContext();
                Dou.Models.DB.IModelEntity<pjPjds> e_pjPjds = new Dou.Models.DB.ModelEntity<pjPjds>(dbContextMis);                
                Dou.Models.DB.IModelEntity<cmmDep> e_cmmDep = new Dou.Models.DB.ModelEntity<cmmDep>(dbContextMis);                
                Dou.Models.DB.IModelEntity<cmmEmp> e_cmmEmp = new Dou.Models.DB.ModelEntity<cmmEmp>(dbContextMis);                                
                                
                //員工系統條件查詢
                DateTime alertDate = DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15); //DateTime.Now.AddDays(15);
                var datas = e_pjPjds.GetAll()                        
                        .Where(a => a.fnh != null && a.fnh != "Y" && (a.cls == null || a.cls == "N"))                        
                        .Where(a => a.pjds2 != "是否變更合約" && a.pjds2 != "人事費核帳")
                        .AsEnumerable()
                        .Where(a => DateTime.ParseExact(a.date4, "yyyyMMdd", CultureInfo.InvariantCulture) <= alertDate)
                        .ToList();

                //1.部門主管 dckno
                //限定員工
                var e_dep = e_cmmDep.GetAll();
                if (empNos != null)
                {
                    e_dep = e_dep.Where(a => empNos.Any(b => b == a.dckno));
                }

                var v1 = datas.Join(e_dep, a => a.dcode, b => b.dcode, (o, c) => new
                        {
                            o.dname, o.pjds1, o.pjds2, o.pjds2b, o.date3, o.cls, o.dcode, o.date4, o.ihub, o.fnh,
                            dckno = c.dckno
                        }).GroupJoin(e_cmmEmp.GetAll(), a => a.dckno, b => b.mno, (o, c) => new 
                        { 
                            o.dname, o.pjds1, o.pjds2, o.pjds2b, o.date3, o.cls, o.dcode, o.date4, o.ihub, o.fnh,
                            name = c.FirstOrDefault() == null ? "" : c.FirstOrDefault().name,
                            email = c.FirstOrDefault() == null ? "" : c.FirstOrDefault().email,
                            mno = c.FirstOrDefault() == null ? "" : c.FirstOrDefault().mno,
                        });

                //2.計畫主持人 ckno
                var v2 = datas.Where(a => empNos.Any(b => b == a.ckno))
                         .Select(o => new 
                        { 
                            o.dname, o.pjds1, o.pjds2, o.pjds2b, o.date3, o.cls, o.dcode, o.date4, o.ihub, o.fnh,
                            name = o.ckname,
                            email = o.ckemail,
                            mno = o.ckno,
                });

                //3.工項負責人1 prno                
                var v3 = datas.Where(a => empNos.Any(b => b == a.prno))
                         .Select(o => new 
                        { 
                            o.dname, o.pjds1, o.pjds2, o.pjds2b, o.date3, o.cls, o.dcode, o.date4, o.ihub, o.fnh,
                            name = o.prname,
                            email = o.premail,
                            mno = o.prno,
                });

                //3_2.工項負責人2 prno2
                var pp2 = datas.Where(a => empNos.Any(b => b == a.prno2))
                         .Select(o => new 
                        { 
                            o.dname, o.pjds1, o.pjds2, o.pjds2b, o.date3, o.cls, o.dcode, o.date4, o.ihub, o.fnh,
                            name = o.prname2,
                            email = o.premail2,
                            mno = o.prno2,
                });

                //3_3.工項負責人3 prno3
                var pp3 = datas.Where(a => empNos.Any(b => b == a.prno3))
                         .Select(o => new 
                        { 
                            o.dname, o.pjds1, o.pjds2, o.pjds2b, o.date3, o.cls, o.dcode, o.date4, o.ihub, o.fnh,
                            name = o.prname3,
                            email = o.premail3,
                            mno = o.prno3,
                });

                //3_4.工項負責人4 prno4
                var pp4 = datas.Where(a => empNos.Any(b => b == a.prno4))
                         .Select(o => new 
                        { 
                            o.dname, o.pjds1, o.pjds2, o.pjds2b, o.date3, o.cls, o.dcode, o.date4, o.ihub, o.fnh,
                            name = o.prname4,
                            email = o.premail4,
                            mno = o.prno4,
                });

                //3_5.工項負責人5 prno5
                var pp5 = datas.Where(a => empNos.Any(b => b == a.prno5))
                         .Select(o => new 
                        { 
                            o.dname, o.pjds1, o.pjds2, o.pjds2b, o.date3, o.cls, o.dcode, o.date4, o.ihub, o.fnh,
                            name = o.prname5,
                            email = o.premail5,
                            mno = o.prno5,
                });

                var tmp = v1.Concat(v2).Concat(v3)
                          .Concat(pp2).Concat(pp3).Concat(pp4).Concat(pp5);

                //distinct 輸出
                var vs = tmp
                    .Select(a => new
                    {
                        dname = a.dname, pjds1 = a.pjds1, pjds2 = a.pjds2, pjds2b = a.pjds2b, date3 = a.date3, date4 = a.date4, ihub = a.ihub,
                        cls = a.cls, dcode = a.dcode, fnh = a.fnh, mno = a.mno, name = a.name, email = a.email,
                    }).Distinct()
                    .Select(a => new
                    {
                        dname = a.dname,
                        pjds1 = a.pjds1,
                        pjds2 = a.pjds2,
                        pjds2b = a.pjds2b,
                        date3 = a.date3,
                        date3_diffday = (DateTime.ParseExact(a.date3, "yyyyMMdd", CultureInfo.InvariantCulture) - DateTime.Parse(DateTime.Now.ToShortDateString())).Days,
                        date4 = a.date4,
                        date4_diffday = (DateTime.ParseExact(a.date4, "yyyyMMdd", CultureInfo.InvariantCulture) - DateTime.Parse(DateTime.Now.ToShortDateString())).Days,
                        ihub = a.ihub,
                        cls = a.cls,
                        dcode = a.dcode,
                        fnh = a.fnh,
                        mno = a.mno,
                        name = a.name,
                        email = a.email,
                    });

                //結果
                //預定完成日(date4) 15天內「通知」  合約規範日期(date3) 3天內「鎖住」
                result = vs.Select(a => new MisPjClass
                {
                    dname = a.dname,
                    pjds1 = a.pjds1,
                    pjds2 = a.pjds2,
                    pjds2b = a.pjds2b,
                    date3 = a.date3,
                    date3_diffday = a.date3_diffday,
                    date4 = a.date4,
                    date4_diffday = a.date4_diffday,
                    cls = a.cls,
                    dcode = a.dcode,
                    fnh = a.fnh,
                    mno = a.mno,
                    name = a.name,
                    email = a.email,
                    alertState = Code.ToAlertState(a.date4_diffday, a.date3_diffday, a.ihub),
                    alertStateName = Code.GetAlertState().Where(p => p.Key == Code.ToAlertState(a.date4_diffday, a.date3_diffday, a.ihub)).FirstOrDefault().Value.ToString(),
                })
                .OrderBy(a => a.date4).ToList();
            }
            catch(Exception ex)
            {
                _errorMessage = ex.Message;
                return null;
            }

            return result;
        }
    }
}