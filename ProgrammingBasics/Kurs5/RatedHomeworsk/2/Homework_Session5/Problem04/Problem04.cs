using System;

class Problem04
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * (width + height);
        double area = width * height;
        Console.WriteLine();
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}", "width", "height", "perimeter", "area");
        Console.WriteLine("{0,-10}{1,-10}{2,-10:0.###}{3,-10:0.###}", width, height, perimeter, area);
    }
}

