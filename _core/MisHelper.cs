﻿using iHub.Models;
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

                var e_iquery = e_pjPjds.GetAll();

                //限定員工
                var e_dep = e_cmmDep.GetAll();
                if (empNos != null)
                {
                    e_dep = e_dep.Where(a => empNos.Any(b => b == a.dckno));
                }

                //員工系統條件查詢
                DateTime alertDate = DateTime.Parse(DateTime.Now.ToShortDateString()).AddDays(15); //DateTime.Now.AddDays(15);
                var tmp = e_iquery.Join(e_dep, a => a.dcode, b => b.dcode, (o, c) => new
                        {
                            o.dname, o.pjds1, o.pjds2, o.pjds2b, o.date3, o.cls, o.dcode, o.date4, o.fnh,
                            dckno = c.dckno
                        })
                        .GroupJoin(e_cmmEmp.GetAll(), a => a.dckno, b => b.mno, (o, c) => new 
                        { 
                            o.dname, o.pjds1, o.pjds2, o.pjds2b, o.date3, o.cls, o.dcode, o.date4, o.fnh, o.dckno,
                            name = c.FirstOrDefault() == null ? "" : c.FirstOrDefault().name,
                            email = c.FirstOrDefault() == null ? "" : c.FirstOrDefault().email,
                            mno = c.FirstOrDefault() == null ? "" : c.FirstOrDefault().mno,
                        })                        
                        .Where(a => a.fnh != null && a.fnh != "Y" && (a.cls == null || a.cls == "N"))                        
                        .Where(a => a.pjds2 != "是否變更合約")
                        .AsEnumerable()
                        .Where(a => DateTime.ParseExact(a.date4, "yyyyMMdd", CultureInfo.InvariantCulture) <= alertDate)
                        .OrderBy(a => a.date4).ToList();

                //輸出
                result = tmp.Select(a => new MisPjClass
                {
                    dname = a.dname,
                    pjds1 = a.pjds1,
                    pjds2 = a.pjds2,
                    pjds2b = a.pjds2b,
                    date3 = a.date3,
                    cls = a.cls,
                    dcode = a.dcode,
                    date4 = a.date4,
                    fnh = a.fnh,
                    mno = a.mno,
                    name = a.name,
                    email = a.email,
                }).ToList();
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