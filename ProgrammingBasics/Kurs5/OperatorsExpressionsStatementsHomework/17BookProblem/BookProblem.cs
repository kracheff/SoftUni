using System;
class BookProblem
{
    static void Main()
    {
        // input

        int pages = int.Parse(Console.ReadLine());
        byte campingDays = byte.Parse(Console.ReadLine());
        byte pagesPerDay = byte.Parse(Console.ReadLine());

        // output

        if (campingDays == 30)
        {
            Console.WriteLine("never");
        }
        else
        {
            int years = (pages / ((30 - campingDays) * pagesPerDay)) / 12;
            double months = Math.Ceiling(((double) pages / ((30 - campingDays) * pagesPerDay)) % 12);

            Console.WriteLine("" + years + " years " + months + " months");
        }
    }
}
