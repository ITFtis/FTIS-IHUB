using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers.MarkupiHub
{
    public class MarkupController : Controller
    {
        // GET: Markup
        //首頁
        public ActionResult Index()
        {
            return View();
        }

        //最新消息
        public ActionResult News()
        {
            return View();
        }

        //另一個版型Layout
        public ActionResult OtherLayout()
        {
            return View();
        }

        //行政管理專區 Documents
        public ActionResult Documents()
        {
            return View();
        }

        //最新消息內頁
        public ActionResult NewsItem()
        {
            return View();
        }

        //班表頁面
        public ActionResult Schedule()
        {
            return View();
        }
    }
}