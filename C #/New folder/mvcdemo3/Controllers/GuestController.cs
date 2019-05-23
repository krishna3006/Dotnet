using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcdemo3.Models;

namespace mvcdemo3.Controllers
{
    public class GuestController : Controller
    {
        // GET: Guest
        public ActionResult Index()
        {
            var guestDetails = new GuestService();
            var guests = guestDetails.GetAllGuests();
            return View(guests);
        }

        // GET: Guest/Details/5
        public ActionResult Details(int id)
        {
            GuestService gs = new GuestService();
            Guest guest = gs.ShowGuest(id);
            return View(guest);
        }

        // GET: Guest/Create
        public ActionResult Create()
        {
            return View(new Guest());
        }
        [HttpPost]
        public ActionResult Create(Guest newGuest)
        {
            if (ModelState.IsValid)
            {
                GuestService gs = new GuestService();
                gs.AddGuest(newGuest);
                return RedirectToAction("Index");
            }
            else
            {
                return View(newGuest);
            }
        }

        //// POST: Guest/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Guest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Guest/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            Guest updateGuest = null;
            try
            {
                // TODO: Add update logic here
                updateGuest = new Guest();
                updateGuest.GuestNo = id;
                updateGuest.GuestName = collection["GuestNAme"];
                updateGuest.PhoneNumber = collection["PhoneNumber"];
                GuestService gs = new GuestService();
                gs.UpdateGuest(updateGuest);
                return RedirectToAction("Index");

            }
            catch
            {
                return View(updateGuest);
            }
        }

        // GET: Guest/Delete/5
        public ActionResult Delete(int id)
        {
            GuestService gs = new GuestService();
            Guest guest = gs.ShowGuest(id);
            return View(guest);
        }

        // POST: Guest/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Guest deleteGuest = null;
            try
            {
                deleteGuest = new Guest();
                deleteGuest.GuestName = collection["GuestName"];
                deleteGuest.PhoneNumber = collection["PhoneNumber"];
                GuestService gs = new GuestService();
                gs.RemoveGuest(id);
                return RedirectToAction("Index");
                // TODO: Add delete logic here
            }
            catch
            {
                return View(deleteGuest);
            }
        }
    }
}
