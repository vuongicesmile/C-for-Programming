using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_quan_ca_phe.DTO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        private AccountDAO() { }

        public bool Login(string userName,string password)
        {
            return false;
        }
    }
}
