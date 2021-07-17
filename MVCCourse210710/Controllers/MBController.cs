using MVCCourse210710.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCourse210710.Controllers
{
    public class MBController : Controller
    {
        public ActionResult MB1()
        {
            var data = "Hello World";
            return View(data);
        }
        public ActionResult MB2()
        {
            var data = "Hello World";
            ViewData.Model = data;
            return View("MB1");
        }
        public ActionResult MB3()
        {
            ViewData["Data"] = "Hello World";
            return View("MB1");
        }
        public ActionResult MB4()
        {
            ViewBag.Data = "Hello World";
            return View("MB1");
        }
        public ActionResult MB5()
        {
            TempData["TmpData"] = "TmpData";
            return RedirectToAction("MB6");
        }
        public ActionResult MB6()
        {
            return View("MB1");
        }
        public ActionResult MB7()
        {
            Session["SessionData"] = "SessionData";
            return RedirectToAction("MB8");
        }
        public ActionResult MB8()
        {
            return View("MB1");
        }


        public ActionResult Form1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form1(MBViewModel data)
        {
            return View(data);
        }
    }
}