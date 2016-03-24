using System;
class MultiplicationSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        int counter = 0;

        if (a < 0)
        {
            counter++;
        }
        if (b < 0)
        {
            counter++;
        }
        if (c < 0) 
        {
            counter++;
        }
        if (counter == 1 || counter == 3)
        {
            Console.WriteLine("-");
        }
        else if (counter == 2 || counter == 0)
        {
            Console.WriteLine("+");
        }
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
    }
}
