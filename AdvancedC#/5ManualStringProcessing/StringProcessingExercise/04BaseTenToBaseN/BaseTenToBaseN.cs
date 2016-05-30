using System;
using System.Numerics;

public class BaseTenToBaseN
{
    public static void Main()
    {
        string[] inputParams = Console.ReadLine().Split();
        byte baseToConvert = byte.Parse(inputParams[0]);
        BigInteger numberToConvert = BigInteger.Parse(inputParams[1]);

        string result = string.Empty;

        while (numberToConvert > 0)
        {
            result += numberToConvert % baseToConvert;
            numberToConvert /= baseToConvert;
        }

        char[] resultToChar = result.ToCharArray();
        Array.Reverse(resultToChar);
        Console.WriteLine(new string(resultToChar));
    }
}
