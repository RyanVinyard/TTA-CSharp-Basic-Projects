using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)

    {
        string[] christmasList = { "" , "" , "" , "" , "" };
        Console.WriteLine("If you could wish for any 5 things for Christmas, what would they be? Type them below.");
        
        for (int i = 0; i < 5 ; i++)
        {
            christmasList[i] = (i + 1) + ". " + Console.ReadLine();
        }

        Console.WriteLine("\nThanks! So here's your Christmas List:\n");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(christmasList[i]);
        }

        Console.WriteLine("\nOk, thanks for the list! Now, pick a number between 1 and 10");

        int favNumber = 0;
        
        while (!int.TryParse(Console.ReadLine(), out favNumber))
        {
            Console.WriteLine("Oops, you didn't enter anything.");
            Console.WriteLine("Pick a number between 1 and 10:");
        }

        while (favNumber > 10 || favNumber < 1)
        {
            Console.WriteLine("That's not between 1 and 10, try again.");
            

            while (!int.TryParse(Console.ReadLine(), out favNumber))
        {
            Console.WriteLine("Oops, you didn't enter anything.");
            Console.WriteLine("Pick a number between 1 and 10:");
        }

        }


        Console.WriteLine("Hah! I've tricked you! Now your favorite number is going to print forever in an endless loop!\n");

        //for (int i = 0; i > favNumber; i++)
        //{
        //    Console.WriteLine(favNumber);
        //}

        for (int i = 0; i < favNumber; i++)
        {
            Console.WriteLine(favNumber + " " + (i+1));
        }

        Console.WriteLine("Just kidding! I fixed the loop so it would only print so many times. Check the commented code for the endless loop. Hit enter and I'll do it again but slightly differently!");
        Console.ReadLine();

        for (int i = 1; i <= favNumber; i++)
        {
            Console.WriteLine(favNumber + " " + (i));
        }

       
        List<string> messyList = new List<string>();
        string[] numbers = { "two", "five", "four", "ten", "nine", "one", "three", "six", "eight", "seven" };
        messyList.AddRange(numbers);


        foreach (string number in messyList)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nOh no, we've got such a messy list of numbers above, and I need YOUR help to fix them. Type in one of the numbers and you can see what index it's at.");
        string searchValue = Console.ReadLine();

        foreach (string number in messyList)
        {
            if (searchValue == number)
            {
                Console.WriteLine(searchValue + " is at index value: " + messyList.IndexOf(number));
            }

            if (!messyList.Contains(searchValue))
            {
                Console.WriteLine("That's not a number in the list, did you make a typo? Try again.");
                searchValue = Console.ReadLine();
            }
        }


        List<string> secondList = new List<string>();
        string[] repeatingNumbers = { "one", "two", "two", "three", "one", "two", "one", "three", "four" };
        secondList.AddRange(repeatingNumbers);

        foreach (string number in secondList)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nWe have some more numbers here, type in a number to see how many indicies it appears in.");
        Console.WriteLine("I'm not running out of ideas, you're running out of ideas.");
        searchValue = Console.ReadLine();
        int j = 0;

        foreach (string number in secondList)
        {
            if (searchValue == number)
            {
                
                j++;
                                
            }

            if (!secondList.Contains(searchValue))
            {
                Console.WriteLine("That's not a number in the list, try again");
                searchValue = Console.ReadLine();
            }
        }

        Console.WriteLine("Looks like " + searchValue + " appeared in that list " + j + " times! Wow!\n");

        List<string> sodaList = new List<string>();
        string[] sodas = { "Coke", "Pepsi", "Dr. Pepper", "Coke", "Sprite", "Dr. Pepper", "Root Beer" };
        sodaList.AddRange(sodas);
        foreach (string soda in sodaList)
        {
            Console.WriteLine(soda);
        }
        Console.WriteLine("\nHere's a list of sodas, let's see what the duplicates are.\n");
        
        int s = 0;
        List<string> checkList = new List<string>();



        foreach (string soda in sodaList)
        {
            if (checkList.Contains(soda))
            {
                Console.WriteLine(soda + " has already appeared on this list!");
                s++;
            }
            if (!checkList.Contains(soda))
            {
                Console.WriteLine(soda + " has not yet appeared on this list!");
                checkList.Add(soda);                
            }
                        
        }

        Console.WriteLine("Looks like there were " + s + " duplicates in there.");

        Console.ReadLine();










    }
}

