using OnThiLTCSDL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThiLTCSDL.DAO
{
    public class ChiTietHoaDonDAO
    {
        public List<ChiTietHoaDonDTO> LayChiTietHoaDonTheoBan(int TableId)
        {
            string query = string.Format("select [Table].ID, Food.Name,Food.Unit,Food.Price, BillDetails.Quantity,(Food.Price*BillDetails.Quantity) AS Total " +
"From[Table] " +
"JOIN Bills ON[Table].ID = Bills.TableID " +
"JOIN BillDetails ON Bills.ID = BillDetails.InvoiceID " +
"JOIN Food ON Food.ID = BillDetails.FoodID " +
"WHERE[Table].ID = {0}", TableId).ToString();

            DataProvider provider = new DataProvider();
           DataTable table= provider.ExecuteQuery(query);

            List<ChiTietHoaDonDTO> dsChiTiet = new List<ChiTietHoaDonDTO>();
            foreach(DataRow row in table.Rows)
            {
                int id = Convert.ToInt32(row["Id"]);
                string name = row["Name"].ToString();
                string unit = row["Unit"].ToString();
                decimal price = Convert.ToDecimal(row["price"]);
                int quantity = Convert.ToInt32(row["Quantity"]);
                decimal total = Convert.ToDecimal(row["Total"]);

                ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO(id,name,unit,price,quantity,total);
                dsChiTiet.Add(cthd);


            }
            return dsChiTiet;

        }


    }
}
