using System;

public class Demo3
{
	static void Main(string[] args)
	{
		int a,b,c;
		Console.WriteLine("enter 2 numbers");
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());
		c=a+b;
		Console.WriteLine($"Sum of {a} of {b} is {c}");
	}
}