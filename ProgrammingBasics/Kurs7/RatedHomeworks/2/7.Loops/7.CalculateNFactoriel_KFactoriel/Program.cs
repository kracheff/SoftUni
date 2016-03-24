using System;
using System.Numerics;


class CalculateNFactoriel_KFactoriel
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        uint k = uint.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        long factorialK = 1;
        BigInteger factorialNK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
        }
        for (int i = 1; i <= n - k; i++)
        {
            factorialNK *= i;
        }
        Console.WriteLine("{0}", factorialN /
        (factorialK * (factorialNK)));
    }
}