using System;


    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account("thi no");
            Console.WriteLine($"ten khoi tao cua tai khoan la : {myAccount.Name}");
            Console.Write("nhap ten tai khoan:");
            string theName = Console.ReadLine();
            myAccount.Name = theName;
            //string ten = myAccount.Name;
            Console.WriteLine($"ten la :{myAccount.Name}");
        
        }
    }

