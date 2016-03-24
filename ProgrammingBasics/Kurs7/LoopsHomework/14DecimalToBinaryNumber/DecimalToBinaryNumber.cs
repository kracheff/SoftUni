using System;
class DecimalToBinaryNumber
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());

        long remainder = 0;
        long result = input;
        string binaryReversed = string.Empty;
        string binary = string.Empty;

        while (result > 0)
        {
            remainder = result % 2;
            result /= 2;
            binaryReversed += remainder.ToString();
        }
        for (int i = 0; i < binaryReversed.Length; i++)
        {
            binary += binaryReversed[binaryReversed.Length - i - 1];
        }
        Console.WriteLine(binary);
    }
}
