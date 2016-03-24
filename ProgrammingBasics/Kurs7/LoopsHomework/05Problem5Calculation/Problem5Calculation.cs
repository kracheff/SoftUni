using System;
class Problem5Calculation
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        int factorial = 1;
        int power = 1;
        double s = 1d;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            power = (int)Math.Pow(x, i);
            double devision = (double)factorial / power;
            s += devision;
        }
        Console.WriteLine(s);
    }
}
