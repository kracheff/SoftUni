using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial2N = 1;
        BigInteger factorialN = 1;
        BigInteger facturialNPlus1 = 1;
        for (int i = 1; i <= 2 * n; i++)
        {
            factorial2N *= i;
            if (i <= n)
            {
                factorialN *= i;
            }
        }
        for (int i = 1; i <= n + 1; i++)
        {
            facturialNPlus1 *= i;
        }
        Console.WriteLine("{0}", factorial2N / (factorialN *
        facturialNPlus1));
    }
}
