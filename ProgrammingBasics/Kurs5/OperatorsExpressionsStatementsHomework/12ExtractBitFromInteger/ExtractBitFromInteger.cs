using System;
class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Integer (N): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Position of bit (P): ");
        int p = int.Parse(Console.ReadLine());

        int nRightP = n >> p;
        int bitAtP = nRightP & 1;

        Console.WriteLine("Bit at position P is: " + bitAtP);
    }
}
