using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();

            int userInteger = 12;
            double userDecimal = 0.556;
            string userString = "54";


            userInteger = testClass.TestMethod(userInteger);
            

            userDecimal = testClass.TestMethod(userDecimal);
            

            userString = testClass.TestMethod(userString);
            

            Console.WriteLine("The returned values are: " + userInteger + " , " + userDecimal + " , " + userString);
            Console.ReadLine();


        }
    }
}
