using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {5, 7, 6, 3, 1};
        
        //sorting in ascending order
        Array.Sort(numbers);

        //reversing sorted array
        Array.Reverse(numbers);
        
        //printing each element through loop
        foreach (int n in numbers)
        {
            Console.Write(n + " ");
        }
        
        //finding index of 6 in sorted array
        int index = Array.IndexOf(numbers, 6);
        Console.WriteLine("\nIndex of 6: " + index);
    }
}