using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseExam
{
    class ExerciseExam
    {
        static void Main(string[] args)
        {
            // input
            int europeAlbumsCount = int.Parse(Console.ReadLine());
            decimal europeAlbumPrice = decimal.Parse(Console.ReadLine());
            int southAmericaAlbumsCount = int.Parse(Console.ReadLine());
            decimal southAmericaAlbumPrice = decimal.Parse(Console.ReadLine());
            int northAmericaAlbumsCount = int.Parse(Console.ReadLine());
            decimal northAmericaAlbumPrice = int.Parse(Console.ReadLine());
            int concertCount = int.Parse(Console.ReadLine());
            decimal concertPrice = int.Parse(Console.ReadLine());

            // conver currency to BGN

            europeAlbumPrice = europeAlbumPrice * 1.94M;
            northAmericaAlbumPrice *= 1.72M;
            southAmericaAlbumPrice /= 332.74M;

            // Calculate income from albums

            decimal albumIncome = 0;
            albumIncome += (europeAlbumsCount * europeAlbumPrice);
            albumIncome = albumIncome + (northAmericaAlbumsCount * northAmericaAlbumPrice);
            albumIncome += (southAmericaAlbumPrice * southAmericaAlbumsCount);

            // Deduct producer fee, deduct tax

            albumIncome = albumIncome - albumIncome * 0.35M;
            albumIncome = albumIncome - albumIncome * 0.2M;

            // Calculate income from concerts

            decimal concertIncome = concertCount * concertPrice;

            // If money from concerts > 100K, than deduct 15%
            
            if (concertIncome > 100000)
            {
                concertIncome = concertIncome - concertIncome * 0.15m;
            }

            // Check which is bigger
            if (albumIncome>concertIncome)
            {
                Console.WriteLine("lets...");
            }
            else
            {
                Console.WriteLine("on the road again");
            }

            // Output
        }
    }
}
