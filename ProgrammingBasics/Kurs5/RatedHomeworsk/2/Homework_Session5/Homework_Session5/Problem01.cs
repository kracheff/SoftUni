using System;

class Problem01
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("{0,-10}{1,-10}","n", "Odd?");
        Console.WriteLine("{0,-10}{1,-10}", n, n % 2 != 0);
    }
}

