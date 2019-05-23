using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace ConsoleApp1
{
    class EmployDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }

        public string Login(string USerId,string Password)
        {
            if (string.IsNullOrEmpty(USerId) || string.IsNullOrEmpty(Password))
            {
                return "Userid or password could not be empty";
            }
            else
            {
                if (USerId == "Admin" && Password == "Admin")
                {
                    return "Welcome Admin";
                }
                return "Incorrect UserID or Password";
            }
        }
        public List<EmployDetails>AllUsers()
        {
            List<EmployDetails> li = new List<EmployDetails>();
            li.Add(new EmployDetails
            {
             Id = 100,
             Name="Bhargav",
             Gender="Male",
             Salary=40000
            });
            li.Add(new EmployDetails
            {
                Id = 200,
                Name = "Arun",
                Gender = "Male",
                Salary = 50000
            });
            return li;           
        }
        public List<EmployDetails>GetDetails(int id)
        {
            List<EmployDetails> li1 = new List<EmployDetails>();
            var li = new EmployDetails().AllUsers();
            foreach (var x in li)
            {
                if (x.Id == id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }
    }
}
