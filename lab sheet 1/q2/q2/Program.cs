﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{

    class Program

    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number #{i + 1}: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{number} is {(number % 2 == 0 ? "even" : "odd")}");
            }
        }

    }
}