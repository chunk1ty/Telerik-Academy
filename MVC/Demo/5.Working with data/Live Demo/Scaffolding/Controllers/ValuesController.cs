using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scaffolding.Controllers
{
    public class ValuesController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(IEnumerable<string> values)
        {
            return this.Content(string.Join(", ", values));
        }

        public ActionResult SaveTempData()
        {
            this.TempData["name"] = "Vlado";
            return this.RedirectToAction("TeamDataRedirect");
        }

        public ActionResult TeamDataRedirect()
        {
            var name = this.TempData["name"];
            return this.View(name);
        }

        public ActionResult TeamDataRedirectLast()
        {
            var name = this.TempData["name"];
            return null;
        }
    }
}