using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program\n");
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate:");
        double hourlyRate1 = (float)Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hours Worked per Week:");
        double hoursWorked1 = (float)Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate:");
        double hourlyRate2 = (float)Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hours Worked per Week:");
        double hoursWorked2 = (float)Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");

        double annualSalary1 = (hourlyRate1 * hoursWorked1) * 50;
        double annualSalary2 = (hourlyRate2 * hoursWorked2) * 50;
        bool comparison = annualSalary1 > annualSalary2;

        Console.WriteLine("Annual salary of Person 1:");
        Console.WriteLine(annualSalary1);

        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(annualSalary2);

        Console.WriteLine("\nDoes Person 1 make more money than Person2?");
        Console.WriteLine(comparison);
        Console.ReadLine();
                     
    }
}

