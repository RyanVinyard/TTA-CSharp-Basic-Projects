using System;




class Program
{
    static void Main()
    {
        Console.WriteLine("Can you guess my name??");
        string guess = Console.ReadLine();
        bool nameIsGuessed = guess == "Ryan";

        while (!nameIsGuessed)
        {
           switch (guess)
            {
                case "Ryan":
                    Console.WriteLine("Yep, that's my name!");
                    nameIsGuessed = true;
                    break;

                default:
                    Console.WriteLine("No, that's not my name. Here's a hint: it starts with an R and rhymes with \"Lyin\"");
                    Console.WriteLine("Can you guess my name??");
                    guess = Console.ReadLine();
                    break;
            }
        }

        Console.WriteLine("Guess a number between 1 and 10.");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isGuessed = number == 7;

        do
        {
            switch (number)
            {
                case 7:
                    Console.WriteLine("Wow! You guessed it!");
                    isGuessed = true;
                    break;

                default:
                    Console.WriteLine("Wrong! Try again.");
                    Console.WriteLine("Guess a number between 1 and 10.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        while (!isGuessed);

        Console.ReadLine();
    }
}

