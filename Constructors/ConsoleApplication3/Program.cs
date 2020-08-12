using System;


class AccountTest
{
    static void Main(string[] args)
     {
        Account KhachHang1 = new Account("Huy",1000);
        Console.WriteLine($"ten khach hang la : {KhachHang1.ten}");




        // ham khoi tao constructor
        //Console.WriteLine($"ten khoi tao cua tai khoan la {myAccount.GetName()}");//
        //Console.Write("Nhap ten cho tai khoan : ");
        //string theName = Console.ReadLine();
        //myAccount.SetName(theName);
        //Console.WriteLine($"ten cua tai khoan myAccount la :{myAccount.GetName()}");
        //string ten = myAccount.GetName();
        //Console.WriteLine("Ten la" + ten);
        //Console.ReadKey();

     }
}

