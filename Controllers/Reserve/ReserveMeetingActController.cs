using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Reserve
{
    [Dou.Misc.Attr.MenuDef(Id = "ReserveMeetingAct", Name = "線上會議活動登入", MenuPath = "行政管理與系統預約專區", Action = "Index", Index = 3, Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = false, Icon = "Images/documents.png")]
    public class ReserveMeetingActController : Controller
    {
        // GET: ReserveMeetingAct
        public ActionResult Index()
        {
            return View();
        }
    }
}