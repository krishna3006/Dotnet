using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcdemo3.Models;

namespace mvcdemo3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AspxView()
        {
            return View();
        }
        public ActionResult RazerView()
        {
            return View();
        }
        //http://localhost:54916/home/PrintIgate
        public ActionResult PrintIgate()
        {
            return Content("IGATE");
        }
        //http://localhost:54916/home/PrintID/1212
        public ContentResult PrintId(string id)
        {
            return Content(string.Format("{0}",id));
        }
        //http://localhost:54916/home/PrintName?name=Moto
        public ContentResult PrintName(string name)
        {
            return Content(string.Format("Hello {0}", name));
        }
        public ActionResult Display()
        {
            return View
            (
                new Employee
                {
                    EmpId = 55566,
                    EmpName = "Nishanth"
                }
           );
        }


    }
}