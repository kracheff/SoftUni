using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ChangeEvenBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        ushort[] allNumbers = new ushort[n];

        for (int i = 0; i < n; i++)
        {
            ushort num = ushort.Parse(Console.ReadLine());
            allNumbers[i] = num;
        }

        ulong L = ulong.Parse(Console.ReadLine());

        ushort bitCounter = 16;
        ushort lastBit = 0;
        ushort changedBits = 0; // counter of actually changed bits
        ushort bitAtPosition = 1; // this will store the bit at even position and will be used to count the actually changed bits

        for (int i = 0; i < n; i++)
        {
            // find the real number of bits
            bitCounter = 16;

            for (int bitPos = 15; bitPos >= 0; bitPos--)
            {
                lastBit = (ushort)((allNumbers[i] >> bitPos) & 1);
                if (lastBit == 1)
                {
                    break;
                }
                bitCounter--;
            }
            //int len = 0;
            //do
            //{
            //    num = num / 2;
            //    len++;
            //} while (num > 0);


            for (int j = 0; j < bitCounter * 2; j+=2)
            {
                if (((L >> j) & 1) == 0)
                {
                    changedBits++;
                }
                L = L | (ulong)(1L << j);
            }
        }
        Console.WriteLine(L);
        Console.WriteLine(changedBits);
    }
}
