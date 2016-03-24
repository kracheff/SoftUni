using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Weight: ");
        double weight = double.Parse(Console.ReadLine());
        double weightOnTheMoon = (weight * 0.17);
        Console.WriteLine("Weight on the Moon: " + weightOnTheMoon);
    }
}