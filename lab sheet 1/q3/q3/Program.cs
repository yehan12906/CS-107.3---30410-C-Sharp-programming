﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3

{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a positive integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }

                Console.WriteLine($"The sum of numbers from 1 to {n} is: {sum}");
            }
        }
    }
}