using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Path
{
    [Dou.Misc.Attr.MenuDef(Id = "TrainingPath", Name = "內訓專區", Index = 9, IsOnlyPath = true, Icon = "Images/book-solid.svg")]
    public class TrainingPathController : Controller
    {
        // GET: TrainingPath
        public ActionResult Index()
        {
            return View();
        }
    }
}