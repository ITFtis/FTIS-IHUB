using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Reserve
{
    [Dou.Misc.Attr.MenuDef(Id = "ReserveManage", Name = "行政管理專區", MenuPath = "行政管理與系統預約專區", Action = "Index", Index = 1, Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = false, Icon = "Images/documents.png")]
    public class ReserveManageController : Controller
    {
        // GET: ReserveManage
        public ActionResult Index()
        {
            return View();
        }
    }
}