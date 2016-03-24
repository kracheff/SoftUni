using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Tests
    {
        static void Main(string[] args)
        {
            string c = "\u00A9";
            // Console.WriteLine(c);
            Console.WriteLine(c.PadLeft(5));
        }
    }
}
