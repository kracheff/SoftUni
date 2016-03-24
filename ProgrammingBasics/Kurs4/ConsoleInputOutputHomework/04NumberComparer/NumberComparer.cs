using System;
class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Please enter first number");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("The bigger number is: {0}", (firstNumber + secondNumber + Math.Abs(firstNumber - secondNumber)) / 2);
        Console.WriteLine("The bigger number is: {0}", Math.Max(firstNumber, secondNumber));
        Console.WriteLine("The smaller number is: {0}", (firstNumber + secondNumber - Math.Abs(firstNumber - secondNumber)) / 2);
        Console.WriteLine("The smaller number is: {0}", Math.Min(firstNumber, secondNumber));
    }
}
