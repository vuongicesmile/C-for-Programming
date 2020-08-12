using System;

class RollDie
{
    static void Main()
    {
        Random randomNumbers = new Random();

        int frequecy1 = 0;
        int frequecy2 = 0;
        int frequecy3 = 0;
        int frequecy4 = 0;
        int frequecy5 = 0;
        int frequecy6 = 0;

        for (int roll = 1; roll <=60000000;++roll)
        {
            int face = randomNumbers.Next(1, 7);
            switch(face)
            {
                case 1:
                    ++frequecy1;
                    break;
                case 2:
                    ++frequecy2;
                    break;
                case 3:
                    ++frequecy3;
                    break;
                case 4:
                    ++frequecy4;
                    break;
                case 5:
                    ++frequecy5;
                    break;
                case 6:
                    ++frequecy6;
                    break;            
            }// end swtich
        }//e nd for

        Console.WriteLine("Face\tFrequency"); // output headers
        Console.WriteLine($"1\t{frequecy1}\n2\t{frequecy2}");
        Console.WriteLine($"3\t{frequecy3}\n4\t{frequecy4}");
        Console.WriteLine($"5\t{frequecy5}\n6\t{frequecy6}");
    }
    
}
