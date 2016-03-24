using System;
class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int integer = 0;
        double floatingPointNumber = 0d;
        string text = string.Empty;
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
                Console.Write("Please enter an integer: ");
                int intInput = int.Parse(Console.ReadLine());
                Console.WriteLine(intInput + 1);
                break;

            case 2:
                Console.Write("Please enter a double: ");
                double doubleInput = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleInput + 1d);
                break;

            case 3:
                Console.Write("Please enter a string: ");
                string stringInput = Console.ReadLine();
                Console.WriteLine(stringInput + "*");
                break;

            default:
                Console.WriteLine("Please enter an integer [1-3]");
                break;
        }
    }
}
