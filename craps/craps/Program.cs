using System;

class Craps
{
    private static Random randomNumbers = new Random();

    private enum Status {Continue,Won,Lost }

    private enum DiceNames
    {
        SnakeEyes =2,
        Trey = 3,
        Seven =7,
        YoLeven =11,
        BoxCars =12
    }

    static void Main()
    {
        Status GameStatus = Status.Continue;
        int myPoint = 0;

        int sumofDice = RollDice();

        switch ((DiceNames) sumofDice)
        {
            case DiceNames.Seven:
            case DiceNames.YoLeven:
                GameStatus = Status.Won;
                break;
            case DiceNames.SnakeEyes:
            case DiceNames.Trey:
            case DiceNames.BoxCars:
                GameStatus = Status.Lost;
                break;
            default: 
                GameStatus = Status.Continue; // game is not over
                myPoint = sumofDice;
                Console.WriteLine($"Point is {myPoint}");
                break;
        } 
        while(GameStatus == Status.Continue)
        {
            sumofDice =RollDice();  

            if (sumofDice ==myPoint)
            {
                GameStatus =Status.
            }
        }
           
    }
    
    {

    }
}