using OnThiLTCSDL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThiLTCSDL.DAO
{
    public class BanAnDAO
    {
        public List<BanAnDTO> LayDSBanAn()
        {
           
            string query = "Select *From [Table]";
            DataProvider provider = new DataProvider();
            DataTable table = provider.ExecuteQuery(query);

            List<BanAnDTO> dsBanAn = new List<BanAnDTO>();
            //kiem tra tung du lieu trong 1 dong cua table
            foreach (DataRow row in table.Rows)
            {
                int Id =Convert.ToInt32(row["Id"]);
                String Name = row["Name"].ToString();
                int Status = Convert.ToInt32(row["Status"]);
                int Capacity = Convert.ToInt32(row["Capacity"]);

                var BanAnMoi = new BanAnDTO(Id, Name, Status, Capacity);
                dsBanAn.Add(BanAnMoi);

            }
            return dsBanAn;

        }

        public bool TaoBanAn(string name,int status,int capacity)
        {
           
            string query =String.Format("Insert into [Table] (Name,Status,Capacity)"
                + "Values(N'{0}',{1},{2})", name, status,capacity).ToString();
            DataProvider provider = new DataProvider();
            int soDongBiTacDong = provider.ExecuteNonQuery(query);

            if (soDongBiTacDong > 0)
                return true;
            return false;
        }

        public bool CapNhatBanAn(int id,string tenBanAn,int status,int capacity)
        {
            string query = String.Format("Update [Table]"
                +"SET "
                +" Name=N'{0}',"
                +"Status ={1},"
                +"Capacity ={2}"
                + "Where ID = {3}",tenBanAn,status,capacity,id).ToString();

            DataProvider provider = new DataProvider();
            int sodongbitacdong =provider.ExecuteNonQuery(query);
            if (sodongbitacdong > 0)
                return true;
            return false;

        }

    }
}
