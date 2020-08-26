using System;

public class Employee
{
    public string FristName { get; }
    public string LastName { get; }
    public Date BirthDate { get; }
    public Date HireDate { get; }
    public static int Count { get; private set; } // objects in memory

    //constructor to initiallize name,birthd date and hire date
    public Employee(string fristName, string lastName)
    {
        FristName = fristName;
        LastName = lastName;
        ++Count;
        Console.WriteLine("Employee constructor: " + $"{FristName}  {LastName}; Count = {Count}");
    }

    //    BirthDate = birthDate;
    //    HireDate = hireDate;
    //}
    //public override string ToString() => $"{LastName}, {FristName} "
    //    + $"Hired: {HireDate} Birthday: {BirthDate}";
}