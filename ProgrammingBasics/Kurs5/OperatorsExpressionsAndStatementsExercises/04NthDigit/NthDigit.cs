using System;
class NthDigit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int number = int.Parse(Console.ReadLine());

        double nDigit = (int)(number / Math.Pow(10, n - 1)) % 10;
        Console.WriteLine(nDigit);
        Console.WriteLine(Convert.ToString(number).Length < n ? "-" : nDigit.ToString());

        if (Convert.ToString(number).Length < n)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine(nDigit);
        }
    }
}
