using System;

class Program
{
    static void Main()
    {
        Console.Write("write in number a: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Write in number b: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Write in number c: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("|{0, -10:x}|{1}|{2, 10:f2}|{3, -10:f3}|",
        firstNumber,
        Convert.ToString(firstNumber, 2).PadLeft(10, '0'),
        secondNumber,
        thirdNumber);
    }
}

