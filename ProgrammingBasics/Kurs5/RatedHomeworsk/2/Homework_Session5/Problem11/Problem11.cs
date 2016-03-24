using System;

class Problem11
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("{0,-10}{1,-25}{2,-10}", "n", "binary representatin", "bit #3");
        Console.WriteLine("{0,-10}{1,-25}{2,-10}", n, Convert.ToString(n, 2).PadLeft(16,'0'), (n >> 3) & 1);
    }
}

