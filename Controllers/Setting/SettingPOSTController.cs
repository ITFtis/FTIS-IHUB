using Dou.Controllers;
using Dou.Misc;
using iHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Setting
{
    [Dou.Misc.Attr.MenuDef(Id = "SettingPOST", Name = "會內最新公告", MenuPath = "網站設定", Action = "Index", Index = 1, Func = Dou.Misc.Attr.FuncEnum.Update, AllowAnonymous = false)]
    public class SettingPOSTController : AGenericModelController<POST>
    {
        // GET: SettingPOST
        public ActionResult Index()
        {
            return View();
        }

        protected override Dou.Models.DB.IModelEntity<POST> GetModelEntity()
        {
            System.Data.Entity.DbContext dbContext = new iHubModelContextExt();

            return new Dou.Models.DB.ModelEntity<POST>(dbContext);
        }

        public override DataManagerOptions GetDataManagerOptions()
        {
            var opts = base.GetDataManagerOptions();

            //全部欄位排序
            foreach (var field in opts.fields)
            {
                field.visibleEdit = false;
                field.editable = false;
            }

            opts.GetFiled("Date").visibleEdit = true;
            opts.GetFiled("Title").visibleEdit = true;
            
            return opts;
        }
    }
}