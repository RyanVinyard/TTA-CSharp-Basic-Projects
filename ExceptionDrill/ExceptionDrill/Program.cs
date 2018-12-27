using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<int> numberedList = new List<int>();
        int[] numbers = { 1, 12, 6, 44, 55 };
        numberedList.AddRange(numbers);

        

        try
        {
            Console.WriteLine("Enter a number and I'll divide 1, 12, 6, 44, and 55 by it.");
            int userNumber = Convert.ToInt16(Console.ReadLine());
            int result = 0;

            foreach (int number in numberedList)
            {
                result = number / userNumber;
                Console.WriteLine(result);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("That's not a number, try again.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You can't divide by zero!");
        }
        catch (Exception)
        {
            Console.WriteLine("I'm not sure what you did to get here, but you did something wrong.");
        }
       

        Console.ReadLine();



    }
}

