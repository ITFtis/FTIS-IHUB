using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Path
{
    [Dou.Misc.Attr.MenuDef(Id = "FinancePath", Name = "財務系統專區", Index = 5, IsOnlyPath = true, Icon = "Images/circle-dollar-to-slot-solid.svg")]
    public class FinancePathController : Controller
    {
        // GET: FinancePath
        public ActionResult Index()
        {
            return View();
        }
    }
}