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
        public ActionResult PVR1()
        {
            return PartialView("VR2");
        }

        public ActionResult Robots()
        {
            return PartialView();
        }

        public ActionResult FRView()
        {
            return View();
        }

        public ActionResult FR1(bool isDownload = false)
        {
            return File(Server.MapPath("~/Content/Image.jpg"), "image/jpeg");
        }

        public ActionResult FR2()
        {
            return File(Server.MapPath(
                "~/Content/Image.jpg"), 
                "image/jpeg", 
                "防疫_收費站提示_2_A3(4).jpg");
        }

    }
}