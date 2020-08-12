using System;

class Account
{
    private string name; //instance varible
    private decimal balance;

    public decimal Balance
    {
        get
        {
            return balance;
        }

        set
        {
            if (value > 0)
            { balance = value; }
        }
    }
    public void Deposit(decimal depositAmount)
    {
        if(depositAmount>0)
        {
            Balance = balance + depositAmount;
        }
    }

    public void SetName(string account) // ten bien co 1 tu thi viet thuong het, neu 2 chu cai thi viet hoa
    {
        name = account;
    }
    //oop : object oriented programing
    //private, public,protected : modifier (tu khoa xac dinh pham vi truy cap)
    public string GetName() //API -application programing interface
    {
        return name;
    }
    public Account(string ten, decimal soTien)
    {
        name = ten;
        balance = soTien;
    }
    public Account() { }
}

