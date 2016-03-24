using System;

class Problem05
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("{0,-10}{1,-10}", "n", "Third digit 7?");
        Console.WriteLine("{0,-10}{1,-10}", n, (n / 100) % 10 == 7);
    }
}

