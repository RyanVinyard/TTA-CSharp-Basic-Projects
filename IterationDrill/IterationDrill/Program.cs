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

        string favNumberString = Convert.ToString(Console.ReadLine());

        if(String.IsNullOrEmpty(favNumberString))
        {
            Console.WriteLine("You didn't enter a number, so I'll just assume your number is 5.");
            favNumber = 5;
        }

        favNumber = Convert.ToInt16(favNumberString);
        
        while (favNumber > 10 || favNumber < 1)
        {
            Console.WriteLine("That's not between 1 and 10, try again.");
            favNumber = Convert.ToInt16(Console.ReadLine());

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

        Console.ReadLine();

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
                
                Console.WriteLine(searchValue + " is at index value: " + secondList.IndexOf(number));
                j++;
                
            }

            if (!secondList.Contains(searchValue))
            {
                Console.WriteLine("That's not a number in the list, try again");
                searchValue = Console.ReadLine();
            }
        }

        Console.WriteLine("Looks like " + searchValue + " appeared in that list " + j + " times!");
        Console.ReadLine();









    }
}

