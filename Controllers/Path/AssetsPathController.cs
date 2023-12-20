using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Path
{
    [Dou.Misc.Attr.MenuDef(Id = "AssetsPath", Name = "資產管理系統專區", Index = 4, IsOnlyPath = true, Icon = "Images/file-lines-regular.svg")]
    public class AssetsPathController : Controller
    {
        // GET: AssetsPath
        public ActionResult Index()
        {
            return View();
        }
    }
}