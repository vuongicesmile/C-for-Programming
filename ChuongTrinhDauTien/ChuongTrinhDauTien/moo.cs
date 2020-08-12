using System;

class Adition
{
    static void Main()
    {
        bool kiemtra;
        int number1;
        int number2;
        int sum;
        Console.Write("Enter frist integer :");
        kiemtra =int.TryParse(Console.ReadLine(),out number1);
        Console.Write("Enter second integer :");
        kiemtra = int.TryParse(Console.ReadLine(),out number2);
        sum = number1 + number2;
        Console.WriteLine($"sum is {sum}");
        Console.ReadLine();
    }
}