﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("0");

            }
            else if (b == 0)
            {
                Console.WriteLine("0");

            }
            else if (c == 0)
            {
                Console.WriteLine("0");

            }
            else if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");

            }
            else if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");

            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("+");

            }
            else if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("-");


            }
            else if (a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("+");

            }
            else if (a > 0 && b < 0 && c < 0)
            {
                Console.WriteLine("+");

            }
            else if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("-");

            }
        }
    }
}