﻿using System;
class Average
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        double average = (a + b + c) / 3d;

        Console.WriteLine(average);
    }
}
