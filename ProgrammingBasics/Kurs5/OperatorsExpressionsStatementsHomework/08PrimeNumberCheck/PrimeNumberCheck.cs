using System;
class PrimeNumberCheck
{
    static void Main()
    {
        sbyte n = sbyte.Parse(Console.ReadLine());

        bool isPrime = n % 2 != 0 && n % 3 != 0 && n % 4 != 0
            && n % 5 != 0 && n % 6 != 0 && n % 7 != 0
            && n % 8 != 0 && n % 9 != 0 && n % 10 != 0 && n != 1
            || n == 2 || n == 3 || n == 5 || n == 7;

        Console.WriteLine("Is Prime: " + isPrime);
    }
}
