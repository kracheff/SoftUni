using System;
class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            for (int j = i+1; j <= i + n - 1; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
