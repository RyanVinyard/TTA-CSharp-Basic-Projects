using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            int solution = 0;
            TestClass testClass = new TestClass();

            Console.WriteLine("Enter a number to divide by 2.");
            int data = Convert.ToInt32(Console.ReadLine());

            testClass.TestMethod(data);
            Console.ReadLine();

            int output;

            testClass.OutputMethod(out output);

            Console.ReadLine();

            Console.WriteLine("I've overloaded the method SimpleAddition() by making two of the same method, one that takes 2 numbers and one that takes 3 numbers. Give me 2 numbers to add.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now give me a second number to add");
            int input2 = Convert.ToInt32(Console.ReadLine());
            solution = testClass.SimpleAddition(input1, input2);
            Console.WriteLine("Using the SimpleAddition method, we have the solution: " + solution);

            Console.WriteLine("\n Now we'll use three numbers. Give me the first one");
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now a second number");
            input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now the third number");
            int input3 = Convert.ToInt32(Console.ReadLine());
            solution = testClass.SimpleAddition(input1, input2, input3);
            Console.WriteLine("Using the overloaded method SimpleAddition, we have added the three numbers to equal " + solution);

            Console.ReadLine();

            StaticClass.StaticMethod();

            Console.ReadLine();

        }
    }
}
