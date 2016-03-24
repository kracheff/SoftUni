using System;

class Problem03
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("{0,-10}{1,-10}", "n", "Devided by 7 and 5?");
        Console.WriteLine("{0,-10}{1,-10:0.###}", n, n == 0 ? false : n % 7 == 0 && n % 5 == 0);
    }
}

