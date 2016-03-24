using System;
using System.Globalization;
namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("h:mm tt");
            string timeString = Console.ReadLine();
            string format = "h:mm tt";
            DateTime entertime = DateTime.ParseExact(timeString, format, CultureInfo.InvariantCulture);
            DateTime starttime = DateTime.Parse("1:00 PM");
            DateTime endtime = DateTime.Parse("2:59 PM");
            if (entertime >= starttime || entertime <= endtime)
            {
                Console.WriteLine("Beer-time yaaay!!!");

            }
            else
            {

                Console.WriteLine("No bear time :C");

            }
        }
    }
}
