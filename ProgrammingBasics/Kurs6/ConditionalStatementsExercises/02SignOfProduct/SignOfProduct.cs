using System;

class SignOfProduct
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        string product;

        if (
            (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0) ||
            (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0) ||
            (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0) ||
            (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0)
            )
        {
            product = "Negative";
        }
        else
        {
            product = "Positive";
        }

        Console.WriteLine(product);

        // second option:

        int counter = 0;

        if (firstNumber < 0)
        {
            counter++;
        }
        if (secondNumber < 0)
        {
            counter++;
        }
        if (thirdNumber < 0)
        {
            counter++;
        }
        if (counter == 1 || counter == 3)
        {
            product = "Negative";
        }
        else
        {
            product = "Positive";
        }

        Console.WriteLine(product);
    }
}
