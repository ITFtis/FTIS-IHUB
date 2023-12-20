using Dou.Controllers;
using Dou.Help;
using Dou.Misc;
using Dou.Models.DB;
using FtisHelperV2.DB;
using iHub.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Emp
{
    [Dou.Misc.Attr.MenuDef(Id = "EmpWTOptionSelect", Name = "班別調查表", Action = "Index", Index = 3, Func = Dou.Misc.Attr.FuncEnum.ALL, AllowAnonymous = true)]
    public class EmpWTOptionSelectController : AGenericModelController<F22EmpWTOption>
    {
        // GET: EmpWTOptionSelect
        public ActionResult Index()
        {
            //Block工時挑選
            var objFno = DouUnobtrusiveSession.Session["WTOptionUserFno"];
            if (objFno == null)
            {
                return Redirect("~/User/DouLogin");
            }
            else
            {
                return View();
            }            
        }

        public ActionResult EditFormLayout()
        {
            return View();
        }

        protected override void UpdateDBObject(IModelEntity<F22EmpWTOption> dbEntity, IEnumerable<F22EmpWTOption> objs)
        {
            AddDBObject(dbEntity, objs);
        }

        protected override void AddDBObject(IModelEntity<F22EmpWTOption> dbEntity, IEnumerable<F22EmpWTOption> objs)
        {
            var f = objs.First();
            f.UpdateTime = DateTime.Now;

            base.AddDBObject(dbEntity, objs);
        }

        protected override Dou.Models.DB.IModelEntity<F22EmpWTOption> GetModelEntity()
        {
            System.Data.Entity.DbContext dbContext = new T8ModelContext();

            return new Dou.Models.DB.ModelEntity<F22EmpWTOption>(dbContext);
        }

        public override DataManagerOptions GetDataManagerOptions()
        {
            var opts = base.GetDataManagerOptions();

            opts.singleDataEdit = true;
            //opts.singleDataEditCompletedReturnUrl = System.Web.HttpContext.Current.Request.UrlReferrer == null ?
            //    "User/DouLogin" : System.Web.HttpContext.Current.Request.UrlReferrer.ToString();

            SysParam ps = F22QdateFun.GetEmpWTOption();
            F22EmpWTOption wt = new F22EmpWTOption();
            string Fno = DouUnobtrusiveSession.Session["WTOptionUserFno"].ToString();
            wt.Fno = Fno;
            wt.Wyear = ps.Wyear;
            wt.Qno = ps.Qno;
            wt.Cstartdate = DateTime.Parse(ps.Cstartdate);
            wt.Cenddate = DateTime.Parse(ps.Cenddate);
            wt.UpdateTime = DateTime.Now;
            wt.SelectNo = 1;
            wt.ClassID = 1;
            wt.WTID = 1;

            opts.datas = new F22EmpWTOption[] { wt };
            opts.editformWindowStyle = "showEditformOnly";
            opts.GetFiled("Cstartdate").editable = false;
            opts.GetFiled("Cenddate").editable = false;
            opts.GetFiled("SelectNo").editable = false;

            opts.editformWindowStyle = "showEditformOnly";
            opts.editformLayoutUrl = new UrlHelper(this.ControllerContext.RequestContext).Action("EditFormLayout");


            return opts;
        }

        public virtual ActionResult GetClassesLink()
        {
            SysParam ps = F22QdateFun.GetEmpWTOption();

            var jstr = JsonConvert.SerializeObject(ps, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            jstr = jstr.Replace(DataManagerScriptHelper.JavaScriptFunctionStringStart, "(").Replace(DataManagerScriptHelper.JavaScriptFunctionStringEnd, ")");
            return Content(jstr, "application/json");
        }
    }
}