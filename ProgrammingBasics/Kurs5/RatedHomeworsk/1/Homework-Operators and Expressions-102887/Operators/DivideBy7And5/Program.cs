using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DivideBy7And5

{
    static void Main()
    {
        Console.Write("n: ");
        int number = int.Parse(Console.ReadLine());
        bool divide = (number % 5 == 0) && (number % 7 == 0) && (number != 0);
        Console.WriteLine("Divided by 7 and 5 ?");
        Console.WriteLine(divide);
    }
}