using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coef \"a\"");
        double coefA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coef \"b\"");
        double coefB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coef \"c\"");
        double coefC = double.Parse(Console.ReadLine());

        double discriminant = (Math.Pow(coefB, 2)) - (4 * coefA * coefC);
        double root2 = (-coefB + Math.Sqrt(discriminant)) / (2 * coefA);
        double root1 = (-coefB - Math.Sqrt(discriminant)) / (2 * coefA);

        if (discriminant == 0)
        {
            Console.WriteLine("x1=x2={0:0.##}", root1);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            Console.WriteLine("x1={0:0.##}; x2={1:0.##}", root1, root2);
        }
    }
}
