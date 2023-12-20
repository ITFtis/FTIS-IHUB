using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Training
{
    [Dou.Misc.Attr.MenuDef(Id = "TrainingCourse", Name = "內訓課程", MenuPath = "內訓專區", Action = "Index", Index = 1, Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = false, Icon = "Images/training.png")]
    public class TrainingCourseController : Controller
    {
        // GET: TrainingCourse
        public ActionResult Index()
        {
            return View();
        }
    }
}