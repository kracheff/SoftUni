using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddOrEvenIntegers
{
    static void Main()
    {        
        int number = int.Parse(Console.ReadLine());
        bool isOdd = false;

        if (number % 2 == 0)
        {
            isOdd = false;
            Console.WriteLine(isOdd);

        }
        else
        {
            isOdd = true;
            Console.WriteLine(isOdd);
        }
    }
}