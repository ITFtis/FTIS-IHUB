using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Hr
{
    [Dou.Misc.Attr.MenuDef(Id = "HrT8", Name = "T8差勤確認系統", MenuPath = "人事差勤專區", Action = "Index", Index = 2, Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = false, Icon = "Images/hr.png")]
    public class HrT8Controller : Controller
    {
        // GET: HrT8
        public ActionResult Index()
        {
            return View();
        }
    }
}