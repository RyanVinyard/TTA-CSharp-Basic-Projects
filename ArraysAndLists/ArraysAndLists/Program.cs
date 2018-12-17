using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {

        string[] stringArray = { "a", "b", "c", "d", "e", "f", "g" };
        Console.WriteLine("Enter a number between 0 and 6 to print that letter from the array.");
        int entry = Convert.ToInt16(Console.ReadLine());
        
        while (entry < 0 || entry > 6)
        {
            Console.WriteLine("That isn't between 0 and 6, try again");
            entry = Convert.ToInt16(Console.ReadLine());

        }

        Console.WriteLine("The letter at index " + entry + " is: " + stringArray[entry]);
                                               
        Console.ReadLine();

        int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine("Enter a number between 0 and 6 to print that number from the array.");
        int numEntry = Convert.ToInt16(Console.ReadLine());
        
        while (numEntry < 0 || numEntry > 6)
        {
            Console.WriteLine("That isn't betweeen 0 and 6, try again");
            numEntry = Convert.ToInt16(Console.ReadLine());

        }

        Console.WriteLine("The number stored at index " + numEntry + " is: " + intArray[numEntry]);
    
        Console.ReadLine();

        List<string> stringList = new List<string>();
        stringList.Add("north");
        stringList.Add("east");
        stringList.Add("south");
        stringList.Add("west");

        Console.WriteLine("Enter a number between 0 and 3 to print the direction stored at that value from a list");
        int listEntry = Convert.ToInt16(Console.ReadLine());

        while (listEntry < 0 || listEntry > 3)
        {
            Console.WriteLine("That isn't between 0 and 3, try again");
            listEntry = Convert.ToInt16(Console.ReadLine());

        }

        Console.WriteLine("The direction stored at index value " + listEntry + " is: " + stringList[listEntry]);
        Console.ReadLine();

    }
}

