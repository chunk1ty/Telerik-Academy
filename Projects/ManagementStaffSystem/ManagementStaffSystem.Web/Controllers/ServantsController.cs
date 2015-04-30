using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ManagementStaffSystem.Data;
using ManagmentStaffSystem.Models;
using PagedList;

namespace ManagementStaffSystem.Web.Controllers
{
    public class ServantsController : Controller
    {
        private ManagementStaffSystemDbContext db = new ManagementStaffSystemDbContext();

        // GET: Servants
        public ActionResult Index(string name, int? page)
        {
           var servants = db.Servants.Include(s => s.Department).OrderBy(s => s.Id);            

            if (!string.IsNullOrEmpty(name))
            {
                servants = db.Servants
                    .Include(s => s.Department)
                    .Where(s => s.FirstName.Contains(name) || 
                                s.LastName.Contains(name)).OrderBy(s => s.Id);
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);

            return View(servants.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult SearchByFirstName(string name)
        {
            var servants = db.Servants
                                .Include(s => s.Department)
                                .Where(s => s.FirstName.Contains(name));

            return View(servants.ToList());
        }

        // GET: Servants/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "DepartmentName");
            return View();
        }

        // POST: Servants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Egn,DepartmentId")] Servant servant)
        {
            if (ModelState.IsValid)
            {
                db.Servants.Add(servant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "DepartmentName", servant.DepartmentId);
            return View(servant);
        }

        // GET: Servants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Servant servant = db.Servants.Find(id);

            if (servant == null)
            {
                return HttpNotFound();
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "DepartmentName", servant.DepartmentId);

            return View(servant);
        }

        // POST: Servants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Egn,DepartmentId")] Servant servant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "DepartmentName", servant.DepartmentId);

            return View(servant);
        }

        // GET: Servants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Servant servant = db.Servants.Find(id);

            if (servant == null)
            {
                return HttpNotFound();
            }

            return View(servant);
        }

        // POST: Servants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Servant servant = db.Servants.Find(id);
            db.Servants.Remove(servant);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}