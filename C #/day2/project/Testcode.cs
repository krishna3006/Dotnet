using System;
using Util;

namespace ClientProg
{
	public class Testcode
	{
		static void Main(String[] args)
		{
			int a,b,c;
			Console.WriteLine("enter 2 numbers");
			a=Convert.ToInt32(Console.ReadLine());
			b=Convert.ToInt32(Console.ReadLine());
			Calc obj = new Calc();
			c=obj.Sum(a,b);
			Console.WriteLine($"Sum is {c}");
			c=obj.Sub(a,b);
			Console.WriteLine($"Sub is {c}");
			c=obj.Mult(a,b);
			Console.WriteLine($"Mult is {c}");
		}
	}
}