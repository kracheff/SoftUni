using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("n: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("p: ");
        int position = int.Parse(Console.ReadLine());

        int moveBit = number >> position;
        int foundBit = moveBit & 1;

        bool isOne = foundBit == 1;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("bit #{0} = '1' = {1}", position, isOne);
    }
}