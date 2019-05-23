using System;

public class Demo1
{
 static void Main(string[] args)
{
  String topic="Dotnet Training";
  Console.WriteLine("Topic"+topic);
  Console.WriteLine("Topic is{0}",topic);
  Console.WriteLine($"Topic is {topic}");
  String student="Bhargav";
  String city="Hyderabad";
  Console.WriteLine("Student" +student+ "City" +city);
  Console.WriteLine("Student {0} City {1}", student,city);
  Console.WriteLine($"Student {student} City {city}");
  }
}