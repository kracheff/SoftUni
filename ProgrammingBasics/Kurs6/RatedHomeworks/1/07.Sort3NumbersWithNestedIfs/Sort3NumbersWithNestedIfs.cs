﻿using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            if (b > c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("{0} {2} {1}", a, b, c);
            }
        }
        else if (b >= a && b >= c)
        {
            if (a > c)
            {
                Console.WriteLine("{1} {0} {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("{1} {2} {0}", a, b, c);
            }
        }
        else if (c >= a && c >= b)
        {
            if (a > b)
            {
                Console.WriteLine("{2} {0} {1}", a, b, c);
            }
            else
            {
                Console.WriteLine("{2} {1} {0}", a, b, c);
            }
        }
    }
}
