using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { firstName = "Ryan", lastName = "Vinyard", id = 0 });
            employees.Add(new Employee() { firstName = "Bobson", lastName = "Dugnutt", id = 1 });
            employees.Add(new Employee() { firstName = "Mike", lastName = "Truk", id = 2 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Thefirstone", id = 3 });
            employees.Add(new Employee() { firstName = "Vegeta", lastName = "Princeofallsaiyans", id = 4 });
            employees.Add(new Employee() { firstName = "Sleve", lastName = "McDichael", id = 5 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Thesecondone", id = 6 });
            employees.Add(new Employee() { firstName = "Running", lastName = "Outofideas", id = 7 });
            employees.Add(new Employee() { firstName = "God", lastName = "Likefromthebible", id = 8 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "McGuinty", id = 9 });
            //This is a really bad way of making a list of people but I think it's probably fine for this exercise?

            foreach (Employee dude in employees)
            {
                if (dude.firstName == "Joe")
                {
                    Console.WriteLine(dude.firstName + " " + dude.lastName + " " + "ID number: " + dude.id);
                }
            }

            Console.WriteLine("Here's all the Joes using a foreach loop, now let's see if we get the same thing with a lambda expression.");
            Console.ReadLine();

            List<Employee> lambdaList = employees.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee dude in lambdaList)
            {
                Console.WriteLine(dude.firstName + " " + dude.lastName + " " + "ID: " + dude.id);
            }

            Console.ReadLine();
            Console.WriteLine("Now to list all employees with ID>5");

            List<Employee> lambdaIdList = employees.Where(x => x.id > 5).ToList();
            foreach (Employee dude in lambdaIdList)
            {
                Console.WriteLine(dude.firstName + " " + dude.lastName + " " + "ID: " + dude.id);
            }

            Console.ReadLine();
        }
    }
}
