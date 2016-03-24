using System;
class KingOfThieves
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char type = char.Parse(Console.ReadLine());
        int dashes = (n - 1) / 2;
        int chars = 1;

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string(type, chars));
            dashes--;
            chars += 2;
        }

        Console.WriteLine("{0}", new string(type, n));

        dashes = 1;
        chars = (n - 2);

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string(type, chars));
            dashes++;
            chars -= 2;
        }
    }
}
