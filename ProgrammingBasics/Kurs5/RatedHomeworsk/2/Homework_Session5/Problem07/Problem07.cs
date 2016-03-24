using System;

class Problem07
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double r = 2;
        
        Console.WriteLine();
        Console.WriteLine("{0,-10}{1,-10}{2,-10}", "x", "y", "inside");
        Console.WriteLine("{0,-10}{1,-10}{2,-10}", x, y, x*x + y*y <= r*r);
    }
}

