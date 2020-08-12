using System;

class Sum
{
    static void Main()
    {

        //int total = 0;
        //for (int i = 0; i <= 30; i += 2)
        //{
        //    total += i;
        //}
        //Console.WriteLine($"{total}");
        decimal p = 1000;
        double r = 0.5;
        Console.WriteLine("year amount on deposit");
        for(int year =1;year<=10;year++)
        {
            //a = p(1 + r)^n
            decimal a = p * ((decimal)(Math.Pow(1.0 + r,year)));
            Console.WriteLine($"{year,4}{a,20}");
        }
    }
       
}
