using System;
class TheBiggestOfFive
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        if (a >= b &&
            a >= c &&
            a >= d &&
            a >= e)
        {
            Console.WriteLine("Biggest: " + a);
        }
        else if (b >= a &&
            b >= c &&
            b >= d &&
            b >= e)
        {
            Console.WriteLine("Biggest: " + b);
        }
        else if (c >= a &&
            c >= b &&
            c >= d &&
            c >= e)
        {
            Console.WriteLine("Biggest: " + c);
        }
        else if (d >= a &&
            d >= b &&
            d >= c &&
            d >= e)
        {
            Console.WriteLine("Biggest: " + d);
        }
        else if (e >= b &&
            e >= c &&
            e >= d &&
            e >= a)
        {
            Console.WriteLine("Biggest: " + e);
        }
    }
}
