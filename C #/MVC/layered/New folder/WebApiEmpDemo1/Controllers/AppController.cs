using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using WebApiEmpDemo1.Models;

namespace WebApiEmpDemo1.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Index()
        {
            IEnumerable<EMp> list = null;
            using (var client = new HttpClient())
            {
                //url of WebApi project
                client.BaseAddress = new Uri("http://localhost:51083/api/");
                //Http GEt
                var responseTask = client.GetAsync("emps");
                //wait for task to complete
                responseTask.Wait();
                //retrieve the result
                var result = responseTask.Result;
                //chjeck the status code for success
                if (result.IsSuccessStatusCode)
                {
                    //read the result
                    var readTask = result.Content.ReadAsAsync<IList<EMp>>();
                    readTask.Wait();
                    //fill the list variable created above with the return
                    list = readTask.Result;
                }
                else //web ai sent error response
                {
                    list = Enumerable.Empty<EMp>();
                    ModelState.AddModelError(string.Empty, "server Error.Please contact administrator.");
                }
            }
            return View(list);
        }


        // GET: App/Details/5
        public ActionResult Details(int id)
        {
            // variable to hold the person details retrieved from WebApi
            EMp emp = null;
            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:51083/api/");
                //HTTP GET
                var responseTask = client.GetAsync("emps?ID=" + id.ToString());
                // wait for task to complete
                responseTask.Wait();
                // retrieve the result
                var result = responseTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    // read the result
                    var readTask = result.Content.ReadAsAsync<EMp>();
                    readTask.Wait();
                    // fill the person vairable created above with the returned result
                    emp = readTask.Result;
                }
            }
            return View(emp);
        }

        // GET: App/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: App/Create
        [HttpPost]
        public ActionResult Create(EMp emp)
        {
            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:51083/api/");
                //HTTP POST
                var postTask = client.PostAsJsonAsync<EMp>("emps",
                    emp);
                // wait for task to complete
                postTask.Wait();
                // retrieve the result
                var result = postTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            // Add model error
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            // send the view back with model error
            return View(emp);
        }


        // GET: App/Edit/5
        public ActionResult Edit(int id)
        {
            // variable to hold the person details retrieved from WebApi
            EMp emp = null;

            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:51083/api/");
                //HTTP GET
                var responseTask = client.GetAsync("emps/" + id.ToString());
                // wait for task to complete
                responseTask.Wait();
                // retrieve the result
                var result = responseTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    // read the result
                    var readTask = result.Content.ReadAsAsync<EMp>();
                    readTask.Wait();
                    // fill the person vairable created above with the returned result
                    emp = readTask.Result;
                }
            }
            return View(emp);
        }


        // POST: App/Edit/5
        [HttpPost]
        public ActionResult Edit(EMp obj)
        {
            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress =
                    new Uri("http://localhost:51083/api/");
                //HTTP POST
                var putTask = client.PutAsJsonAsync<EMp>("emps", obj);
                // wait for task to complete
                putTask.Wait();
                // retrieve the result
                var result = putTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    // Return to Index
                    return RedirectToAction("Index");
                }
            }
            // Add model error
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            // send the view back with model error 
            return View(obj);
        }


        // GET: App/Delete/5
        public ActionResult Delete(int id)
        {
            // variable to hold the person details retrieved from WebApi
            EMp emp = null;

            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:51083/api/");
                //HTTP GET
                var responseTask = client.GetAsync("emps/" + id.ToString());
                // wait for task to complete
                responseTask.Wait();
                // retrieve the result
                var result = responseTask.Result;
                // check the status code for success
                if (result.IsSuccessStatusCode)
                {
                    // read the result
                    var readTask = result.Content.ReadAsAsync<EMp>();
                    readTask.Wait();
                    // fill the person vairable created above with the returned result
                    emp = readTask.Result;
                }
            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            // send the view back with model error 
            return View(emp);
        }

        // POST: App/Delete/5
        [HttpPost]
        public ActionResult Delete(EMp emp)
        {
            // variable to hold the person details retrieved from WebApi
            int ID = emp.Empno;

            using (var client = new HttpClient())
            {
                // Url of Webapi project
                client.BaseAddress = new Uri("http://localhost:51083/api/");
                //HTTP Delete
                var responseTask = client.DeleteAsync("emps/" + ID.ToString());
                // wait for task to complete
                responseTask.Wait();
                // retrieve the result
                var deleteTask = responseTask.Result;
                // check the status code for success
                if (deleteTask.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }
    }
}
