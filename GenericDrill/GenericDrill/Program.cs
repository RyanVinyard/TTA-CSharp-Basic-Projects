using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<String> employee1 = new Employee<String>();
            List<string> strings = new List<string>();
            strings.Add("A");
            strings.Add("B");
            strings.Add("C");

            employee1.Things = strings;

            Employee<int> employee2 = new Employee<int>();
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);

            employee2.Things = ints;

            foreach (string i in employee1.Things)
                Console.WriteLine(i);

            foreach (int i in employee2.Things)
                Console.WriteLine(i);

            Console.ReadLine();
            



        }
    }
}
