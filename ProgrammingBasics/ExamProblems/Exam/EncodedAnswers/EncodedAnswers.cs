using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncodedAnswers
{
    static void Main()
    {
        int numberOfQuestions = int.Parse(Console.ReadLine());

        string output = string.Empty;

        ulong aAnswers = 0;
        ulong bAnswers = 0;
        ulong cAnswers = 0;
        ulong dAnswers = 0;

        for (int i = 0; i < numberOfQuestions; i++)
        {
            uint number = uint.Parse(Console.ReadLine());

            if (number % 4 == 0)
            {
                output += "a ";
                aAnswers += 1;
            }
            else if (number % 4 == 1)
            {
                output += "b ";
                bAnswers += 1;
            }
            else if (number % 4 == 2)
            {
                output += "c ";
                cAnswers += 1;
            }
            else if (number % 4 == 3)
            {
                output += "d ";
                dAnswers += 1;
            }
        }
        Console.WriteLine(output);
        Console.WriteLine("Answer A: {0}", aAnswers);
        Console.WriteLine("Answer B: {0}", bAnswers);
        Console.WriteLine("Answer C: {0}", cAnswers);
        Console.WriteLine("Answer D: {0}", dAnswers);
    }
}
