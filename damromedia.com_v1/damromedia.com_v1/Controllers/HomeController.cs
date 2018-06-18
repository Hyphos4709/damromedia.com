using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace damromedia.com_v1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PastWebsites()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Opportunity()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}