using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        public void Check(String user, string pad)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("Tamil", "Selva");
            users.Add("Bhargav", "Krishna");
            users.Add("Arun", "Jai");
            users.Add("Shiva", "Sada");
            string res = string.Empty;
            users.TryGetValue(user, out res);
            if (res == null)
            {
                Console.WriteLine("username is wrong");

            }
            else
            {
                if (res.Equals(pad))
                {
                    Console.WriteLine("Correct Credentials..");
                }
                else
                {
                    Console.WriteLine("Invalid credentials..");
                }
            }

        }
        static void Main(string[] args)
        {
            string user,pad;
            Console.WriteLine("enter username and password");
            user = Console.ReadLine();
            pad = Console.ReadLine();
            new Program().Check(user, pad);
            
        }
    }
}
