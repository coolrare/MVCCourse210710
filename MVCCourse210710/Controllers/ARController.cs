using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCourse210710.Controllers
{
    public class ARController : Controller
    {
        public ActionResult VR1()
        {
            return View();
        }
        public ActionResult VR2()
        {
            return View();
        }
        public ActionResult VR3()
        {
            return View("VR2");
        }
        public ActionResult VR4()
        {
            return View("VR2", "_Layout2");
        }

    }
}