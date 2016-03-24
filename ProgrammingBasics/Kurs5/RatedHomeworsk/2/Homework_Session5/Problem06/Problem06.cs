using System;

class Problem06
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long firstDigit = n / 1000;
        long secondDigit = (n / 100) % 10;
        long thirdDigit = (n / 10) % 10;
        long fourthDigit = n % 10;

        long sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
        long reversed = fourthDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + firstDigit;
        long lastInFront = fourthDigit * 1000 + firstDigit * 100 + secondDigit * 10 + thirdDigit;
        long SecThird = firstDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + fourthDigit;

        Console.WriteLine();
        Console.WriteLine("{0,-5}{1,-15}{2,-10}{3,-20}{4,-15}", "n", "Sum of digits", "Reversed", "Last digit in front", "second and third digits exchanged");
        Console.WriteLine("{0,-5}{1,-15}{2,-10}{3,-20}{4,-15}", n, sum, reversed, lastInFront, SecThird);

    }
}

