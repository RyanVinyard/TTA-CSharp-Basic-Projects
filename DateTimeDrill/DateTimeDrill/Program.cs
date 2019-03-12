using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current time is: " + currentTime);
            Console.WriteLine("Give me a number of hours to add to the current time: ");
            int extraHours = Convert.ToInt32(Console.ReadLine());
            
            DateTime newCurrentTime = currentTime.AddHours(extraHours);
            Console.WriteLine("Adding in " + extraHours + " hours, we have a new time of: " + newCurrentTime);

            Console.ReadLine();



        }
    }
}
