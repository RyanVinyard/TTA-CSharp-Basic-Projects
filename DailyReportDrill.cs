using System;




class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report" + Environment.NewLine);

        Console.WriteLine("What course are you on?");
        string currentCourse = Console.ReadLine();
        Console.WriteLine(""); //Used a blank line to make the program look a little prettier
               
        Console.WriteLine("What page are you currently on?");
        string stringPage = Console.ReadLine();
        int currentPage = Convert.ToInt32(stringPage);
        Console.WriteLine("");

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
        string stringHelp = Console.ReadLine();
        bool needHelp = Convert.ToBoolean(stringHelp);
        Console.WriteLine("");

        Console.WriteLine("Do you have any positive experiences you'd like to share? Please give specifics.");
        string positiveExperience = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string studentFeedback = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("How many hours did you study today?");
        string stringStudyHours = Console.ReadLine();
        int studyHours = Convert.ToInt32(stringStudyHours);
        Console.WriteLine("");

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();

               
    }
}

