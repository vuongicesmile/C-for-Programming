using System;

class InitArray
{
    static void Main()
    {
        //int[] Array = new int[5];
        //const int ArrayLength = 5;
        //int[] Array = new int[ArrayLength];
        int[] Array
            = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
        int total = 0;

        //Console.WriteLine($"{"index"} {"value",8}");
        //for (int counter = 0; counter < Array.Length; ++counter)
        //{
        //    Array[counter] = 3 + counter * 3;

        //}
        //Console.WriteLine($"{"index",5} {"Value",8}");

        //for (int counter = 0; counter < Array.Length; ++counter)
        //{
        //    total += Array[counter];
        //    //Console.WriteLine($"{counter,5}{Array[counter],8}");
        //}
        foreach(int number in Array)
        {
            total += number;
        }
        Console.WriteLine($"Total of array elements: {total}");

    }
}
