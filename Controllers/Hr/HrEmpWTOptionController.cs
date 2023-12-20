using Dou.Controllers;
using Dou.Misc;
using FtisHelperV2.DB;
using iHub.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Hr
{
    [Dou.Misc.Attr.MenuDef(Id = "HrEmpWTOption", Name = "員工班別調查表", MenuPath = "人事差勤專區", Action = "Index", Index = 10, Func = Dou.Misc.Attr.FuncEnum.ALL, AllowAnonymous = false)]
    public class HrEmpWTOptionController : AGenericModelController<F22EmpWTOption>
    {
        // GET: HrEmpWTOption
        public ActionResult Index()
        {
            return View();
        }

        public override DataManagerOptions GetDataManagerOptions()
        {
            var opts = base.GetDataManagerOptions();

            //全部欄位排序
            foreach (var field in opts.fields)
                field.sortable = true;

            opts.GetFiled("Wyear").defaultvalue = DateTime.Now.Year;

            return opts;
        }

        protected override Dou.Models.DB.IModelEntity<F22EmpWTOption> GetModelEntity()
        {
            System.Data.Entity.DbContext dbContext = new T8ModelContext();

            return new Dou.Models.DB.ModelEntity<F22EmpWTOption>(dbContext);
        }

        public virtual ActionResult GetDataDetail()
        {
            var opts = Dou.Misc.DataManagerScriptHelper.GetDataManagerOptions<F22EmpWTOption>();

            opts.singleDataEdit = true;
            //opts.singleDataEditCompletedReturnUrl = System.Web.HttpContext.Current.Request.UrlReferrer == null ?
            //    "User/DouLogin" : System.Web.HttpContext.Current.Request.UrlReferrer.ToString();

            SysParam ps = F22QdateFun.GetEmpWTOption();
            F22EmpWTOption wt = new F22EmpWTOption();
            //string Fno = Dou.Context.CurrentUserBase.Id;
            string Fno = "******";
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
            ////opts.GetFiled("Cstartdate").editable = false;
            ////opts.GetFiled("Cenddate").editable = false;
            ////opts.GetFiled("SelectNo").editable = false;

            opts.editformWindowStyle = "showEditformOnly";
            opts.editformLayoutUrl = new UrlHelper(this.ControllerContext.RequestContext).Action("EditFormLayout", "EmpWTOptionSelect");

            var jstr = JsonConvert.SerializeObject(opts, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            jstr = jstr.Replace(DataManagerScriptHelper.JavaScriptFunctionStringStart, "(").Replace(DataManagerScriptHelper.JavaScriptFunctionStringEnd, ")");
            return Content(jstr, "application/json");
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