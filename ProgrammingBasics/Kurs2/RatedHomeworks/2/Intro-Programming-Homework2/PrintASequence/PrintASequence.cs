﻿using System;

class PrintASequence
{
    static void Main()
    {
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 >= 1)
            {
                Console.Write("-" + i + ",");
            }
            else
            {
                Console.Write(i + ",");
            }
        }
    }
}
