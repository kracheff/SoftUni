using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            List<int> allNumbers = new List<int>();

            // read the input
            string firstList = Console.ReadLine();
            string secondList = Console.ReadLine();

            // split the input
            string[] firstInts = firstList.Split(' ');
            string[] secondInts = secondList.Split(' ');

            // add first input to the list
            for (int i = 0; i < firstInts.Length; i++)
            {
                allNumbers.Add(Convert.ToInt32(firstInts[i]));
            }

            //add second input to the same list
            for (int i = 0; i < secondInts.Length; i++)
            {
                allNumbers.Add(int.Parse(secondInts[i]));
            }

            // The New list where the unique numbers will be stored
            List<int> theNewList = new List<int>();

            // Add only the unique integers
            for (int i = 0; i < allNumbers.Count; i++)
            {
                if (!theNewList.Contains(allNumbers[i])) // does not contain (with "!"-sign)
                {
                    theNewList.Add(allNumbers[i]);
                }
            }

            // Sort the new list
            theNewList.Sort();
            Console.WriteLine();

            // Print the new list
            for (int i = 0; i < theNewList.Count; i++)
            {
                Console.Write(theNewList[i] + " ");
            }

        }
    }
}
