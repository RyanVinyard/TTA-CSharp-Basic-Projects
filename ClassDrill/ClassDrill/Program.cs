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

            MathClass mathOne = new MathClass();

            Console.WriteLine("Give input number: ");
            int userInput = Convert.ToInt16(Console.ReadLine());
            userInput = mathOne.MathMethod1(userInput);

            Console.WriteLine("Running MathMethod1 to add 12, your number becomes " + userInput);
            Console.ReadLine();
            userInput = mathOne.MathMethod2(userInput);
            Console.WriteLine("Running MathMethod2 to multiply by 3, your number becomes " + userInput);
            Console.ReadLine();
            userInput = mathOne.MathMethod3(userInput);
            Console.WriteLine("Running MathMethod3 to divide by 2, your number becomes roughly " + userInput);
            Console.ReadLine();
            
                        
            
        }
    }
}
