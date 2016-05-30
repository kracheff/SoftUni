using System;
using System.Collections.Generic;
public class HandsOfCards
{
  public static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, long> hand = new Dictionary<string, long>();

        while (input != "JOKER")
        {
            string[] elementsOfInput = input.Split(new char[] { ':'}, StringSplitOptions.RemoveEmptyEntries);
            string name = elementsOfInput[0];
            string currentHand = elementsOfInput[1].Trim();

            string[] cards = currentHand.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < cards.Length; i++)
            {
                string currentCard = cards[i].Trim();
                byte cardFace = byte.Parse(currentCard.Substring(0, currentCard.Length - 1));
                string cardSuit = currentCard[currentCard.Length-1].ToString();
            }


            input = Console.ReadLine();
        }
    }
    public static byte CardSuitToNumber (string cardSuit)
    {
        byte output = 0;

        switch (cardSuit)
        {
            case "S": output = 4; break;
            case "H": output = 3; break;
            case "D": output = 2; break;
            case "C": output = 2; break;

            default:
                break;
        }

        return output;
    }
}
