using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Online
{
    [Dou.Misc.Attr.MenuDef(Id = "OnlinePending", Name = "線上用印系統", MenuPath = "線上系統專區", Action = "Index", Index = 2, Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = false, Icon = "Images/online.png")]
    public class OnlinePendingController : Controller
    {
        // GET: OnlinePending
        public ActionResult Index()
        {
            return View();
        }
    }
}