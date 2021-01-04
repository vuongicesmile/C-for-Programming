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
    public partial class fOODInfoForm : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RestaurantManagement;Integrated Security=True";
        public fOODInfoForm()
        {
            InitializeComponent();
        }

        private void fOODInfoForm_Load(object sender, EventArgs e)
        {
            InitValues();

        }
        private void InitValues()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                SqlCommand command = connect.CreateCommand();
                command.CommandText = "select ID , Name from Category";

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dtset = new DataSet();

                adapter.Fill(dtset, "Category");

                //hien thi len combobox
                comboBox1.DataSource = dtset.Tables["Category"];
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";

                connect.Close();
            }
        }
        private void ResetText()
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            comboBox1.ResetText();
            textBox5.ResetText();
        }

        public void DisplayFoodInfo(DataRowView rowview)
        {
            try
            {
                textBox1.Text = rowview["ID"].ToString();
                textBox2.Text = rowview["Name"].ToString();
                textBox3.Text = rowview["Unit"].ToString();
                textBox4.Text = rowview["Notes"].ToString();
                textBox5.Text = rowview["Price"].ToString();

                comboBox1.SelectedIndex = -1;

                for (int index = 0; index < comboBox1.Items.Count; index++)
                {
                    DataRowView cat = comboBox1.Items[index] as DataRowView;

                    if (cat["ID"].ToString() == rowview["FoodCategoryID"].ToString())
                    {
                        comboBox1.SelectedIndex = index;
                        break;
                    }
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    SqlCommand command = connect.CreateCommand();
                    command.CommandText = "execute USP_InsertFood  @ID output , @Name  , @Unit, @FoodCategoryId , @Price , @Notes";

                    command.Parameters.Add("@ID", SqlDbType.Int);
                    command.Parameters.Add("@Name", SqlDbType.NVarChar, 100);
                    command.Parameters.Add("@Unit", SqlDbType.NVarChar, 100);
                    command.Parameters.Add("@FoodCategoryId", SqlDbType.Int);
                    command.Parameters.Add("@Price", SqlDbType.NVarChar, 100);
                    command.Parameters.Add("@Notes", SqlDbType.NVarChar, 100);

                    command.Parameters["@id"].Direction = ParameterDirection.Output;

                    command.Parameters["@Name"].Value = textBox1.Text;
                    command.Parameters["@Unit"].Value = textBox2.Text;
                    command.Parameters["@FoodCategoryId"].Value = comboBox1.SelectedValue;
                    command.Parameters["@Price"].Value = textBox5.Text;
                    command.Parameters["@Notes"].Value = textBox3.Text;

                    int numRowAffected = command.ExecuteNonQuery();

                    if (numRowAffected > 0)
                    {
                        string foodid = command.Parameters["@id"].Value.ToString();

                        MessageBox.Show("Thêm thành công tại FoodID = " + foodid, "Message");
                        this.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Food bị lỗi");
                    }


                    connect.Close();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    SqlCommand command = connect.CreateCommand();
                    command.CommandText = "exec UpdateFood @ID , @Name , @Unit , @FoodCategoryId , @Price , @Notes";

                    command.Parameters.Add("@ID", SqlDbType.Int);
                    command.Parameters.Add("@Name", SqlDbType.NVarChar, 100);
                    command.Parameters.Add("@Unit", SqlDbType.NVarChar, 100);
                    command.Parameters.Add("@FoodCategoryId", SqlDbType.Int);
                    command.Parameters.Add("@Price", SqlDbType.NVarChar, 100);
                    command.Parameters.Add("@Notes", SqlDbType.NVarChar, 100);

                    command.Parameters["@id"].Value = textBox1.Text;

                    command.Parameters["@Name"].Value = textBox2.Text;
                    command.Parameters["@Unit"].Value = textBox3.Text;
                    command.Parameters["@FoodCategoryId"].Value = comboBox1.SelectedValue;
                    command.Parameters["@Price"].Value = textBox5.Text;
                    command.Parameters["@Notes"].Value = textBox4.Text;

                    int numRowAffected = command.ExecuteNonQuery();

                    if (numRowAffected > 0)
                    {

                        MessageBox.Show("Update thành công ", "Message");
                        this.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Update Food bị lỗi");
                    }


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dtset = new DataSet();

                    adapter.Fill(dtset, "Category");

                    //hien thi len combobox
                    comboBox1.DataSource = dtset.Tables["Category"];
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "ID";

                    connect.Close();
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

