using System;
class ThirdDigitIsSeven
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int thirdDigit = (n / (int) Math.Pow(10, 2)) % 10;
        bool isSeven = thirdDigit == 7;
        Console.WriteLine(isSeven);
    }
}
