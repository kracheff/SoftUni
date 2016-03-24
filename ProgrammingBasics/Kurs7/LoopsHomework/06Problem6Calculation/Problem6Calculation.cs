using System;
class Problem6Calculation
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int factorialN = 1;
        int factorialK = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {                
                factorialK *= i;
            }

            factorialN *= i;
            //else
            //{
            //    factorialN *= i;
            //}
        }
        Console.WriteLine((double)factorialN / factorialK);
    }
}
