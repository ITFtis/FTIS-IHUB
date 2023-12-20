using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Hr
{
    [Dou.Misc.Attr.MenuDef(Id = "HrPerformance", Name = "績效評量溝通", MenuPath = "人事差勤專區", Action = "Index", Index = 3, Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = false, Icon = "Images/hr.png")]
    public class HrPerformanceController : Controller
    {
        // GET: HrPerformance
        public ActionResult Index()
        {
            return View();
        }
    }
}