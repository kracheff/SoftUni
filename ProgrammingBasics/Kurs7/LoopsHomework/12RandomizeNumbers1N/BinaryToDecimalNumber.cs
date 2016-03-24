using System;
class BinaryToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        long inputToDecimal = 0;

        for (int i = 0; i < input.Length; i++)
        {
            string numberAtPosition = input[i].ToString();
            inputToDecimal += long.Parse(numberAtPosition) * (long)Math.Pow(2, input.Length - i - 1);
        }
        Console.WriteLine(inputToDecimal);
    }
}
