using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Hr
{
    [Dou.Misc.Attr.MenuDef(Id = "HrQuit", Name = "線上離職申請", MenuPath = "人事差勤專區", Action = "Index", Index = 9, Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = false, Icon = "Images/hr.png")]
    public class HrQuitController : Controller
    {
        // GET: HrQuit
        public ActionResult Index()
        {
            return View();
        }
    }
}