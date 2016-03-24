using System;

class Problem14
{
    static void Main()
    {
        Console.WriteLine("n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("v:");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("p:");
        int p = int.Parse(Console.ReadLine());
        int result;

        if (v == 0)
        {
            result = n & (~(1 << p));
        }
        else
        {
            result = n | (1 << p);
        }

        Console.WriteLine();
        Console.WriteLine("{0,-10}{1,-25}{2,-10}{3,-10}{4,-25}{5,-10}", "n", "binary representatin", "p", "v", "binary result", "result");
        Console.WriteLine("{0,-10}{1,-25}{2,-10}{3,-10}{4,-25}{5,-10}", n, Convert.ToString(n, 2).PadLeft(16, '0'), p, v, Convert.ToString(result, 2).PadLeft(16, '0'), result);
    }
}

