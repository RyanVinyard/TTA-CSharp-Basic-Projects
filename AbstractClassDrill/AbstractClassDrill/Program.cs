using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee();
            person.FirstName = "Sample";
            person.LastName = "Student";

            person.SayName();

            Console.ReadLine();


        }
    }
}
