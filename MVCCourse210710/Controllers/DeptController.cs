using MVCCourse210710.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Diagnostics;

namespace MVCCourse210710.Controllers
{
    public class DeptController : Controller
    {
        ContosoUniversityEntities db = new ContosoUniversityEntities();
        public DeptController()
        {
            db.Database.Log = (msg) => Debug.WriteLine(msg);
        }

        public ActionResult Index()
        {
            return View(db.Department.Include(d => d.Manager));
        }
    }
}