using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Path
{
    [Dou.Misc.Attr.MenuDef(Id = "SettingPath", Name = "網站設定", Index = 11, IsOnlyPath = true, Icon = "Images/book-solid.svg")]
    public class SettingPathController : Controller
    {
        // GET: SettingPath
        public ActionResult Index()
        {
            return View();
        }
    }
}