using HtmlPractice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlPractice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {
            HomePageEntities db = new HomePageEntities();
            var viewModel = db.NewsInfo.OrderByDescending(x => x.CreateTime).ToList();

            return PartialView("_NewsPanel", viewModel);
        }

        public ActionResult GetAsside()
        {
            HomePageEntities db = new HomePageEntities();
            var viewModel = db.NewsInfo.OrderByDescending(x => x.CreateTime).ToList();

            return PartialView("_NewsAssidePanel", viewModel);
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
    }
}