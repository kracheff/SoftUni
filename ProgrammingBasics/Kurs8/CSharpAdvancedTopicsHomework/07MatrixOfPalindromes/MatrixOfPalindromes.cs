using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
          
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = "" + 
                        (char)('a' + i) + 
                        (char) ('a' + j + i) + 
                        (char)('a' + i) + 
                        " ";
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
