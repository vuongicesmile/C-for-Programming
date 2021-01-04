using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // tao ket noi toi co so du lieu
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RestaurantManagement;Integrated Security=True";
            //tao doi tuong ket noi
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //thiet lap doi tuong truy van
            string query = "select ID,name,type from Category";
            //tao doi tuong thuc thi lenh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = query;

            
            //mo ket noi toi co so du liej
            sqlConnection.Open();
            //thuc thi lenh bang pthuc ExcuteReader
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //goi ham hien thi du lieu len man hinh
            DisplayCategory(sqlDataReader);
            //dong ket noi
            sqlConnection.Close();
        }
        private void DisplayCategory(SqlDataReader reader)
        {
            listView1.Items.Clear();

            while(reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
                listView1.Items.Add(item);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // tao ket noi toi co so du lieu
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RestaurantManagement;Integrated Security=True";
            //tao doi tuong ket noi
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //thiet lap doi tuong truy van
            //string query = "select ID,name,type from Category";
            //tao doi tuong thuc thi lenh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "insert into category(name,[type])" +
                "values(N'" + textBox2.Text + "'," + textBox3.Text +")";


            //mo ket noi toi co so du liej
            sqlConnection.Open();
            //thuc thi lenh bang pthuc ExcuteReader
            int NumofRowEffected = sqlCommand.ExecuteNonQuery();



            
            //dong ket noi
            sqlConnection.Close();

            if(NumofRowEffected ==1)
            {
                MessageBox.Show("Them mon an thanh cong");
                //tai lai du lieu
                button1.PerformClick();
                //xoa cac o nhap
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("da co loi xay ra");
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];

            //hien thi du lieu len textbox
            textBox1.Text = item.Text;
            textBox2.Text = item.SubItems[1].Text;
            textBox3.Text = item.SubItems[2].Text == "0" ? "Thuc uong" : "do an";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // tao ket noi toi co so du lieu
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RestaurantManagement;Integrated Security=True";
            //tao doi tuong ket noi
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //thiet lap doi tuong truy van
            //string query = "select ID,name,type from Category";
            //tao doi tuong thuc thi lenh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Update category set name =N'" + textBox2.Text +
                "',[type]= " + textBox3.Text + "Where ID=" +textBox1.Text;


            //mo ket noi toi co so du liej
            sqlConnection.Open();
            //thuc thi lenh bang pthuc ExcuteReader
            int NumofRowEffected = sqlCommand.ExecuteNonQuery();




            //dong ket noi
            sqlConnection.Close();

            if (NumofRowEffected == 1)
            {
                ListViewItem item = listView1.SelectedItems[0];
                item.SubItems[1].Text = textBox2.Text;
                item.SubItems[2].Text = textBox3.Text;
                //xoa o da nhap
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                MessageBox.Show("Cap nhat mon an thanh cong");
            }
            else
            {
                MessageBox.Show("da co loi xay ra");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // tao ket noi toi co so du lieu
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RestaurantManagement;Integrated Security=True";
            //tao doi tuong ket noi
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //thiet lap doi tuong truy van
            //string query = "select ID,name,type from Category";
            //tao doi tuong thuc thi lenh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $"DELETE FROM Category WHERE ID = {textBox1.Text}";


            //mo ket noi toi co so du liej
            sqlConnection.Open();
            //thuc thi lenh bang pthuc ExcuteReader
            //int NumofRowEffecte = sqlCommand.ExecuteNonQuery();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            //dong ket noi
            sqlConnection.Close();



            if (numOfRowsEffected == 1)
            {
                ListViewItem item = listView1.SelectedItems[0];
                listView1.Items.Remove(item);


                //xoa o da nhap
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                MessageBox.Show("Xoa mon an thanh cong");

               
            }
            else
            {
                MessageBox.Show("da co loi xay ra");
            }
            
        }
        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                FoodForm1 frmFood = new FoodForm1();
                frmFood.Show(this);
                frmFood.LoadFood(Convert.ToInt32(textBox1.Text));
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                FoodForm1 frmFood = new FoodForm1();
                frmFood.Show(this);
                frmFood.LoadFood(Convert.ToInt32(textBox1.Text));
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                button4.PerformClick();
        }
    }
}
