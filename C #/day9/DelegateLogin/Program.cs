using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLogin
{
    class Program
    {
        public delegate void Login(string user);
        public static event Login LoginSuccess;
        public static event Login LoginFailure;
        public static void Success(string user)
        {
            Console.WriteLine("Welcome" + user + "Capgemini");
        }
        public static void Failure(string user)
        {
            Console.WriteLine("Sorry" + user + "Invalid Details");
        }
        public static void Check(string user, string pad)
        {
            Dictionary<string, string> users = new Dictionary<String, string>();
            users["Arun"] = "Capgemini";
            users["Bhargav"] = "Krishna";
            users["Siva"] = "sada";
            users["prasanth"] = "kumar";
            string res = string.Empty;
            users.TryGetValues(s, out res);
            {
                if(res!=null)
                {
                    if (res.Equals(pass))
                    {
                        LoginSuccess += new LoginSuccess();
                    }
                }

            }
            if (user.Equals("Bhargav") && pad.Equals("capgemini")) 
            {
                LoginSuccess += new Login(Success);
                LoginSuccess(user);
            }           
            else
            {
                LoginFailure += new Login(Failure);
                LoginFailure(user);
            }
        }
        
        static void Main(string[] args)
        {
            string user, pad;
            Console.WriteLine("Enter user and Password");
            user = Console.ReadLine();
            pad = Console.ReadLine();
            Check(user, pad);
        }
    }
}
