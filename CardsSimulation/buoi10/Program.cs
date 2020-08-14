using System;

class DeskOfCardsTest
{
    static void Main()
    {
        var myDeckofCards = new DeskOfCard();
        myDeckofCards.Suffle();

        for (var i =0; i <52; i++)
        {
            Console.Write($"{myDeckofCards.DealCard(),-19}");

            if ((i + 1)% 4 == 0)
            {
                Console.WriteLine();
            }
        }

    }
}