using Scaffolding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scaffolding.Controllers
{
    public class TemplatesController : Controller
    {
        // GET: Templates
        public ActionResult Index()
        {
            var student = new Student
            {
                FullName = "Mincho Praznikov",
                Address = new Address
                {
                    Town = "Pernik",
                    Country = "BG"
                },
                FacultyNumber = "13123123",
                Grade = 6
            };

            return View(student);
        }

        public ActionResult Create()
        {
            return this.View();
        }
    }
}