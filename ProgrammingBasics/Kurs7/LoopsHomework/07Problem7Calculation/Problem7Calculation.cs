using System;
using System.Numerics;

class Problem7Calculation
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int nMinusK = n - k;

        BigInteger factorialN = 1;
        int factorialK = 1;
        BigInteger factorialNminusK = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                factorialN *= i;
                factorialK *= i;
            }
            else
            {
                factorialN *= i;
            }
        }
        for (int i = 1; i <= nMinusK; i++)
        {
            factorialNminusK *= i;
        }

        Console.WriteLine((factorialN / factorialK) / (factorialNminusK));
    }
}
