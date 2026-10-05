using System;

class Circle
{
    const double PI = 3.14;
    
    public static double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }
    
    public static double CalculateCircumference(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        /*code with issue
         *double PI = 1.21;
        */
        
        int radius = 2;
        
        double area = Circle.CalculateArea(radius);
        double circumference = Circle.CalculateCircumference(radius);
        
        Console.WriteLine("Area of the circle: " + area);
        Console.WriteLine("Circumference of the circle: " + circumference);
    }
}