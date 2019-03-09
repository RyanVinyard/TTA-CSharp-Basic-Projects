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
            int optional = Convert.ToInt32(Console.ReadLine());

            required = testClass.TestMethod(required, optional);


            Console.WriteLine("We have: " + required);

            Console.ReadLine();

        }
    }
}
