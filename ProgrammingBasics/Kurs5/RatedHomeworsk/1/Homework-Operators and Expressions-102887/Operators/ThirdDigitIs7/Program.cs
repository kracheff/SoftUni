using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("n: ");
        int number = int.Parse(Console.ReadLine());

        int restNumber = number / 100;
        int thirdDigit = restNumber % 10;
        bool seven = thirdDigit == 7;

        Console.WriteLine("Third digit 7?");
        Console.WriteLine(seven);
    }
}