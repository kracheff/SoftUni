using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d= ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e= ");
        double e = double.Parse(Console.ReadLine());
        double biggest = 0;

        if (a >= b && a >= c && a >= d && a >= e)
        {
            biggest = a;
        }
        if (b >= a && b >= c && b >= d && b >= e)
        {
            biggest = b;
        }
        if (c >= a && c >= b && c >= d && c >= e)
        {
            biggest = c;
        }
        if (d >= a && d >= b && d >= c && d >= e)
        {
            biggest = d;
        }
        if (e >= a && e >= b && e >= c && e >= d)
        {
            biggest = e;
        }
        Console.WriteLine("biggest= {0}", biggest);
    }
}
