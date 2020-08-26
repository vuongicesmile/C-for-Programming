using System;

public class BasePlusCommissionEmployee:ComissionEmployee
{
    //public string FristName { get; }
    //public string LastName { get; }
    //public string SocialSecurityNumber { get; }// so cmnd

    public decimal BaseSalaray
    {
        get
        {
            return baseSalaray;
        }

        set
        {
            if (value < 0)
            {

                throw new ArgumentOutOfRangeException(nameof(value),
                value, $"{nameof(BaseSalaray)} must be > 0");

            }
            baseSalaray = value;
        }
    }

    protected decimal grossSales; //tong doanh thu theo tuan
    protected decimal commissionRate;
    private decimal baseSalaray;

    public BasePlusCommissionEmployee(string fristName,string lastName, string socialSecurityNumber, decimal grossSales,decimal commissionRate,decimal baseSalary ):base (fristName,lastName,socialSecurityNumber,grossSales,commissionRate)
    {
        //FristName = fristName;
        //LastName = lastName;
        //SocialSecurityNumber = socialSecurityNumber;
        //GrossSales = grossSales;
        //CommissionRate = commissionRate;
        BaseSalaray = baseSalary;
    }
    public decimal GrossSales
    {
        get
        {
            return grossSales;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                value, $"{nameof(GrossSales)} must be >= 0");
            }
            baseSalaray = value;
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
            if (value <= 0 || value >= 1)
            {

                throw new ArgumentOutOfRangeException(nameof(value),
                value, $"{nameof(CommissionRate)} must be > 0 and < 1");



            }
            commissionRate = value;
        }
    }

    public virtual decimal Earning() =>baseSalaray+ (commissionRate * grossSales);// thu nhap

    public override string ToString() =>
        $"commission employee:(nhan vien khoang): {FristName} {LastName}\n" +
        $"social security number:(CMND): {SocialSecurityNumber}\n" +
        $"gross sales(tong doanh thu): {grossSales:C}\n" + $"commission rate(hoa hong): {commissionRate:F2}\n"+
        $"base salary: {baseSalaray:C}";
}