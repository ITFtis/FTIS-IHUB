using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Online
{
    [Dou.Misc.Attr.MenuDef(Id = "OnlineApp", Name = "APP待處理單據", MenuPath = "線上系統專區", Action = "Index", Index = 1, Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = false, Icon = "Images/online.png")]
    public class OnlineAppController : Controller
    {
        // GET: OnlineApp
        public ActionResult Index()
        {
            return View();
        }
    }
}