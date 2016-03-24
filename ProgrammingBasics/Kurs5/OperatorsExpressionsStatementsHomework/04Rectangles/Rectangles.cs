using System;
class Rectangles
{
    static void Main()
    {
        Console.Write("Rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Rectangle's hight: ");
        double hight = double.Parse(Console.ReadLine());

        double area = width * hight;
        double perimeter = (width + hight) * 2;

        Console.WriteLine("Perimeter: {0}\nArea: {1}", perimeter, area);
    }
}
