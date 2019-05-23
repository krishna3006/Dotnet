using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BMS.BLL;//add
using BMS.DAL.BookServiceReference;//add

namespace BMSWebMvcApp.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()//1st
        {
            List<Book> blist = BookBLL.GetBooksBLL();
            return View(blist);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            Book book = BookBLL.GetBookBLL(id);
            return View(book);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Book book)   //2nd
        {
            bool status = BookBLL.AddBookBLL(book);
            if (status)
            {
                return RedirectToAction("Index", "Book");
            }
            return View();
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            Book book = BookBLL.GetBookBLL(id);
            return View(book);
        }

        // POST: Book/Edit/5
        [HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult Edit(Book book)
        {
            bool status = BookBLL.UpdateBookBLL(book);
            if (status)
            {
                return RedirectToAction("Index", "Book");
            }
            return View();
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            Book book = BookBLL.GetBookBLL(id);
            return View(book);
            //bool status = BookBLL.DeleteBookBLL(id);
            //if (status)
            //{
            //    return RedirectToAction("Index", "Book");
            //}
            //return View();
        }

        // POST: Book/Delete/5
        [HttpPost]

        public ActionResult Delete(Book book)
        {
            int id = Convert.ToInt32(book.ID);
            bool status = BookBLL.DeleteBookBLL(id);
            if (status)
            {
                return RedirectToAction("Index", "Book");
            }
            return View();
            
        }
    }
}
