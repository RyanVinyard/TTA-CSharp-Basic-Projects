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
        int favNumber = Convert.ToInt16(Console.ReadLine());
        while (favNumber > 10 || favNumber < 1)
        {
            Console.WriteLine("That's not between 1 and 10, try again.");
           
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

        Console.WriteLine("Just kidding! I fixed the loop so it would only print so many times. Check the commented code for the endless loop. Hit enter and I'll do it again in reverse!");
        Console.ReadLine();

        for (int i = favNumber; i > 0; i--)
        {
            Console.WriteLine(favNumber + " " + (i));
        }

        Console.ReadLine();







    }
}

