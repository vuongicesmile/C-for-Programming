using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_quan_ca_phe.DTO
{
    public class DataProvider
    {
        private static DataProvider instance = new DataProvider();
        private string connectionSTR = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CafeRestaurant;Integrated Security=True";

        public static DataProvider Instance
        {
            get ; set; }


        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectionSTR))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listpara = query.Split(' ');
                    foreach (var item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connect.Close();
            }
            return data;
        }


        public int ExcuteNonQuery(string query,object[] paramater)
        {
            int data = 0;
            using (SqlConnection connect = new SqlConnection(connectionSTR))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (paramater != null)
                {
                    int i = 0;
                    string[] listpara = query.Split(' ');
                    foreach (var item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connect.Close();
            }
            return data;
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
               
            }
            return data;
        }
    }
}
