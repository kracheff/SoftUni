using System;
class DeckOf52Cards
{
    static void Main()
    {
        string cardFace;
        char cardSuits;

        for (int i = 2; i < 15; i++)
        {
            switch (i)
            {
                case 11: cardFace = "J"; break;
                case 12: cardFace = "Q"; break;
                case 13: cardFace = "K"; break;
                case 14: cardFace = "A"; break;
                default: cardFace = i.ToString(); break;
            }
            cardSuits = '\u2663';
            Console.Write(cardFace + cardSuits);
            cardSuits = '\u2666';
            Console.Write(cardFace + cardSuits);
            cardSuits = '\u2665';
            Console.Write(cardFace + cardSuits);
            cardSuits = '\u2660';
            Console.Write(cardFace + cardSuits);

            Console.WriteLine();
        }


    }
}
