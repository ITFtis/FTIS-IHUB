using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Reserve
{
    [Dou.Misc.Attr.MenuDef(Id = "ReserveSupport", Name = "行政組支援系統", MenuPath = "行政管理與系統預約專區", Action = "Index", Index = 2, Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = false, Icon = "Images/documents.png")]
    public class ReserveSupportController : Controller
    {
        // GET: ReserveSupport
        public ActionResult Index()
        {
            return View();
        }
    }
}