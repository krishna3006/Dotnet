using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Addition(int firstNum,int secondNum)
        {
            ViewBag.Total = firstNum + secondNum;
            return View();
        }
    }
}