using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Online
{
    [Dou.Misc.Attr.MenuDef(Id = "OnlineBusinessRender", Name = "線上差旅報帳系統", MenuPath = "線上系統專區", Action = "Index", Index = 3, Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = false, Icon = "Images/online.png")]
    public class OnlineBusinessRenderController : Controller
    {
        // GET: OnlineBusinessRender
        public ActionResult Index()
        {
            return View();
        }
    }
}