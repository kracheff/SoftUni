using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Power
{
    class Power
    {
        public static double PowerOfNumber (double number, int power, bool roundDown)
        {
            if (roundDown)
            {
                return Math.Floor(Math.Pow(number, power));
            }
            else
            {
                return Math.Pow(number, power);
            }
        }

        public static double PowerOfNumber(double number, int power)
        {
                return Math.Pow(number, power);
        }


        static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            int inputPower = int.Parse(Console.ReadLine());
            bool inputRounding = bool.Parse(Console.ReadLine());

            Console.WriteLine(PowerOfNumber(inputNumber, inputPower, inputRounding));
        }
    }
}
