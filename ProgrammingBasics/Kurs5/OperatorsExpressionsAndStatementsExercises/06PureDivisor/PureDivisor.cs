﻿using System;
class PureDivisor
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isDevisable = (n % 9) == 0 || (n % 11) == 0 || (n % 13) == 0;
        Console.WriteLine(isDevisable);
    }
}
