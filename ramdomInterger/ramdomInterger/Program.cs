using System;

class RamDomInterger
{
    static void Main()
    {
        Random randomNumber = new Random();

        for(int counter =1; counter <=20;++counter)
        {
            int face = randomNumber.Next(1,7);
            Console.WriteLine($"{face}");
        }
    }
}