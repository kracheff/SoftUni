using System;
class Program
{
    static void Main(string[] args)
    {
        // input

        int pages = 24; // int.Parse(Console.ReadLine());
        byte campingDays = 5; // byte.Parse(Console.ReadLine());
        byte pagesPerDay = 0; // byte.Parse(Console.ReadLine());

        // output

        if (campingDays == 30)
        {
            Console.WriteLine("never");
        }
        else
        {
            int effectiveDays = 30 - campingDays;
            int pagesPerMonth = pagesPerDay * effectiveDays;
            double totalMonths = ((double)pages / pagesPerMonth);

            Console.WriteLine(totalMonths);
        }
    }
}