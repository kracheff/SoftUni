using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GameOfBits
{
    static void Main()
    {
        uint inputNumber = uint.Parse(Console.ReadLine());
        string command = string.Empty;
        int newNumber = (int)inputNumber;
        int count = 0;
        int numberForCounting = 0;

        command = Console.ReadLine();

        while (command != "Game Over!")
        {
            count = 0;
            uint[] bits = new uint[32];
            if (command == "Odd")
            {
                for (int i = 0, counter = 0; i < 32; i += 2, counter++)
                {
                    bits[counter] = (inputNumber >> i) & 1;
                }
            }
            else
            {
                for (int i = 1, counter = 0; i < 32; i += 2, counter++)
                {
                    bits[counter] = (inputNumber >> i) & 1;
                }
            }

            // make the new number after the bit extraction
            newNumber = 0;
            for (int i = 0; i < 32; i++)
            {
                if (bits[i] == 0)
                {
                    newNumber &= ~(1 << i);
                }
                else
                {
                    newNumber |= 1 << i;
                }
            }

            inputNumber = (uint)newNumber;
            command = Console.ReadLine();

        }
        // count of bits with value 1
        numberForCounting = newNumber;
        while (numberForCounting != 0)
        {
            count++;
            numberForCounting &= (numberForCounting - 1);
        }

        Console.WriteLine("{0} -> {1}", newNumber, count);
    }
}
