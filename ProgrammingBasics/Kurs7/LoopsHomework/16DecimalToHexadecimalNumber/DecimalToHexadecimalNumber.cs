using System;
class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());

        long remainder = 0;
        long result = input;
        string letters = string.Empty;
        string hexaReversed = string.Empty;
        string hexa = string.Empty;

        while (result > 0)
        {
            remainder = result % 16;

            switch (remainder)
            {
                case 10: letters = "A"; break;
                case 11: letters = "B"; break;
                case 12: letters = "C"; break;
                case 13: letters = "D"; break;
                case 14: letters = "E"; break;
                case 15: letters = "F"; break;

                default: letters = remainder.ToString(); break;
            }

            result /= 16;
            hexaReversed += letters;
        }
        for (int i = 0; i < hexaReversed.Length; i++)
        {
            hexa += hexaReversed[hexaReversed.Length - i - 1];
        }
        Console.WriteLine(hexa);
    }
}
