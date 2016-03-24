using System;
class BigAndOdd
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isTrue = n > 20 && (n % 2) == 1;
        Console.WriteLine(isTrue);
    }
}
