using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Project
{
    [Dou.Misc.Attr.MenuDef(Id = "ProjectManage", Name = "專案履約管理系統", MenuPath = "專案管理專區", Action = "Index", Index = 3, Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = false, Icon = "Images/project.png")]
    public class ProjectManageController : Controller
    {
        // GET: ProjectManage
        public ActionResult Index()
        {
            return View();
        }
    }
}