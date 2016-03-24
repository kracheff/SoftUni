using System;
class InsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter coordinates \"x\": ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter coordinates \"y\": ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) <= Math.Pow(1.5, 2);
        bool isOutsideRectange = x > 5 || x < -1 || y > 1 || y < -1;
        bool isBoth = isInCircle && isOutsideRectange;

        Console.WriteLine("Point is in both: " + (isBoth == true? "Yes" : "No"));
    }
}
