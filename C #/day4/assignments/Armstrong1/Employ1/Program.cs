using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employ1
{
    class Employ
    {
        int empno;
        string Name;
        double basic;
    }


    Employ[] res;
    public void ReadEmploy(int n)
    {
        Employ[] arr = new Employ[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = new Employ();
            Employ e1 = new Employ();
            Console.WriteLine("Enter empno,Name, Basic");
            arr[i].empno = Convert.ToInt32(Console.ReadLine());
            arr[i].Name = Console.ReadLine();
            arr[i].Basic = Convert.ToDouble(Console.ReadLine());
        }
        res = arr;
    }
}

    public void ShowEmploy()
    {
        foreach (Employ e in res)
        {
            Console.WriteLine(e.empno + " " + e.name + " " + e.basic);
        }
    }
    static void Main(string[]args)
    {
        int n;
        Console.WriteLine(("Enter no.of employees");
        n = Convert.ToInt32(Console.ReadLine());
        Employ e = new Employ();
        e.ReadEmploy(n);
        e.ShowEmploy(n);
    }
        