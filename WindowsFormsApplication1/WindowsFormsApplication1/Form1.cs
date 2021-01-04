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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DataTable foodTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadCateGory()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select id,name from category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            //mo ket noi
            con.Open();
            //lay du lieu tu csdl dua vao datatable
            adapter.Fill(dt);
            //dong ket noi va giia phong bo nho
            con.Close();
            con.Dispose();
            //dua du lieu vao combobox
            comboBox1.DataSource = dt;
            //hien thi ten nhom san pham
            comboBox1.DisplayMember = "Name";
            //nhung khi lay gia tri thi lay id cua nhom
            comboBox1.ValueMember = "ID";

        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadCateGory();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from food where foodCategoryID = @categoryid";

            //truyen tham so
            cmd.Parameters.Add("@categoryid", SqlDbType.Int);
            if(comboBox1.SelectedValue is DataRowView)
            {
                DataRowView rowView = comboBox1.SelectedValue as DataRowView;
                cmd.Parameters["@categoryid"].Value = rowView["id"];

            }
            else
            {
                cmd.Parameters["@categoryid"].Value = comboBox1.SelectedValue;

            }
            //tao bo dieu khien du lieu
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            foodTable = new DataTable();
            con.Open();
            adapter.Fill(foodTable);
            con.Close();
            con.Dispose();
            dataGridView1.DataSource = foodTable;
            //tinh so luong mau tin
            label2.Text = foodTable.Rows.Count.ToString();
            label4.Text = comboBox1.Text;

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            string query = "SELECT @numsalefood = sum(Quantity) from BillDetails where FoodID = @foodid";

                SqlCommand command = con.CreateCommand();
                command.CommandText = query;

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectrow = dataGridView1.SelectedRows[0];

                    DataRowView rowview = selectrow.DataBoundItem as DataRowView;

                    //truyen tham so
                    command.Parameters.Add("@foodid", SqlDbType.Int);
                    command.Parameters["@foodid"].Value = rowview["ID"];

                    command.Parameters.Add("@numsalefood", SqlDbType.Int);
                    command.Parameters["@numsalefood"].Direction = ParameterDirection.Output;

                    con.Open();

                    //thuc thi va lay du lieu tu tham so
                    command.ExecuteNonQuery();

                    string result = command.Parameters["@numsalefood"].Value.ToString();
                    if (result == "")
                        result = "0";
                    MessageBox.Show("Tổng số lượng món " + rowview["Name"] + " đã bán là: " + result + " " + rowview["Unit"]);
                    con.Close();
                    con.Dispose();
                }
            }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndex = index;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fOODInfoForm frm = new fOODInfoForm();
            frm.FormClosed += new FormClosedEventHandler(Frm_FormClosed);
            frm.Show(this);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectrow = dataGridView1.SelectedRows[0];
                DataRowView rowview = selectrow.DataBoundItem as DataRowView;

                fOODInfoForm frm = new fOODInfoForm();
                frm.FormClosed += new FormClosedEventHandler(Frm_FormClosed);
                frm.Show(this);

                frm.DisplayFoodInfo(rowview);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;

            string filterExpression = "Name like '%" + textBox1.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState rowsatefilter = DataViewRowState.OriginalRows;

            DataView foodView = new DataView(foodTable, filterExpression, sortExpression, rowsatefilter);

            dataGridView1.DataSource = foodView;
        }
    }
    }

