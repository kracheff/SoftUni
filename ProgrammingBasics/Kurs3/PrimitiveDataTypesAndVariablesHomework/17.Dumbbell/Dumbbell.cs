using System;
class Dumbbell
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        // First Row
        string a = new string('.', (N - 1) / 2);
        string b = new string('&', (N + 1) / 2);
        string c = new string('.', N);
        Console.WriteLine(a + b + c + b + a);

        // Mid Upper Rows
        int j = (N - 1) / 2;
        for (int i = (N - 3) / 2; i >= 1; i--) // Dots
            {
                string x = new string('.', i); // Dots
                string y = new string('*', j); // Asterisks
                string z = new string('.', N); // Dots
                Console.WriteLine(x + '&' + y + '&' + z + '&' + y + '&' + x);
                j = j + 1;
            }

        // Middle Row
        Console.WriteLine('&' + new string('*', (N - 2)) + '&' + new string('=', N) + '&' + new string('*', (N - 2)) + '&');

        // Mid Lower Rows
        int n = (N - 3);
        for (int m = 1; m <= (N - 3) / 2; m++) // Dots
        {
            string d = new string('.', m); // Dots
            string e = new string('*', n); // Asterisks
            string f = new string('.', N); // Dots
            Console.WriteLine(d + '&' + e + '&' + f + '&' + e + '&' + d);
            n = n - 1;
        }
        // Last Row
        Console.WriteLine(a + b + c + b + a);
    }
}