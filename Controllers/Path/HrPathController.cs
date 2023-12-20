using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Path
{
    [Dou.Misc.Attr.MenuDef(Id = "HrPath", Name = "人事差勤專區", Index = 1, IsOnlyPath = true, Icon = "Images/clock-regular.svg")]
    public class HrPathController : Controller
    {
        // GET: HrPath
        public ActionResult Index()
        {
            return View();
        }
    }
}