﻿using System;

class PrintLongSequence
{
    static void Main()
    {
        int numberToPrint;
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 0)
            {
                numberToPrint = i;
            }
            else
            {
                numberToPrint = i * (-1);
            }
            Console.Write(numberToPrint + ",");
        }
    }
}           