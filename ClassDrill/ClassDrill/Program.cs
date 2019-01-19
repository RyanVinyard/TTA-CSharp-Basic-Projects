using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings honored traveller! Give me a number, and we'll perform some MATHMAGIC™ on it!");
            int myNumber = Convert.ToInt32(Console.ReadLine());
            
            MathMagic math = new MathMagic();
            int addResult = 0;
            int subResult = 0;
            int multResult = 0;
            addResult = math.Addition(myNumber);
            subResult = math.Subtraction(myNumber);
            multResult = math.Multiplication(myNumber);

            Console.WriteLine("Using a method, I can tell you that " + myNumber + " plus 10 is: " + addResult);
            Console.WriteLine("Using another method, I can tell you that " + myNumber + " minus 100 is: " + subResult);
            Console.WriteLine("Finally, using another method, I can tell you that " + myNumber + " times 3 is: " + multResult);
            Console.ReadLine();
       
        }
    }
}
