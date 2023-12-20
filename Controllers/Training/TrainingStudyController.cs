using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Training
{
    [Dou.Misc.Attr.MenuDef(Id = "TrainingStudy", Name = "部門內訓/讀書會報名", MenuPath = "內訓專區", Action = "Index", Index = 2, Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = false, Icon = "Images/training.png")]
    public class TrainingStudyController : Controller
    {
        // GET: TrainingStudy
        public ActionResult Index()
        {
            return View();
        }
    }
}