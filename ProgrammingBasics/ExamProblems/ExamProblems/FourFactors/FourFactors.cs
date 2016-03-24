using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FourFactors
{
    static void Main()
    {
        uint fg = uint.Parse(Console.ReadLine());
        uint fga = uint.Parse(Console.ReadLine());
        uint threeP = uint.Parse(Console.ReadLine());
        uint tov = uint.Parse(Console.ReadLine());
        uint orb = uint.Parse(Console.ReadLine());
        uint oppDrb = uint.Parse(Console.ReadLine());
        uint ft = uint.Parse(Console.ReadLine());
        uint fta = uint.Parse(Console.ReadLine());

        double efg = (fg + 0.5 * threeP) / fga;
        double tovPercent = tov / (fga + 0.44 * fta + tov);
        double orbPercent = orb / (double)(orb + oppDrb);
        double ftPercent = ft / (double)fga;

        Console.WriteLine("eFG% {0:0.000}", efg);
        Console.WriteLine("TOV% {0:0.000}", tovPercent);
        Console.WriteLine("ORB% {0:0.000}", orbPercent);
        Console.WriteLine("FT% {0:0.000}", ftPercent);

    }
}
