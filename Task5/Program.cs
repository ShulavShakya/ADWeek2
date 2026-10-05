using System;

class Program
{
    static void Main(string[] args)
    {
        //Declaration and Initiation
        DateTime DoB = DateTime.Parse("2006-09-06");
        DateTime currentDate = DateTime.Now;
        
        //Current Age
        int age = currentDate.Year - DoB.Year;
        Console.WriteLine("DoB: " + DoB);
        Console.WriteLine("current: " + currentDate);
        Console.WriteLine("Age: " + age);
        
        //Adding 10 Days
        DateTime futureDate = DoB + new TimeSpan(10, 0, 0, 0);
        Console.WriteLine("Future Date: " + futureDate);
    }
}