using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Ryan";
            person.LastName = "Vinyard";

            

            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            person.SayName();

            employee.SayName();

            Console.ReadLine();

        }
    }
}
