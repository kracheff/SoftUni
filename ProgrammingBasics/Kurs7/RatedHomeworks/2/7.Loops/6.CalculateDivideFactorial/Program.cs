using System;



class CalculateDivideFactorial
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int factorialN = 1;
        int factorialK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
        }
        Console.WriteLine("{0}", factorialN / factorialK);
    }
}

