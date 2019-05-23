using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult Index()
        {
            ViewBag.Topic = "dotnet MVC Training";
            ViewBag.Venue = "Abridge Solutions";
            return View();
        }
        public ActionResult Module2()
        {
            ViewBag.Content = "Winforms,Entity";
            return View();
        }
        public ActionResult Module3()
        {
            ViewBag.Content = "WCF,ASP.Net";
            return View();
        }
    }
}