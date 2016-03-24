using System;
class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        double firstDouble = double.Parse(Console.ReadLine()); // = -0.0000007d;
        Console.WriteLine("Enter second numner");
        double secondDouble = double.Parse(Console.ReadLine()); // = 0.00000007d;
        Console.WriteLine("First number: " + firstDouble.ToString("0.##########"));
        Console.WriteLine("Second number: " + secondDouble.ToString("0.##########"));
        double difference = Math.Round(Math.Abs(firstDouble - secondDouble),8);
        Console.WriteLine("Difference: " + difference.ToString("0.###########"));
        if (difference < 0.000001)
        {
            Console.WriteLine("True" + "\n" + "The difference " + difference.ToString("0.##########") + " < eps");
        }
        if (difference == 0.000001)
        {
            Console.WriteLine("False" + "\n" + "Border case. The difference 0.000001 == eps. We consider the numbers are different.");
        }
        if (difference > 0.000001)
        {
            Console.WriteLine("False" + "\n" + "The difference of " + difference.ToString("0.##########") + " is too big (> eps)");
        }
    }
}

