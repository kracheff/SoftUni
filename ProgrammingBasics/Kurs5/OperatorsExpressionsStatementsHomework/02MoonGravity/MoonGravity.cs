using System;
class MoonGravity
{
    static void Main()
    {
        Console.Write("Please enter your weight: ");
        double weight = double.Parse(Console.ReadLine());
        double moonWeight = weight * 0.17;
        Console.WriteLine(moonWeight);
    }
}
