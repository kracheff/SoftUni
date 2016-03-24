using System;
class SumOfThreeNumbers
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum of these numbers is " + (firstNumber + secondNumber + thirdNumber));
        Console.WriteLine("First number {0} + Second number {1} + Third number {2} = {3}",
            firstNumber,
            secondNumber,
            thirdNumber,
            firstNumber + secondNumber + thirdNumber);
    }
}

