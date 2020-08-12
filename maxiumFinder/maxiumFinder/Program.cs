using System;

class MaximumFinder
{
    static void Main()
    {
        Console.WriteLine("nhap so 1:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("nhap so 2:");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("nhap so 3:");
        double num3 = double.Parse(Console.ReadLine());

        double result = Math.Max(Math.Max(num1, num2),num3);
        Console.WriteLine("so lon nhat la "+result);
    }
    static double Maximum(double x,double y,double z)
    {
        double max = x;
        if (y > max)
        {
          max=y;
        }
        if (z >max)
        {
            max=z;
        }
        return max;
    }
}