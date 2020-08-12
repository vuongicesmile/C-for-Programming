using System;

class Analyis
{
    static void Main()
    {
        int passes = 0;
        int failures = 0;
        int studentCounter = 1;

        while (studentCounter <= 10)
        {
            Console.Write("Enter result (1=pass, 2 = Fail): ");
            int result = int.Parse(Console.ReadLine());
            if (result == 1)
            {
                passes += 1;
            }
            else
            {
                failures+=1;
        
            }
            studentCounter +=1;
            //end while
            Console.WriteLine($"passed : {passes} \nFail {failures}");
            if (passes > 8)
            {
                Console.WriteLine("qua cho giao vien");
            }
        }
    }
}