using System;
class BiggestOfThree
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("Max: {0}", firstNumber);
            }
            else
            {
                Console.WriteLine("Max: {0}", thirdNumber);
            }
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("Max: {0}", secondNumber);
            }
            else
            {
                Console.WriteLine("Max: {0}", thirdNumber);
            }
        }
    }
}
