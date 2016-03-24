using System;
class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double temp = 0d;
        for (int i = 1; i <= n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            temp += number;
        }
        Console.WriteLine(temp);
    }
}
