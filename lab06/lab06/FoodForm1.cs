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
    public partial class FoodForm1 : Form
    {
        int categoryID;
        public FoodForm1()
        {
            InitializeComponent();
        }
        public void LoadFood(int categoryID)
		{
			this.categoryID = categoryID;
			string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RestaurantManagement;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			command.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID;

			connection.Open();

			string categoryName = command.ExecuteScalar().ToString();
			this.Text = "Danh sách các món ăn thuộc nhóm: " + categoryName;

			command.CommandText = "SELECT ID, Name, Unit, Price, Notes FROM Food WHERE FoodCategoryID = " + categoryID;

			SqlDataAdapter adapter = new SqlDataAdapter(command);

			DataTable table = new DataTable("Food");
			adapter.Fill(table);

			dataGridView1.DataSource = table;

			// Prevent user to edit ID
			dataGridView1.Columns[0].ReadOnly = true;

			connection.Close();
			connection.Dispose();
			adapter.Dispose();
		}


    }
}
