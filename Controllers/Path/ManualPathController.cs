using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Path
{
    [Dou.Misc.Attr.MenuDef(Id = "ManualPath", Name = "操作手冊專區", Index = 10, IsOnlyPath = true, Icon = "Images/folder-open-regular.svg")]
    public class ManualPathController : Controller
    {
        // GET: ManualPath
        public ActionResult Index()
        {
            return View();
        }
    }
}