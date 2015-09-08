using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scaffolding.Models;
using Scaffolding.InputModels;

namespace Scaffolding.Controllers
{
    public class StudentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(StudentInputModel model)
        {
            if (model.FullName == "nakov")
            {
                this.ModelState.AddModelError("", "Wrong full name!");
            }

            if (this.ModelState != null && this.ModelState.IsValid)
            {
                var student = new Student
                {
                    FullName = model.FullName,
                    Grade = model.Grade,
                    FacultyNumber = model.FacultyNumber,
                    Address = new Address
                    {
                        Country = model.Address.Country,
                        Town = model.Address.Town
                    }
                };

                db.Students.Add(student);
                db.SaveChanges();

                this.TempData["FullName"] = student.FullName;
                return this.RedirectToAction("AddStudentSuccess");
            }

            return this.View(model);
        }

        public ActionResult AddStudentSuccess()
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult AddMultipleStudents()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult AddMultipleStudents(IEnumerable<Student> students)
        {
            return null;
        }
    }
}