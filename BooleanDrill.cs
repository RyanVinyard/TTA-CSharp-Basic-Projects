using System;



class Program
{
    static void Main()
    {
        Console.WriteLine("What is your age?");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("You have had a DUI, enter \"true\" or \"false\"");
        bool userDUI = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("How many speeding tickets do you have?");
        int userTickets = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");

        bool isQualified = (userAge > 15) && (userDUI != true) && (userTickets <= 3);

        Console.WriteLine("Do you qualify?");
        if (isQualified == true)
        {
            Console.WriteLine("You qualify!");
        }

        else
        {
            Console.WriteLine("Sorry, you do not qualify");
        }

        Console.ReadLine();
                       
    }
}

