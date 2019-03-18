using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What's up my dude, how old are you?");
                bool validAnswer = false;
                int age = 0;

                while (validAnswer == false)
                {
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Please enter a number.");
                }
                if (age<0)
                {
                    throw new FormatException();
                }
                if (age==0)
                {
                    throw new NullReferenceException();
                }

                DateTime currentTime = DateTime.Now;
                int currentYear = currentTime.Year;
                int birthYear = currentYear - age;
                                              

                Console.WriteLine("You were born in the year " + birthYear + " or possibly in the year " + (birthYear-1) + " if you haven't had your birthday yet this year!");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("This is a negative number... Try it again.");
                Console.ReadLine();
                return;

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("You BUFFOON. You can't be ZERO YEARS OLD!!");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("You messed up real bad. I'm not even sure what you did. Try it again.");
                Console.ReadLine();
            }
            
            

        }
    }
}
