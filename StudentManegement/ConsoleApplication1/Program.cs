using System;

class ClassAverage
{
    static void Main()
    {
        int total = 0;
        int gradeCounter = 0;
        Console.WriteLine("enter grade to quit");
        int grade = int.Parse(Console.ReadLine());
        while (grade != -1)
        {
            total = total + grade;
            gradeCounter = gradeCounter + 1;
        }
        if(grade !=0)
        {
            double average = (double)total / gradeCounter;
            Console.WriteLine($"");
        }
        
                    
    }
}