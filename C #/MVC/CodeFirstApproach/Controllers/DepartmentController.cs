using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult GooglePage()
        {
            return Redirect("http://www.google.com");
        }
        public ActionResult FacebookPage()
        {
            return RedirectPermanent("http://www.facebook.com");
        }

        public ActionResult Index()
        {
            return View();        
        }
    }
}