using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Integers
{
    class Integers
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] newArray = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;// rnd.Next(0, 101);
                if (i == 0)
                {
                    newArray[i] = array[i];
                }
                else
                {
                    newArray[i] = newArray[i - 1] + array[i];
                }
                //Console.WriteLine(array[i]);
                Console.WriteLine(newArray[i]);
            }

        }
    }
}
