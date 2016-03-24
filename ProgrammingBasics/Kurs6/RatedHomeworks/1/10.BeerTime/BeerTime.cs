using System;

class BeerTime
{
    static void Main()
    {

        Console.WriteLine("Enter the time: ");
        DateTime startTime = new DateTime(1, 1, 1, 13, 0, 0);
        DateTime endTime = new DateTime(1, 1, 1, 3, 0, 0);

        try
        {
            DateTime currentTime = DateTime.Parse(Console.ReadLine());
            if ((currentTime.Hour >= startTime.Hour && currentTime.Hour < 24 ) || ( currentTime.Hour > 0 && currentTime.Hour < endTime.Hour))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non beer time");
            }
        }
        catch (Exception)
        {

            Console.WriteLine("invalid time"); ;
        }


    }
}

