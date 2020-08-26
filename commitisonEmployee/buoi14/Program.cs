using System;

class CommissionEmployeeTest
{
    static void Main()
    {
        var employee = new ComissionEmployee("Sue", "Jones", "222-22-2222", 1000.00M, .04M);
        //var employee = new BasePlusCommissionEmployee("le", "nam", "333-33-3333", 5000.00M, .04M, 300.00M);

        Console.WriteLine("employee info obtained by properties and methods \n");
        Console.WriteLine($"frist name is {employee.FristName}");
        Console.WriteLine($"Last name is {employee.LastName}");
        Console.WriteLine($"Social security number is {employee.SocialSecurityNumber}");
        Console.WriteLine($"Gross sale are  {employee.GrossSales:C}");
        Console.WriteLine($"commission rate is {employee.CommissionRate:F2}");
        Console.WriteLine($"earnings are {employee.Earning():C}");

        employee.GrossSales = 5000.00M;
        employee.CommissionRate = .1M;

        Console.WriteLine("\n updateed employee infomation obtained by to string \n");
        Console.WriteLine(employee);
        Console.WriteLine($"earnings: {employee.Earning():C}");
    }
}