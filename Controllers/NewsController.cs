using Dou.Controllers;
using Dou.Models.DB;
using iHub.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers
{
    [Dou.Misc.Attr.MenuDef(Id = "News", Name = "會內最新公告", Action = "Index", Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = true, Icon = "Images/main_news.png")]
    public class NewsController : APaginationModelController<POST>
	{
        // GET: News
        public ActionResult Index()
        {
            return View();
        }

		protected override IQueryable<POST> BeforeIQueryToPagedList(IQueryable<POST> iquery, params KeyValueParams[] paras)
		{
			iquery = iquery.Where(x => x.NodeId == 3 && x.Flag == 1);

			return base.BeforeIQueryToPagedList(iquery, paras);
		}


		protected override IModelEntity<POST> GetModelEntity()
		{
			return new Dou.Models.DB.ModelEntity<POST>(new iHubModelContextExt());
		}
	}

	
}