﻿using System;
class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Please enter \"a\": ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter \"b\": ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter \"h\": ");
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) * h / 2d;

        Console.WriteLine("Area = " + area);
    }
}
