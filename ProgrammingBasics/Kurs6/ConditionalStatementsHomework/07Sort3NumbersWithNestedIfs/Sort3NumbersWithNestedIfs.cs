using System;
class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a >= b)
        {
            if (a >= c)
            {
                if (b >= c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {2} {1}", a, b, c);
                }
            }
            else
            {
                Console.WriteLine("{2} {0} {1}", a, b, c);
            }
        }
        else
        {
            if (b <= c)
            {
                Console.WriteLine("{2} {1} {0}", a, b, c);
            }
            else
            {
                Console.WriteLine("{1} {2} {0}", a, b, c);
            }
        }
    }
}
