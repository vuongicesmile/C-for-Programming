using System;
using System.Linq;

class Time1Test
{
    static void Main()
    {
        var time = new Time1();

        Console.WriteLine($"The initial universal (24h) time is:{time.ToUniversalString()}" );
        Console.WriteLine($"The initial standard (12h) time is {time.ToString()}");

        //changed time and update
        time.SetTime(13,27,6);
        Console.WriteLine($"univeral  time after Settime is :{time.ToUniversalString()}  ");
        Console.WriteLine($"Standard time after Settime is : {time.ToString()}");

        try
        {
            time.SetTime(99, 99, 99);
        }
        catch(ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message + "\n");
        }
        Console.ReadLine();




    }
}