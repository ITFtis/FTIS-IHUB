﻿using iHub.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHub.Controllers
{
    [Dou.Misc.Attr.MenuDef(Id = "Home", Name = "首頁", Action = "Index", Func = Dou.Misc.Attr.FuncEnum.None, AllowAnonymous = true)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ////改由底板(_Layout)強制轉頁
            //if (Dou.Context.CurrentUserBase == null)
            //    return Redirect("~/User/DouLogin");

            var dbContext = new iHubModelContextExt();
           
			//最新消息
			Dou.Models.DB.IModelEntity<POST> post = new Dou.Models.DB.ModelEntity<POST>(dbContext);
			var news = post.GetAll()
								.Where(x => x.NodeId == 3 && x.Flag == 1)
								.OrderByDescending(x => x.ShowDate)
								.Take(5)
								.ToList();

            ViewBag.LatestPost = news;

            //跑馬燈
            Dou.Models.DB.IModelEntity<cmmMrq> mrq = new Dou.Models.DB.ModelEntity<cmmMrq>(dbContext);
            var a1 = mrq.GetAll().Select(a => a.mrqtxt);            
            var a2 = news.Take(3).Select(a => new
            {
                ShowDate = a.ShowDate == null ? "" : (((DateTime)a.ShowDate).Year - 1911).ToString() + "." + (((DateTime)a.ShowDate).Month).ToString(),
                a.Title
            })
            .Select(a => a.ShowDate + " " + a.Title);

            ViewBag.Mrqs = a1.Concat(a2).OrderByDescending(a => a).ToList();

            //首頁登入者資料
            if (Dou.Context.CurrentUserBase != null)
            {
                string Fno = Dou.Context.CurrentUserBase.Id;   //string Fno = "A0183";
                DateTime today = DateTime.Now;  //DateTime today = DateTime.Parse("2023/07/26");
                List<dynamic> cards = new List<dynamic>();

                int n = 2;  //2天內的打卡資訊(版型限定2筆)
                for (int i = 0; i < n; i++)
                {
                    DateTime date = today.AddDays(i * -1);

                    FtisHelperV2.DB.Helpe.Employee.ResetGetEmpCheckTime();
                    var check = FtisHelperV2.DB.Helpe.Employee.GetEmpCheckTime(Fno)
                                    .Where(a => a.CheckTime.Year == date.Year)
                                    .Where(a => DateFormat.ToDate1(a.CheckTime) == DateFormat.ToDate1(date));

                    DateTime dMin = DateTime.MinValue;
                    DateTime dMax = DateTime.MinValue;
                    if (check.Count() > 1)
                    {
                        //取最大和最小
                        dMin = check.Min(a => a.CheckTime);
                        dMax = check.Max(a => a.CheckTime);

                    }
                    else if (check.Count() == 1)
                    {
                        dMin = check.Min(a => a.CheckTime);
                    }

                    dynamic dy = new ExpandoObject();
                    dy.date = iHub.DateFormat.ToDate11(date);
                    dy.checkin = dMin == DateTime.MinValue ? "無刷卡資料" : iHub.DateFormat.ToDate12(dMin);
                    dy.checkout = dMax == DateTime.MinValue ? "無刷卡資料" : iHub.DateFormat.ToDate12(dMax);

                    cards.Add(dy);
                }

                ViewBag.Cards = cards;
            }

            return View();
        }
        //測試頁1
        public ActionResult Test1()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}