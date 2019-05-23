using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class EmployController : ApiController
    {
        Employ[] arrEmploy = new Employ[]
        {
            new Employ{Empno=1,Name="Arun", Dept="Dotaet",Desig="Developer",Basic=65264},
            new Employ{Empno=2,Name="Bhargav", Dept="JAva",Desig="Trainer",Basic=98503},
            new Employ{Empno=3,Name="Anusha", Dept="SQL",Desig="Expert",Basic=95000},
            new Employ{Empno=4,Name="Siva", Dept="Dotnet",Desig="Developer",Basic=84620},
        };
        public IEnumerable<Employ>Get()
        {
            return arrEmploy;
        }
        public IHttpActionResult Get(int id)
        {
            var emp = arrEmploy.FirstOrDefault((e) => e.Empno == id);
            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);
        }
    }

}
