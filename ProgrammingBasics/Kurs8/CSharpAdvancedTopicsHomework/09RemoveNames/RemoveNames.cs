using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            List <string> originalText  = new List<string>();
            
            string inputOriginal = Console.ReadLine();
            string inputRemove = Console.ReadLine();

            string[] split = inputOriginal.Split(' ');
            string[] splitRemove = inputRemove.Split(' ');

            for (int i = 0; i < split.Length; i++)
            {
                originalText.Add(split[i]);
            }

            for (int i = 0; i < splitRemove.Length; i++)
            {
                foreach (var item in split)
                {
                    originalText.Remove(splitRemove[i]);
                }

            }
            for (int i = 0; i < originalText.Count; i++)
            {
                Console.WriteLine(originalText[i]);
            }
        }
    }
}
