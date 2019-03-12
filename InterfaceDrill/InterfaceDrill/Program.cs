using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee();

            IQuittable quit = new Employee();

            quit.Quit(person);

            Person person1 = new Employee();
            Person person2 = new Employee();

            person1.Id = 01;
            person2.Id = 01;

            bool isEqual = person1 == person2;
            Console.WriteLine("Is the id of person1 equal to person2? " + isEqual);


            Console.ReadLine();

        }
    }
}