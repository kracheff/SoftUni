using System;
class Sunlight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int totalLength = 3 * n;

        Console.WriteLine(new string('.', (3 * n - 1) / 2) + '*' + new string('.', (3 * n - 1) / 2));

        for (int i = 1; i <= n - 1; i++)
        {
            Console.WriteLine(new string('.', i) + '*' + new string('.', (totalLength - 3 - 2 * i) / 2) +
                '*' + new string('.', (totalLength - 3 - 2 * i) / 2) + '*' + new string('.', i));
        }

        for (int i = 1; i <= (n - 1) / 2; i++)
        {
            Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
        }

        Console.WriteLine(new string('*', totalLength));

        for (int i = 1; i <= (n - 1) / 2; i++)
        {
            Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
        }

        for (int i = n - 1; i >= 1; i--)
        {
            Console.WriteLine(new string('.', i) + '*' + new string('.', (totalLength - 3 - 2 * i) / 2) +
    '*' + new string('.', (totalLength - 3 - 2 * i) / 2) + '*' + new string('.', i));
        }

        Console.WriteLine(new string('.', (3 * n - 1) / 2) + '*' + new string('.', (3 * n - 1) / 2));

    }
}
