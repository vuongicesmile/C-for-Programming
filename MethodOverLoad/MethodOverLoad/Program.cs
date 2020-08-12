using System;

class MethodOverLoad
{
    static void Main()
    {
        Console.WriteLine($"square of interger is {Square(7)}");
        Console.WriteLine($"square of double is {Square(7.5)}");
    }

    static int Square(int intValue)
    {
        Console.WriteLine($"call square with int argument{intValue}");
        return intValue * intValue;
    }
    static double Square(double intValue)
    {
        Console.WriteLine($"call square with double argument{intValue}");
        return intValue * intValue;
    }

}