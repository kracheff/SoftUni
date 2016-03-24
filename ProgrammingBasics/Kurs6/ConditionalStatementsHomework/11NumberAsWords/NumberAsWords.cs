using System;
class NumberAsWords
{
    static void Main()
    {
        Console.WriteLine("Enter a number [0-999]");
        int number = int.Parse(Console.ReadLine());

        int onesNumbers = number % 10;
        int tensNumbers = ((number / 10) % 10);
        int hundredsNumbers = ((number / 100) % 10);
        int specificNumbers = tensNumbers * 10 + onesNumbers;

        if (number == 0)
        {
            Console.Write("zero");
        }

        string onesText = string.Empty;

        switch (onesNumbers)
        {
            case 1: onesText = "one"; break;
            case 2: onesText = "two"; break;
            case 3: onesText = "three"; break;
            case 4: onesText = "four"; break;
            case 5: onesText = "five"; break;
            case 6: onesText = "six"; break;
            case 7: onesText = "seven"; break;
            case 8: onesText = "eight"; break;
            case 9: onesText = "nine"; break;
            default: break;
        }

        string specificText = string.Empty;

        switch (specificNumbers)
        {
            case 10: specificText = "ten"; break;
            case 11: specificText = "eleven"; break;
            case 12: specificText = "twelve"; break; 
            case 13: specificText = "thirteen"; break;
            case 15: specificText = "fifteen"; break;
        }

        string tensText = string.Empty;

        switch (tensNumbers)
        {
            case 2: tensText = "twenty "; break;
            case 3: tensText = "thirty "; break;
            case 4: tensText = "fourty "; break;
            case 5: tensText = "fifty "; break;
            case 6: tensText = "sixty "; break;
            case 7: tensText = "seventy "; break;
            case 8: tensText = "eighty "; break;
            case 9: tensText = "ninety "; break;
            case 0: break;
        }

        string hundredsText = string.Empty;

        switch (hundredsNumbers)
        {
            case 1: hundredsText = "one"; break;
            case 2: hundredsText = "two"; break;
            case 3: hundredsText = "three"; break;
            case 4: hundredsText = "four"; break;
            case 5: hundredsText = "five"; break;
            case 6: hundredsText = "six"; break;
            case 7: hundredsText = "seven"; break;
            case 8: hundredsText = "eight"; break;
            case 9: hundredsText = "nine"; break;
            default: break;
        }

        string teens = "teen";
        string hundreds = " hundred";

        if (hundredsNumbers == 0)
        {
            if (tensNumbers == 0)
            {
                Console.WriteLine(onesText);
            }
            else if (tensNumbers == 1)
            {
                if ((number >= 10 && number <= 13) || number == 15)
                {
                    Console.WriteLine(specificText);
                }
                else
                {
                    Console.WriteLine(onesText + teens);
                }
            }
            else
            {
                Console.WriteLine(tensText + onesText);
            }
        }
        else
        {
            if (tensNumbers == 0 && onesNumbers == 0)
            {
                Console.WriteLine(hundredsText + hundreds);
            }
            else
            {
                if (tensNumbers == 0)
                {
                    Console.WriteLine(hundredsText + hundreds + " and " + onesText);
                }
                else
                {
                    if (tensNumbers == 1)
                    {
                        if (((specificNumbers >= 10) &&
                            (specificNumbers <= 13)) || 
                            (specificNumbers == 15))
                        {
                            Console.WriteLine(hundredsText + hundreds + " and " + specificText);
                        }
                        else
                        {
                            Console.WriteLine(hundredsText + hundreds + " and " + onesText + teens);
                        }
                    }
                    else
                    {
                        Console.WriteLine(hundredsText + hundreds + " and " + tensText + onesText);
                    }
                }
            }
        }
    }
}
