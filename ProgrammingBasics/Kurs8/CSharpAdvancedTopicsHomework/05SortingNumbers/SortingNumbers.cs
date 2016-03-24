using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SortingNumbers
{
    class SortingNumbers
    {

        static int[] numbersToSort(int n)
        {
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++) // filling the array with the input numbers
            {
                int inputNumber = int.Parse(Console.ReadLine());
                numbers[i] = inputNumber;
            }
            Array.Sort(numbers);
            return numbers;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] sortedArray = numbersToSort(n);

            for (int i = 0; i < sortedArray.Length; i++) // print the sorted array
            {
                Console.WriteLine(sortedArray[i]);
            }

        }
    }
}
