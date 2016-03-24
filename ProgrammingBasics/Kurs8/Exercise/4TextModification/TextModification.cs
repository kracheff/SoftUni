using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4TextModification
{
    class TextModification
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            int[] inputAsArray = new int[inputText.Length];
            int[] newInput = new int[inputText.Length];

            for (int i = 0; i < inputText.Length; i++)
            {
                inputAsArray[i] = inputText[i];

                if (inputAsArray[i] % 3 == 0 && 
                    ((inputAsArray[i] >= 65 && inputAsArray[i] <= 90) || 
                    (inputAsArray[i] >= 97 && inputAsArray[i] <= 122)))
                {
                    newInput[i] = inputAsArray[i] - 32;
                }
                else
                {
                    newInput[i] = inputAsArray[i];
                }
                Console.Write((char) newInput[i]);
            }
            Console.WriteLine();
        }
    }
}
