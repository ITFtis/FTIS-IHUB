using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Path
{
    [Dou.Misc.Attr.MenuDef(Id = "OnlinePath", Name = "線上系統專區", Index = 3, IsOnlyPath = true, Icon = "Images/network-wired-solid.svg")]
    public class OnlinePathController : Controller
    {
        // GET: OnlinePath
        public ActionResult Index()
        {
            return View();
        }
    }
}