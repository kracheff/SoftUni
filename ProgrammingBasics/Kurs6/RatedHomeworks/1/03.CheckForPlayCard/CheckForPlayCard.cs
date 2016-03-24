using System;

class CheckForPlayCard
{
    static void Main()
    {
        Console.Write("character: ");
        string cardFace = Console.ReadLine();
        Console.WriteLine("Is it a valid card sign? ");
        switch (cardFace)
        {
            case "2": 
            case "3": 
            case "4": 
            case "5": 
            case "6": 
            case "7": 
            case "8": 
            case "9":
            case "10":
            case "J":
            case "Q": 
            case "K": 
            case "A": 
                Console.WriteLine("yes");
                break;
            default:
                Console.WriteLine("no");
                break;
        }
    }
}

