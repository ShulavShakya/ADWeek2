using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = ["apple", "banana", "cherry"];
        
        // Adding a new fruit to the list
        fruits.Add("watermelon");
        
        // Removing a fruit from the list
        fruits.Remove("cherry");

        // Iterating through the list and printing each fruit
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        
        // Creating a dictionary to store fruit names with their corresponding IDs
        Dictionary<int, string> fruits2 = new Dictionary<int, string>();
        fruits2[1] = "apple";
        fruits2[2] = "banana";
        fruits2[3] = "cherry";
        
        fruits2[4] = "watermelon";

        // Iterating through the dictionary and printing each fruit with its ID
        foreach (KeyValuePair<int, string> fruit in fruits2)
        {
            Console.WriteLine(fruit.Key + ": " + fruit.Value);
        }
    }
}