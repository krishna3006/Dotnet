using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class BookDemo
    {
        public static void Show(string[][] s, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" book details like author,publisher,name and price");
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(s[i][j]);
                }
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter number of books you want to read");
            n = Convert.ToInt32(Console.ReadLine());
            string[][] books = new string[n][];
            for (int i = 0; i < n; i++)
            {
                books[i] = new string[4];
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter book details like author,publisher,name and price");
                for (int j = 0; j < 4; j++)
                {
                    books[i][j] = Console.ReadLine();
                }
            }

            Show(books, n);

        }
    }
}

