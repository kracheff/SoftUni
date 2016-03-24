using System;
class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Integer (N): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Position of bit (P): ");
        int p = int.Parse(Console.ReadLine());

        int nRightP = n >> p;
        bool isBitOne = (nRightP & 1) == 1;
        Console.WriteLine(isBitOne);
    }
}
