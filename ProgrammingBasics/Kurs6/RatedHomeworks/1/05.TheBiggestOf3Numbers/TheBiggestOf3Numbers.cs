using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());
        double biggest = 0;

        if (a > b && a > c)
        {
            biggest = a;
        }
        else if (b > a && b > c)
        {
            biggest = b;
        }
        else if (c > a && c > b)
        {
            biggest = c;
        }
        Console.WriteLine("biggest= {0}", biggest);
    }
}

