using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill4
{
    class Program
    {
        static void Main(string[] args)
        {

            TestClass testClass = new TestClass();
                                    
            Console.WriteLine("Give me a number: ");
            int required = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you want, give a second number, or just hit enter: ");
            string optional = Console.ReadLine();
            if (optional == "")
            {
                required = testClass.TestMethod(required);
            }
            else
            {
                required = testClass.TestMethod(required, Convert.ToInt32(optional));
            }
            
            

          


            Console.WriteLine("We have: " + required);

            Console.ReadLine();

        }
    }
}
