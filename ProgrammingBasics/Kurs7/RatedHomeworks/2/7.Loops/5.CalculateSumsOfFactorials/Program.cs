using System;

class CalculateSumsOfFactorials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int factorial = 1;
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += (factorial / Math.Pow(x, i));
        }
        // Math.Pow(2, 3); // 2 ^ 3
        Console.WriteLine(" sum = {0:F5}", sum);
    }
}

