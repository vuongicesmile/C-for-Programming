using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class ttNXB : Form
    {
        public ttNXB()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void ttNXB_Load(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dataGridView1,"Select *from tblNXB");
        }
    }
}
