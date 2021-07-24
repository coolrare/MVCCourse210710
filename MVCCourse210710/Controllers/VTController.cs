using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCourse210710.Controllers
{
    public class VTController : Controller
    {
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult Page1()
        {
            return View();
        }

        public ActionResult DemoXSS()
        {
            return View();
        }
    }
}