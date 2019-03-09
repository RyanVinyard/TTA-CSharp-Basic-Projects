using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            int parameter1 = 10;
            int parameter2 = 20;
            testClass.VoidMethod(parameter1, parameter2);
            Console.ReadLine();


        }
    }
}
