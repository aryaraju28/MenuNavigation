using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MenuNavigation.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}