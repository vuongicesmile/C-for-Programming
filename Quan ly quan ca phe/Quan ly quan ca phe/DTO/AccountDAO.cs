
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quan_ly_quan_ca_phe.DTO
{
    public class AccountDAO
    {
        private static AccountDAO instance = new AccountDAO();

        public static AccountDAO Instance { get; set; }
        public AccountDAO() { }
        public bool Login(string username, string password)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("Select *from dbo.TaiKhoan where TenDangNhap ='"+username+"' And MatKhau ='"+password+"';");
            return data.Rows.Count > 0;
        }
    }
}