using System;




class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("How much does the package weigh in pounds?");
        double packageWeight = Convert.ToDouble(Console.ReadLine());

        if (packageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
            Environment.Exit(0);

        }

        Console.WriteLine("What is the package width in inches?");
        double packageWidth = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What is the package height in inches?");
        double packageHeight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What is the package length in inches?");
        double packageLength = Convert.ToDouble(Console.ReadLine());

        double dimensions = (packageWidth + packageHeight + packageLength);

        if (dimensions > 50)
        {
            Console.WriteLine("Package is too big to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
            Environment.Exit(0);
        }

        double quote = (dimensions * packageWeight) / 100;

        Console.WriteLine("Your quote is: $" + quote);
        Console.ReadLine();


    }
}

