using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SaltAndPeppers2
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
                    if (((number >> i) & 1) == 1)
                    {
                        number &= ~((ulong)1 << i);
                    }
                }
                else
                {
                    if (((number >> i) & 1) == 0)
                    {
                        number |= (ulong)1 << i;
                    }
                }
            }
            command = Console.ReadLine();
        }
        Console.WriteLine(number);
    }
}
