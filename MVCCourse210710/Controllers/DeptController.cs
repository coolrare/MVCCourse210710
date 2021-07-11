﻿using MVCCourse210710.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Diagnostics;
using MVCCourse210710.ViewModels;
using Omu.ValueInjecter;

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

        public ActionResult Details(int id)
        {
            Department department = db.Department.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        public ActionResult Create()
        {
            var personDDLList = db.Person.Select(p => new {
                p.ID,
                Name = p.FirstName + " " + p.LastName
            });
            ViewBag.InstructorID = new SelectList(personDDLList, "ID", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(DepartmentCreate department)
        {
            if (ModelState.IsValid)
            {
                var dept = new Department();
                dept.InjectFrom(department);
                dept.StartDate = DateTime.Now;

                db.Department.Add(dept);
                db.SaveChanges();

                //db.Department_Insert(department.Name, department.Budget, DateTime.Now, null);

                return RedirectToAction("Index");
            }

            return View(department);
        }

        public ActionResult Edit(int id)
        {
            var department = (from p in db.Department
                                where p.DepartmentID == id
                                select new DepartmentEdit()
                                {
                                    Budget = p.Budget,
                                    Name = p.Name,
                                    InstructorID = p.InstructorID,
                                    StartDate = p.StartDate
                                }).FirstOrDefault();

            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        [HttpPost]
        public ActionResult Edit(int id, DepartmentEdit department)
        {
            if (ModelState.IsValid)
            {
                Department dept = db.Department.Find(id);
                dept.InjectFrom(department);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(department);
        }

        public ActionResult Delete(int id)
        {
            Department department = db.Department.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Department dept = db.Department.Find(id);
            if (dept == null)
            {
                return HttpNotFound();
            }
            db.Department.Remove(dept);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}