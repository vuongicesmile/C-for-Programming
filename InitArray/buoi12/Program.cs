using System;

class InitArray
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("ban nhap doi so khong dung");
        }//end if
        else
        {
            var arraylength = int.Parse(args[0]);
            var array = new int[arraylength];

            var initialValue = int.Parse(args[1]);
            var increament = int.Parse(args[2]);

            for (var counter = 0; counter < array.Length; ++counter)
            {
                array[counter] = initialValue + increament * counter;
            }//end for

            Console.WriteLine($"{"index"} {"value,8"}");
            for (int counter = 0; counter < array.Length; ++counter)
            {
                Console.WriteLine($"{counter,5}{array[counter],8}");
            }
        }
        //Console.ReadLine();
    }
    
}