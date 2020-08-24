using System;

class Time2Test
{
    static void Main()
    {
        var t1 = new Time2();
        var t2 = new Time2(2);
        var t3 = new Time2(21,34);
        var t4 = new Time2(12,25,42);
        var t5 = new Time2(t4);

        Console.WriteLine("constructed with \n");
        Console.WriteLine($"    {t1.ToUniversalString()}");
        Console.WriteLine($"    {t1.ToString()}");

        Console.WriteLine("constructed with \n");
        Console.WriteLine($"    {t2.ToUniversalString()}");
        Console.WriteLine($"    {t2.ToString()}");

        Console.WriteLine("constructed with \n");
        Console.WriteLine($"    {t3.ToUniversalString()}");
        Console.WriteLine($"    {t3.ToString()}");

        Console.WriteLine("constructed with \n");
        Console.WriteLine($"    {t4.ToUniversalString()}");
        Console.WriteLine($"    {t4.ToString()}");

        Console.WriteLine("constructed with \n");
        Console.WriteLine($"    {t5.ToUniversalString()}");
        Console.WriteLine($"    {t5.ToString()}");

        try
        {
            var t6 = new Time2(27, 74, 99); // invalid values
        }
        
        catch(Exception loi1)
        {
            Console.WriteLine("\n exp when t6");
            Console.WriteLine(loi1.Message);
        }
       

    }
}