using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Write("n: ");
        int number = int.Parse(Console.ReadLine());

        int fakeBit = 1 << 3;
        int foundBit = number & fakeBit;

        if (foundBit == 0)
        {
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("bit #3 = '0' ");
        }
        else
        {
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("bit #3 = '1' ");
        }
    }
}