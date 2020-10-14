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
    public partial class capnhatTG : Form
    {
        public capnhatTG()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();

        private void capnhatTG_Load(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dataGridView1,"select *from tblTacGia");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "Insert Into tblTacGia(MATG,TENTG,GIOITINH,DIACHI,GHICHU) values ('" + txtMATG.Text + "','" + txtHOTEN.Text + "','" + cboGIOITINH.Text + "','" + txtDIACHI.Text + "','" + richTextBox1.Text + "')";
                cls.ThucThiSQLTheoPKN(strInsert);
                cls.LoadData2DataGridView(dataGridView1, "select *from tblTacGia");
                MessageBox.Show("Thêm thành công");
            }
            catch { MessageBox.Show("Trùng Mã"); };           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string strDelete = "Delete from tblTacGia where MATG='" + txtMATG.Text + "'";
                    cls.ThucThiSQLTheoKetNoi(strDelete);
                    cls.LoadData2DataGridView(dataGridView1, "select *from tblTacGia");
                    MessageBox.Show("Xóa thành công !!!");
                }
                catch { MessageBox.Show("Phải xóa những thông tin liên quan đến tác giả này trước"); };
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMATG.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHOTEN.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboGIOITINH.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDIACHI.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch { };
        }
        int dem = 0;
        string matg;
        private void button2_Click(object sender, EventArgs e)
        {

            if (dem == 0)
            {
                matg = txtMATG.Text;
                dem = 1;
                button1.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                try
                {
                    string strUpdate = "Update tblTacGia set MATG='" + txtMATG.Text + "',TENTG='" + txtHOTEN.Text + "',GIOITINH='" + cboGIOITINH.Text + "',GHICHU='" + richTextBox1.Text + "' where MATG='" + matg + "'";
                    cls.ThucThiSQLTheoPKN(strUpdate);
                    cls.LoadData2DataGridView(dataGridView1, "select *from tblTacGia");
                    button1.Enabled = true;
                    button3.Enabled = true;
                    dem = 0;
                    MessageBox.Show("Sửa thành công");
                }
                catch { MessageBox.Show("Trùng mã"); };               
            }
        }
    }
}
