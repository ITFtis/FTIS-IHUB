using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Hr
{
    [Dou.Misc.Attr.MenuDef(Id = "HrClass", Name = "我的班表", MenuPath = "人事差勤專區", Action = "Index", Index = 1, Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = false, Icon = "Images/hr.png")]
    public class HrClassController : Controller
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // GET: HrClass
        public ActionResult Index()
        {
            logger.Info("Test 我的班表");

            return View();
        }
    }
}