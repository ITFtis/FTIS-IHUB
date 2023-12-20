using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Path
{
    [Dou.Misc.Attr.MenuDef(Id = "ReservePath", Name = "行政管理與系統預約專區", Index = 2, IsOnlyPath = true, Icon = "Images/list-check-solid.svg")]
    public class ReservePathController : Controller
    {
        // GET: ReservePath
        public ActionResult Index()
        {
            return View();
        }
    }
}