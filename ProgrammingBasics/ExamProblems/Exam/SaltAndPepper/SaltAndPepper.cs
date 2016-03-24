using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SaltAndPepper
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        while (command != "end")
        {
            string spice = command.Split(' ')[0];
            int step = int.Parse(command.Split(' ')[1]);

            for (int i = 0; i < 64; i += step)
            {
                if (spice == "salt")
                {
                    number &= ~((ulong)1 << i);
                }
                else
                {
                    number |= ((ulong)1 << i);
                }
            }
            command = Console.ReadLine();
        }
        Console.WriteLine(number);
    }
}
