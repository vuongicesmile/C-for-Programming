using System;
using System.Linq;

class LINQWithArrayOfObjects
{
    static void Main()
    {
        var employees = new[] {
            new Employee("Jason","Red",500M),
            new Employee("Ashley","Green",760M),
            new Employee("Matthew", "Indigo", 3587.5M),
            new Employee("James", "Indigo", 4700.77M),
            new Employee("Jason", "Blue", 3200M),
            new Employee("Luke", "Indigo", 6200M),
            new Employee("Wendy", "Brown", 4236.4M) };

        //display all employees
        Console.WriteLine("original employees array:");
        foreach(var element in employees)
        {
            Console.WriteLine($"{element}");
        }//end foreach

        var between4K6K = from e in employees
                          where (e.MonthySalary >= 4000M) && (e.MonthySalary <= 6000M)
                          select e;
        Console.WriteLine("Danh sach nhan vien co luong tu 4000M - 6000 M la :");
        foreach (var element in between4K6K)
        {
            Console.WriteLine($"{element}   ");
        }//end foreach

        var nameSorted =
            from e in employees
            where (e.MonthySalary >= 4000M) && (e.MonthySalary <= 6000M)
            select e;

        Console.WriteLine("Danh sach nhan vien da sap xep la :");
        foreach (var element in nameSorted)
        {
            Console.WriteLine($"{element}   ");
        }//end foreach
        Console.WriteLine("frist employee when sorted by name :");
        if(nameSorted.Any())
        {
            Console.WriteLine(nameSorted.First());
        }
        else
        {
            Console.WriteLine("not found");
        }


    }
}


