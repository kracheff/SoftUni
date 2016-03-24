using System;
class RandomNumbersInGivenRange
{
    static void Main()
    {
        Random randomN = new Random();

        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(randomN.Next(min, max + 1) + " ");
        }
        Console.WriteLine();
    }
}
