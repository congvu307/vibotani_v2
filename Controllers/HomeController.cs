using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViBotani.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Product()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Advisory()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Blog_List()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Question()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult postSanxuatISO()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult postDaotaonhansu()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}