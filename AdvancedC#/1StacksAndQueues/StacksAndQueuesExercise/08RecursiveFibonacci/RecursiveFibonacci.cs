using System;
using System.Collections.Generic;
public class RecursiveFibonacci
{
    public static long[] memo;

    public static void Main()
    {
        byte number = byte.Parse(Console.ReadLine().Trim());
        memo = new long[number + 1];
        Console.WriteLine(GetFibonacci(number));
    }

    //public static long GetFibonacci(byte number)
    //{
    //    if (number <= 1)
    //    {
    //        return 1;
    //    }
    //    return GetFibonacci((byte)(number - 1)) + GetFibonacci((byte)(number - 2));
    //}

    public static long GetFibonacci(byte number)
    {
        if (number <= 2)
        {
            return 1;
        }

        if (memo[number] != 0)
        {
            return memo[number];
        }

        memo[number] = GetFibonacci((byte)(number - 1)) +
                       GetFibonacci((byte)(number - 2));

   
        return memo[number];
    }
}