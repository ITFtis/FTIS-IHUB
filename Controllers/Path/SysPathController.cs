using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Path
{
    [Dou.Misc.Attr.MenuDef(Id = "SysPath", Name = "系統管理", Index = 8, IsOnlyPath = true, Icon = "Images/user-gear-solid.svg")]
    public class SysPathController : Controller
    {
        // GET: SysPath
        public ActionResult Index()
        {
            return View();
        }
    }
}