using System;

public class ComissionEmployee
{
    public string FristName { get; }
    public string LastName { get; }
    public string SocialSecurityNumber { get; }// so cmnd
    private decimal grossSales; //tong doanh thu theo tuan
    private decimal commissionRate;


    public ComissionEmployee(string fristName,string lastName,
        string socialSecurityNumber,decimal grossSales,decimal commisstionRate)
    {
        FristName = fristName;
        LastName = lastName;
        SocialSecurityNumber = socialSecurityNumber;
        GrossSales = grossSales;
        CommissionRate = commissionRate;
        
    }
    public decimal GrossSales
    {
        get
        {
            return grossSales;
        }
        set
        {
            if(value <0)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                value, $"{nameof(GrossSales)} must be >= 0");
            }
            grossSales = value;
        }
    }
    public decimal CommissionRate
    {
        get
        {
            return commissionRate;
        }

        set
        {
            if (value <0)
            {
                
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(CommissionRate)} must be > 0 and < 1");
                
            }
            commissionRate = value;
        }
    }

    public decimal Earning() => commissionRate * grossSales;// thu nhap

    public override string ToString() =>
        $"commission employee:(nhan vien khoang): {FristName} {LastName}\n" +
        $"social security number:(CMND): {SocialSecurityNumber}\n"+
        $"gross sales(tong doanh thu): {grossSales :C}\n" + $"commission rate(hoa hong): {commissionRate :F2}";
}