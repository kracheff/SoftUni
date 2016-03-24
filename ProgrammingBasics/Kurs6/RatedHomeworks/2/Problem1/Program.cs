using System;


namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a > b || b > a)
            {
                Console.WriteLine("{1} {0}", a, b);

            }
            else
            {
                Console.WriteLine("Numbers are even");
            }


        }
    }
}
