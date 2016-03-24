using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NakovsMatching
{
    static void Main()
    {
        string A = Console.ReadLine();
        string B = Console.ReadLine();
        int d = int.Parse(Console.ReadLine());

        string subString0 = string.Empty;
        string subString1 = string.Empty;
        string subString2 = string.Empty;
        string subString3 = string.Empty;

        int sumChars0 = 0;
        int sumChars1 = 0;
        int sumChars2 = 0;
        int sumChars3 = 0;
        int matchCouter = 0;

        for (int i = 0; i < A.Length - 1; i++)
        {
            subString0 = A.Substring(0, i + 1);
            foreach (char subStringElement in subString0)
            {
                sumChars0 += subStringElement;
            }

            subString1 = A.Substring(i + 1, A.Length - i - 1);
            foreach (char subStringElement in subString1)
            {
                sumChars1 += subStringElement;
            }
            for (int j = 0; j < B.Length - 1; j++)
            {
                subString2 = B.Substring(0, j + 1);
                foreach (char subStringElement in subString2)
                {
                    sumChars2 += subStringElement;
                }

                subString3 = B.Substring(j + 1, B.Length - j - 1);
                foreach (char subStringElement in subString3)
                {
                    sumChars3 += subStringElement;
                }

                long nakovs = Math.Abs(sumChars0 * sumChars3 - sumChars1 * sumChars2);

                if (nakovs <= d)
                {
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs",
                        subString0,
                        subString1,
                        subString2,
                        subString3,
                        nakovs
                        );
                    matchCouter++;
                }
                sumChars2 = 0;
                sumChars3 = 0;
            }
            sumChars0 = 0;
            sumChars1 = 0;
        }
        if (matchCouter == 0)
        {
            Console.WriteLine("No");
        }
    }
}
