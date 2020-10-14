using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_ly_quan_ca_phe.DTO
{
    public class DataProvider
    {
        private string connectionSTR = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";


        public DataTable ExcuteQuery(string query, object[] paramater)
        {
            
            DataTable data = new DataTable();
            //su dung using : khi ket thuc khai bao du lieu se duoc giai phong
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {


                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);// excute cau query tren ket noi

                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
                return data;
            }
        }
        public int ExcuteNonQuery(string query,object[] paramater)
        {
            int data = 0;
            // data = new DataTable();
            // su dung using : khi ket thuc khai bao du lieu se duoc giai phong
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {


                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);// excute cau query tren ket noi

                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                
                //SqlDataAdapter adapter = new SqlDataAdapter(command);
                //adapter.Fill(data);

                connection.Close();
                return data;
            }
        }
        public object ExcuteScalar(string query, object[] paramater)
        {
            object data = 0;
            // data = new DataTable();
            // su dung using : khi ket thuc khai bao du lieu se duoc giai phong
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {


                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);// excute cau query tren ket noi

                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();

                //SqlDataAdapter adapter = new SqlDataAdapter(command);
                //adapter.Fill(data);

                connection.Close();
                return data;
            }
        }
    }
}
