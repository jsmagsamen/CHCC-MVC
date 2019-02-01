using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHCC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Beliefs()
        {
            ViewBag.Message = "Your beliefs page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Your location page.";

            return View();
        }

        public ActionResult Pictures()
        {
            ViewBag.Message = "Your pictures page.";

            return View();
        }
    }
}