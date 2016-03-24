using System;
class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        long inputToNumber = 0;
        long inputToHex = 0;
        for (int i = 0; i < input.Length; i++)
        {
            string inputAtPosition = input[i].ToString();
            switch (inputAtPosition)
            {
                case "0": inputToNumber = 0; break;
                case "1": inputToNumber = 1; break;
                case "2": inputToNumber = 2; break;
                case "3": inputToNumber = 3; break;
                case "4": inputToNumber = 4; break;
                case "5": inputToNumber = 5; break;
                case "6": inputToNumber = 6; break;
                case "7": inputToNumber = 7; break;
                case "8": inputToNumber = 8; break;
                case "9": inputToNumber = 9; break;
                case "A": inputToNumber = 10; break;
                case "B": inputToNumber = 11; break;
                case "C": inputToNumber = 12; break;
                case "D": inputToNumber = 13; break;
                case "E": inputToNumber = 14; break;
                case "F": inputToNumber = 15; break;

                default: Console.WriteLine("Not a valid Hexadecimal number"); break;

            }
            inputToHex += inputToNumber * (long)Math.Pow(16, input.Length - i - 1);

        }
        Console.WriteLine(inputToHex);
    }
}
