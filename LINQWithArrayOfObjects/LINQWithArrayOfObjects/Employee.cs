using System;
using System.Linq;

class Employee
{
    public string FristName { get; }//property
    public string LastName { get; }
    private decimal monthySalary; // luong tra hang thang

    public Employee(string fristNmae,string lastName,decimal monthySalary)
    {
        FristName = fristNmae;
        LastName = lastName;
        MonthySalary = monthySalary;
    }
    public decimal MonthySalary
    {
        get
        {
            return monthySalary;
        }

        set
        {
            if (value >= 0M)
            {
                monthySalary = value;
            }//END IF
        }
    }
    public override string ToString() =>
        $"{FristName,-10} {LastName,-10} {MonthySalary,10:C}";


}