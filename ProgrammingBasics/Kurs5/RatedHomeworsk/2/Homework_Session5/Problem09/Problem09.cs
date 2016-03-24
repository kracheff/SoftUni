using System;

class Problem09
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());


        Console.WriteLine();
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}", "a", "b", "h", "area");
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}", a, b, h, (a+ b)*h/2);
    }
}

