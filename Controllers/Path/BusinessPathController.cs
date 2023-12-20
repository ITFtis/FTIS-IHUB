using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Path
{
    [Dou.Misc.Attr.MenuDef(Id = "BusinessPath", Name = "業務系統專區", Index = 6, IsOnlyPath = true, Icon = "Images/address-book-regular.svg")]
    public class BusinessPathController : Controller
    {
        // GET: BusinessPath
        public ActionResult Index()
        {
            return View();
        }
    }
}