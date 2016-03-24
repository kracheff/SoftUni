using System;


    class MatrixOfNumbers
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col <= n + row - 1; col++)
            {
                Console.Write(" {0}",col);
            }
            Console.WriteLine();
        }
    }
}


