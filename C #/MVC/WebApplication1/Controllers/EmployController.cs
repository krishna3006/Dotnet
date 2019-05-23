using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployController : Controller
    {
        // GET: Employ
        public ActionResult Index()
        {
            var EmployDetails = new EmployService();
            var Employs = EmployDetails.GetAllEmploys();
            return View(Employs);
        }

        // GET: Employ/Details/5
        public ActionResult Details(int id)
        {
            EmployService es = new EmployService();
            Employ employ = es.ShowEmploy(id);
            return View(employ);
        }

        // GET: Employ/Create
        public ActionResult Create()
        {
            return View(new Employ());
        }

        // POST: Employ/Create
        [HttpPost]
        public ActionResult Create(Employ newEmploy)
        {
            if (ModelState.IsValid)
            {
                EmployService es = new EmployService();
                es.AddEmploy(newEmploy);
                return RedirectToAction("Index");
            }
            else
            {
                return View(newEmploy);
            }
        }

        // GET: Employ/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employ/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            Employ updateEmploy = null;
            try
            {
                // TODO: Add update logic here
                updateEmploy = new Employ();
                updateEmploy.Empno = id;
                updateEmploy.name = collection["Name"];
                updateEmploy.Dept = collection["Dept"];
                updateEmploy.Desig = collection["Desig"];
                updateEmploy.Basic = Convert.ToInt32(collection["Basic"]);
                EmployService es = new EmployService();
                es.UpdateEmploy(updateEmploy);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(updateEmploy);
            }
        }

        // GET: Employ/Delete/5
        public ActionResult Delete(int id)
        {
            EmployService es = new EmployService();
            Employ employ = es.ShowEmploy(id);
            return View(employ);
        }

        // POST: Employ/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Employ deleteEmploy = null;
            try
            {
                deleteEmploy = new Employ();
                deleteEmploy.name = collection["Name"];
                deleteEmploy.Dept = collection["Dept"];
                deleteEmploy.Desig = collection["Desig"];
                deleteEmploy.Basic = Convert.ToInt32(collection["Basic"]);
                EmployService es = new EmployService();
                es.RemoveEmploy(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(deleteEmploy);
            }
        }
    }
}
