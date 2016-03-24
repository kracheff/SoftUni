using System;


namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c && b > c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);

            }
            else if (b > a && b > c && a > c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);

            }
            else if (b > a && b > c && c > a)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);

            }
            else if(a > b && c > b && a > c)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);

            }
            else if (c > b && c > a && b > a)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);

            }
            else if (c > b && a > b && c > a)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);

            }
        }
    }
}
