using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WiggleWiggle
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');
        long[] numbers = new long[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            numbers[i] = long.Parse(elements[i]);
        }

        for (int i = 0; i < numbers.Length; i += 2)
        {
            long firstBit = 0;
            long secondBit = 0;

            for (int bitPosition = 0; bitPosition < 64; bitPosition += 2)
            {
                firstBit = (1L << bitPosition) & numbers[i];
                secondBit = (1L << bitPosition) & numbers[i+1];

                if (firstBit != secondBit)
                {
                    numbers[i] ^= 1L << bitPosition;
                    numbers[i+1] ^= 1L << bitPosition;
                }
                //Console.Write(firstBit);

                numbers[i] |= (1L << 63);
                numbers[i+1] |= (1L << 63);

            }

            numbers[i] = ~numbers[i];
            numbers[i+1] = ~numbers[i+1];

            //Console.WriteLine();
            Console.WriteLine("{1} {0}", Convert.ToString(numbers[i], 2).PadLeft(63, '0'), (ulong)numbers[i]);
            Console.WriteLine("{1} {0}", Convert.ToString(numbers[i+1], 2).PadLeft(63, '0'), (ulong)numbers[i + 1]);
        }

    }
}
