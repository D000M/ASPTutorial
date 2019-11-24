using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KrusovaASPV2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Authorize]
        public ActionResult LoginIndex()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kurs1()
        {
            return View();
        }

        public ActionResult Kurs2()
        {
            return View();
        }

        public ActionResult Kurs3()
        {
            return View();
        }
        public ActionResult Kurs4()
        {
            return View();
        }
        public ActionResult Unibit()
        {
            return View();
        }
        public ActionResult Kurs1Schedule()
        {
            return View();
        }
    }
}