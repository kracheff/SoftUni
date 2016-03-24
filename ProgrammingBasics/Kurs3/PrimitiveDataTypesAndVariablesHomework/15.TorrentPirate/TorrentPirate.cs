using System;
class TorrentPirate
{
    static void Main()
    {
        int d = int.Parse(Console.ReadLine());
        byte p = byte.Parse(Console.ReadLine());
        byte w = byte.Parse(Console.ReadLine());
        
        double downloadTime = (double) d / 2 / 3600;
        double downloadPrice = downloadTime * w;
        double moviesNo = (double) d / 1500;
        double cinemaVisitPrice = moviesNo * p;

        if (downloadPrice > cinemaVisitPrice)
        {
            Console.WriteLine("cinema -> {0:0.00}lv", cinemaVisitPrice);
        }
        else
        {
            Console.WriteLine("mall -> {0:0.00}lv", downloadPrice);
        }
    }
}
