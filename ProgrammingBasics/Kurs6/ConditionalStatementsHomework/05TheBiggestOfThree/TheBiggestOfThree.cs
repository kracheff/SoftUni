using System;
class TheBiggestOfThree
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("Biggest: {0}", firstNumber);
            }
            else
            {
                Console.WriteLine("Biggest: {0}", thirdNumber);
            }
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("Biggest: {0}", secondNumber);
            }
            else
            {
                Console.WriteLine("Biggest: {0}", thirdNumber);
            }
        }
    }
}