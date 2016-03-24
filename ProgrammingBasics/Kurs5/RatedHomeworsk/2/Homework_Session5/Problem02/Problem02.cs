using System;

class Problem02
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("{0,-10}{1,-10}", "weight", "weight on the Moon");
        Console.WriteLine("{0,-10}{1,-10:0.###}", n, n*0.17);
    }
}

