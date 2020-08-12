using System;

class StudentTest
{
    static void Main()
    {
        Student student1 = new Student("Jane Green",93);
        Student student2 = new Student("Jhon Blue",72);
        Console.WriteLine($"{student1.Name}'s letter grade equiment of");
        Console.WriteLine($"{student1.Average} is {student1.LetterGrade}");
        Console.Write($"{student2.Name}'s letter grade equivalent of ");
        Console.WriteLine($"{student2.Average} is {student2.LetterGrade}");
        Console.ReadLine();

    }
}