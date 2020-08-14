using System;

class DeskOfCard
{
    private static Random RandomNumbers = new Random();

    private const int NumberOfCards = 52;// so con bai
    private Card[] deck = new Card[NumberOfCards]; // mang chua cac con bai
    private int currentCard = 0;

    public DeskOfCard()
    {
        string[] faces = {"Ace", "Deuce", "Three", "Four", "Five", "Six",
 "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

        //tạo bộ bài
        for(var count = 0; count < deck.Length; count++)
        {
            deck[count] = new Card(faces[count % 13], suits[count / 13]);
        }
       

    }
    // xao' bai
    public void Suffle()
    {
        currentCard = 0;
        for (var frist = 0; frist < deck.Length;frist++)
        {
            var second = RandomNumbers.Next(NumberOfCards);
            Card temp = deck[frist];
            deck[frist] = deck[second];
            deck[second] = temp;

        }
    }

    // chia bai
    public Card DealCard()
    {
            if (currentCard <deck.Length)
        {
            return deck[currentCard++];
        }
            else
        {
            return null;
        }
    }
}