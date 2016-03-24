using System;
class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Integer (N): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Position of bit (P): ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Value (V = 0 or 1): ");
        int v = int.Parse(Console.ReadLine());

        int zeroMask = ~(1 << p);
        int oneMast = 1 << p;

        int vEqualsZero = n & zeroMask;
        int vEqualsOne = n | oneMast;

        Console.WriteLine(v == 0? vEqualsZero : vEqualsOne);
    }
}
