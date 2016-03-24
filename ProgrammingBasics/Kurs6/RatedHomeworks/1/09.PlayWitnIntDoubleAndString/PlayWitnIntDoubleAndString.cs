using System;

class PlayWitnIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: \n1 --> int \n2 --> double \n3 --> string ");
        int type = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                Console.WriteLine("Please enter an int: ");
                Console.WriteLine(int.Parse(Console.ReadLine()) + 1);break;
            case 2:
                Console.WriteLine("Please enter a double: ");
                Console.WriteLine(double.Parse(Console.ReadLine()) + 1); break;
            case 3:
                Console.WriteLine("Please enter a string: ");
                Console.WriteLine("{0}*", Console.ReadLine()); break;
        }
    }
}

