using System;
class ExtractBit3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int nRightThree = n >> 3;

        int result = nRightThree & 1;
        Console.WriteLine(result);
    }
}
