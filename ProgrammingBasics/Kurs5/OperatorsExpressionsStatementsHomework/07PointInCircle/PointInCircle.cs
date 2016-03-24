using System;
class PointInCircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = Math.Pow(x, 2) + Math.Pow(y, 2) <= 4; // circle radius = 2    => 2^2 = 4

        Console.WriteLine(isInCircle);
    }
}
