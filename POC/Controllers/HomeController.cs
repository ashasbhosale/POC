using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();  
        }

        public ActionResult About()
        { 
            ViewBag.Message = "Jenkins CI  AWS G it  W e  bh ook ITS`";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page 3.";

            return View();
        }
    }
}