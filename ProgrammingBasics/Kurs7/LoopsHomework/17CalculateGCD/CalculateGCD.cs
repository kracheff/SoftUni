using System;
class CalculateGCD
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());

        long bigger = Math.Max(a, b);
        long smaller = Math.Min(a, b);
        long remainder = 1;

        while (remainder > 0)
        {
            remainder = bigger % smaller;
            bigger = smaller;
            smaller = remainder;
        }
        Console.WriteLine("GCD = " + bigger);
    }
}
