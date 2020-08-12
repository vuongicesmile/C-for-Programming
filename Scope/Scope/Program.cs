using System;

class Scope
{
    private static int x=1;

    static void Main()
    {
        int x = 5;
        Console.WriteLine($"gia tri cua x la: {x}");
        UseLocalVarible();
        UseStaticVarible();
        Console.ReadLine();
    }
    static void UseLocalVarible()
    {
        int x = 25;
        Console.WriteLine($"local x on entering methods is {x}");
        ++x;
        Console.WriteLine($"local before {x}");
    }
    static void UseStaticVarible()
    {
        Console.WriteLine($"\n static varible on entering method la {x}");
        x *= 10;
        Console.WriteLine("static varible before exiting "+ $"method static is {x}");
    }
}