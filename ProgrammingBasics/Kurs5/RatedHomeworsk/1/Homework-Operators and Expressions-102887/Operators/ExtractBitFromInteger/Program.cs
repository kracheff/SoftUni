using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("n: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("p: ");
        int position = int.Parse(Console.ReadLine());

        int fakeBit = 1 << position;
        int foundBit = number & fakeBit;

        if (foundBit == 0)
        {
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("bit #{0} = '0'", position);
        }
        else
        {
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("bit #{0} = '1'", position);            
        }
    }
}