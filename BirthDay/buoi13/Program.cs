using System;

class EmployeeTest
{
    static void Main()
    {
        //var birthday = new Date(7, 24, 1949);
        //var hireDate = new Date(3, 12, 1988);
        //var employee = new Employee("Bob", "Blue", birthday, hireDate);
        //Console.WriteLine(employee);
        Console.WriteLine($" Employees bf instantion    {Employee.Count}");

        var e1 = new Employee("Susan", "Baker");
        var e2 = new Employee("Bob", "Blue");

        Console.WriteLine($"\n Employees after instantiantion {Employee.Count}");

        Console.WriteLine($"\nemployee 1 : {e1.FristName} {e2.LastName}");

        Console.WriteLine($"\nemployee 2 : {e2.FristName} {e2.LastName}");

        e1 = null;
        e2 = null;
    }
}