using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter circle radius: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Perimeter = {0:0.00} | Area = {1:0.00}", perimeter, area);
    }
}

