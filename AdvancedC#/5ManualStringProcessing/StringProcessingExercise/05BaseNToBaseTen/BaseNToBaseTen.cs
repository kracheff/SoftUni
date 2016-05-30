using System;
using System.Numerics;

public class BaseNToBaseTen
{
    public static void Main()
    {
        string[] inputParams = Console.ReadLine().Split();
        byte baseToConvert = byte.Parse(inputParams[0]);
        string numberToConvert = inputParams[1];

        BigInteger result = 0;

        for (int i = 0; i < numberToConvert.Length; i++)
        {
            result += (BigInteger)(byte.Parse(numberToConvert[i].ToString()) * 
                                    Math.Pow(baseToConvert, (double)numberToConvert.Length - i - 1));
        }

        Console.WriteLine(result);
    }
}
