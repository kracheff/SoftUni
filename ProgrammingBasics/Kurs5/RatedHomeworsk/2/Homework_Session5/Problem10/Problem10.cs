using System;

class Problem10
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double r = 1.5;
        string YesNo = "no";

        if(((x - 1) * (x - 1) + (y - 1) * (y - 1) <= r * r) && y > 1)
        {
            YesNo = "yes";
        }

        Console.WriteLine();
        Console.WriteLine("{0,-10}{1,-10}{2,-30}", "x", "y", "inside K & outside of R");
        Console.WriteLine("{0,-10}{1,-10}{2,-30}", x, y, YesNo);
    }
}

