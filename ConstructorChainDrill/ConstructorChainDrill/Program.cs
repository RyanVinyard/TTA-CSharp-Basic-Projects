using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            const string science = "Science is empirical every single day.";
            var name = "Ryan";

            Console.WriteLine("My name is " + name + " and I'm here to say: " + science);
            name = name + " Vinyard";
            Console.WriteLine("My name is " + name + " and I'm here to say: " + science);

            Console.ReadLine();

            Student student1 = new Student("Ryan" , "Vinyard");
            var student2 = new Student("John");
            //These both work
            


            Console.WriteLine(student1.FirstName + " " + student1.LastName);
            Console.WriteLine(student2.FirstName + " " + student2.LastName);
            //student2 throws in the default "Smith" since no lastName parameter was specified

            Console.ReadLine();

                       


        }
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
                       

            public Student(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public Student(string firstName) : this(firstName, "Smith")
            {

            }


        }

    }
}
