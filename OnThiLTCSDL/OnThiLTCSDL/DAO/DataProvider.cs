using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThiLTCSDL.DAO
{
    public class DataProvider
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RestaurantManagement;Integrated Security=True";
        //tra ve 1 bang
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = query;

            connection.Open();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);


            connection.Close();
            connection.Dispose();
            return table;
        }
        //tra ve so dong bi tac dong insert,updates,delete
        public int ExecuteNonQuery(string query)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = query;

            connection.Open();
            //thuc thi cau lenh tra ve so dong bi tac dong
            int soDongBiTacDong = command.ExecuteNonQuery();
            connection.Close();
            connection.Dispose();
            return soDongBiTacDong;

            


        }
        //tinh tong so ban ban tra ve 1 so
        public object Scalar(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = query;

            connection.Open();
            //thuc thi cau lenh tra ve so dong bi tac dong
            object soDongBiTacDong = command.ExecuteScalar();
            return soDongBiTacDong;
        }
    }
}
