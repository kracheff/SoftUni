using System;
class CheckForPlayCard
{
    static void Main()
    {
        string input = Console.ReadLine();
        int inputNumber;
        bool isInputNumber = int.TryParse(input, out inputNumber);

        if (isInputNumber &&
            (inputNumber >= 2 && inputNumber <= 10))
        {
                Console.WriteLine("yes");
        }
        else
        {
            if (input == "J" || 
                input == "Q" || 
                input == "K" || 
                input == "A")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
