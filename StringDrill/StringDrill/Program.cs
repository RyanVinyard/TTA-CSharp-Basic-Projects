using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        Console.WriteLine("What's your name?");
        string name = Console.ReadLine();

       
        string string1 = "Yo, what's up " + name + ",";
        string string2 = "My name is Ryan!";
        string string3 = "Drink Dr. Pepper!";
        
        Console.WriteLine(string1 + " " + string2 + " " + string3);
        Console.WriteLine("I'll say it again:");
        string upperString = string3.ToUpper();
        Console.WriteLine(upperString);
       

        StringBuilder sb = new StringBuilder();
        sb.Append(string2 + " ");
        sb.Append("Dr. Pepper is a delicious drink that is also probably nutritious. ");
        sb.Append("Your grandfather probably used to drink Dr. Pepper. ");
        sb.Append("Drink it at 10, drink it at 2, drink it at uhhhhhh 4? ");
        sb.Append("Yeah, definitely drink it at 4, that's the proper time for consuming Dr. Pepper. ");
        sb.Append("Every time I mention Dr. Pepper I get paid 5 cents! ");
        sb.Append("Run this program to make me rich!");

        Console.WriteLine(sb);
        Console.ReadLine();
        
    }
}

