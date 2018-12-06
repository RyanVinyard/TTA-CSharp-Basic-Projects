using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Give me a number");
        int multiplyNumber = Convert.ToInt32(Console.ReadLine());
        long multiplyLong = multiplyNumber * 50;
        Console.WriteLine("If we multiply " + multiplyNumber + " by 50, we get: " + multiplyLong + "!");
        Console.WriteLine("");

        Console.WriteLine("Give me a second number");
        int addNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("If we add 25 to " + addNumber + " we get: " + (addNumber + 25));
        Console.WriteLine("");

        Console.WriteLine("Give me a third number");
        int divideNumber = Convert.ToInt32(Console.ReadLine());
        double divideFloat = (float)divideNumber / 12.5;
        Console.WriteLine(divideNumber + " divided by 12.5 is: " + divideFloat);
        Console.WriteLine("");

        Console.WriteLine("Give me a fourth number");
        int checkNumber = Convert.ToInt32(Console.ReadLine());
        int constant = 50;
        bool checkBool = checkNumber > constant;
        Console.WriteLine("It is " + checkBool + " that your number is greater than " + constant + ".");
        Console.WriteLine("");

        Console.WriteLine("Ok, give me one last number, please.");
        int result = Convert.ToInt32(Console.ReadLine());
        int moduloNumber = result % 7;
        Console.WriteLine("If you divide " + result + " by 7, you get a remainder of " + moduloNumber);
        Console.ReadLine();

    }
    }
