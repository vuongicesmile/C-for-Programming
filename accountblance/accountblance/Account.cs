using System;

class Account
{
    private string name;
    private decimal balance;

    public string Name { get; set; }
    

    public decimal Balance
    {
        get
        {
            return balance;
        }

        private set //can be used only within the class
        {
            if(value>0.0m)
            balance = value;
        }
    }

    public Account(string accountName)
    {
        Name = accountName;
    }
    //account constructor that receives 2 parameters
    public Account(string accountName,decimal initalBalance)
    {
        Name = accountName;
        Balance = initalBalance;
    }
    public void Deposit (decimal depositAmount)
    {
        if(depositAmount >0.0m)
        {
            Balance = Balance + depositAmount;
        }
    }
}