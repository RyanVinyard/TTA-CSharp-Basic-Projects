﻿using System;
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

            Console.ReadLine();

        }
    }
}