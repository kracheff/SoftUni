using System;

class Problem12
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("{0,-10}{1,-25}{2,-10}{3,-10}", "n", "binary representatin", "p", "bit @ p");
        Console.WriteLine("{0,-10}{1,-25}{2,-10}{3,-10}", n, Convert.ToString(n, 2).PadLeft(16, '0'), p, (n >> p) & 1);
    }
}

