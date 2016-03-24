using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FallenInLove
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("##{0}##{0}##", new string ('.', 2 * n));

        int waves = 1;
        int Outerdots = 2 * n - 2;
        int innerDots = 2;

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", 
                new string('~', waves), 
                new string('.', Outerdots), 
                new string('.', innerDots));
            waves++;
            Outerdots -= 2;
            innerDots += 2;
        }

        Outerdots = 1;
        waves = n;
        innerDots = 2 * n;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}#{1}#{2}#{1}#{0}",
                new string('.', Outerdots),
                new string('~', waves),
                new string('.', innerDots));
            Outerdots += 2;
            waves--;
            innerDots -= 2;
        }

        Console.WriteLine("{0}####{0}", new string('.', 2 * n + 1));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}##{0}", new string('.', 2 * n + 2));

        }
    }
}
