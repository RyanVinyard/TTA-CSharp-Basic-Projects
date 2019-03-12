using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number here to log to a text file.");
            int textLog = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText("C:\\Users\\ravry\\source\\repos\\log.txt", Convert.ToString(textLog));
            File.ReadAllText("C:\\Users\\ravry\\source\\repos\\log.txt");
            using (StreamReader file = File.OpenText("C:\\Users\\ravry\\source\\repos\\log.txt"))
            {
                Console.WriteLine("Now logged in the text file is: " + file.ReadLine());
            }
                Console.ReadLine();
        }
    }
}
