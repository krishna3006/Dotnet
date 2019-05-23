using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Models
{
    public class EmploysController : Controller
    {
        private EmployContext db = new EmployContext();

        // GET: Employs
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        // GET: Employs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employ employ = db.Employees.Find(id);
            if (employ == null)
            {
                return HttpNotFound();
            }
            return View(employ);
        }

        // GET: Employs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Empno,name,Dept,Desig,Basic")] Employ employ)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employ);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employ);
        }

        // GET: Employs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employ employ = db.Employees.Find(id);
            if (employ == null)
            {
                return HttpNotFound();
            }
            return View(employ);
        }

        // POST: Employs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Empno,name,Dept,Desig,Basic")] Employ employ)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employ).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employ);
        }

        // GET: Employs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employ employ = db.Employees.Find(id);
            if (employ == null)
            {
                return HttpNotFound();
            }
            return View(employ);
        }

        // POST: Employs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employ employ = db.Employees.Find(id);
            db.Employees.Remove(employ);
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
