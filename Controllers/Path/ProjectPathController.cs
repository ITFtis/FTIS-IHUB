using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.Path
{
    [Dou.Misc.Attr.MenuDef(Id = "ProjectPath", Name = "專案管理專區", Index = 7, IsOnlyPath = true, Icon = "Images/hard-drive-regular.svg")]
    public class ProjectPathController : Controller
    {
        // GET: ProjectPath
        public ActionResult Index()
        {
            return View();
        }
    }
}