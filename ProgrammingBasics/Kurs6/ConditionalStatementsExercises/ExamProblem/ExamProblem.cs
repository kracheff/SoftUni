using System;
using System.Linq
class ExamProblem
{
    static void Main()
    {
        // input

        int numericSystem = 2; // int.Parse(Console.ReadLine());
        string message = "a%B"; // Console.ReadLine();
        message = message.ToLower();
        // Encrypt

        int sum = 0;
        for (int i = 0; i < message.Length; i++)
        {
            char symbol = message[i];

            if (symbol >= 'a' && symbol <= 'z')
            {
                int position = symbol - 'a' + 1; // 97 - 97 + 1
                sum += position;
            }
            else
            {
                sum += symbol;
            }
        }
        string result = "" + numericSystem + message.Length;
        string baseResult = "";

        while (sum > 0)
        {
            int modul = sum % numericSystem;
            sum = sum / numericSystem;
            baseResult += modul;
        }

        string reveredBase = string.Join
            ("", baseResult.Reverse());

        // output
    }
}
