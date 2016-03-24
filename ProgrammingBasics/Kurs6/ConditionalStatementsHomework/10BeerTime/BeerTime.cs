using System;
class BeerTime
{
    static void Main()
    {
        DateTime input = new DateTime();
        bool isDateTime = DateTime.TryParse(Console.ReadLine(), out input);
        TimeSpan timeOnly = input.TimeOfDay;
        Console.WriteLine(timeOnly);

        TimeSpan startBeer = new DateTime(1, 1, 1, 13, 0, 0).TimeOfDay; // any date but specific time (13:00)
        TimeSpan endBeer = new DateTime(1, 1, 1, 3, 0, 0).TimeOfDay; // any date but specific time (03:00)

        if (isDateTime)
        {
            if (timeOnly >= startBeer || timeOnly <= endBeer)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("Invalid time");
        }
    }
}