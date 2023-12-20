using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers
{
    public class HtmlIframeOtherMainLayoutController : Dou.Controllers.HtmlIFrameController
    {
        // GET: HtmlIframeOtherMainLayout
        ////public ActionResult Index()
        ////{
        ////    return View();
        ////}

        protected override void OnActionExecuting(ActionExecutingContext ctx)
        {
            var _ssotoken = HttpContext.Request.QueryString["ssotoken"];
            if (_ssotoken == null)
            {
                ctx.Result = new RedirectResult(UserController.SsoLogin + "?redirectLogin=true&returnUrl=" + HttpUtility.UrlEncode(HttpContext.Request.Url + ""));
                return;
            }

            base.OnActionExecuting(ctx);
            ctx.Result = View("HtmlIFramePartial", "OtherManLayout");
        }

    }
}