using System;

class SumNumbers
{
    static void Main()
    {
        Console.Write("Write in the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Write in the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Write in the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Number a: " + firstNumber +
            " Number b: " + secondNumber +
            " Number c: " + thirdNumber);

        int sum;

        sum = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine("The sum of all three numbers is: " + sum);

    }
}

