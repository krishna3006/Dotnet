using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMSWebMvcApp.Controllers;
using EMS.BLL;
using EMS.DAL.EmployServiceReference;

namespace EMSWebMvcApp.Controllers
{
    public class EmployController : Controller
    {
        
        // GET: Employ
        public ActionResult Index()
        {
            List<Employ> elist = EmployBLL.GetEmploysBLL();
            return View(elist);
        }

        // GET: Employ/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employ/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employ/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
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
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employ/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employ/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
