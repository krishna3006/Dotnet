using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCVDemo2.Models;


namespace MCVDemo2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //GET:/Home/RazorView
        public ActionResult RazorView()
        {
            return View();
        }
        //GET:/Home/PrintIgate
        public ActionResult PrintIgate()
        {
            return Content("IGATE");
        }
        //GET:/Home/PrintId/714709
        //GET:/Home/PrintId?id=714709(id is a optional Parameter

        public ContentResult PrintId(string id)
        {
            return Content(String.Format("{0}", id));
        }
        //GET:/Home/PrintName?Name=Ganesh
        public ContentResult PrintName(string name)
        {
            return Content(string.Format("Hello{0}", name));
        }
        public ActionResult Display()
        {
            return View(new Employ {EmployeeID=1,EmployeeName="Bhargav" }
            );     
          
        }
    }
}

