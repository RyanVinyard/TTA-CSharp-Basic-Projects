using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            Console.WriteLine("Please enter the current day of the week.");
            do
            {
                string currentDay = Console.ReadLine();
                try
                {

                    Days day = (Days)Enum.Parse(typeof(Days), currentDay);
                    stop = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please write a valid day of the week.");

                }
            } while (stop == false);
            

            Console.WriteLine("Cool, that's a real day of the week!");
            Console.ReadLine();
            

        }
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
