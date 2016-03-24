using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Exercise
    {
        static void Main(string[] args)
        {
            int firefighters = 5; // int.Parse(Console.ReadLine());
            string command = "SSAKA"; // Console.ReadLine();
            int totalSavedKids = 0;
            int totalSavedAdults = 0;
            int totalSavedSeniors = 0;

            //while (command != "rain")
            //{
            //    command = Console.ReadLine();
            //}

            int kids = 0;
            int adults = 0;
            int seniors = 0;

            foreach (char letter in command)
            {
                switch (letter)
                {
                    case 'A': adults++; break;
                    case 'S': seniors++; break;
                    case 'K': kids++; break;
                    default:
                        break;
                }
            }
            if (firefighters - kids >= 0)
            {
                totalSavedKids +=kids
            }

        }
    }
}
