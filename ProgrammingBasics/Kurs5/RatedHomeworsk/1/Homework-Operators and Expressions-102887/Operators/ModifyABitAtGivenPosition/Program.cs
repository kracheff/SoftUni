using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("n: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("p: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("v [0/1]: ");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

        if (value == 1)
        {
            int setOne = 1 << position;
            int foundBitOne = number | setOne;
            Console.WriteLine(Convert.ToString(foundBitOne, 2).PadLeft(16, '0'));
            Console.WriteLine(foundBitOne);
        }
        else
        {
            int setZero = ~(1 << position);
            int foundBitZero = number & setZero;
            Console.WriteLine(Convert.ToString(foundBitZero, 2).PadLeft(16, '0'));
            Console.WriteLine(foundBitZero);
        }
    }
}