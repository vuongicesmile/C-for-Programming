using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class KiemTraTTNhanVien : Form
    {
        public KiemTraTTNhanVien()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void KiemTraTTNhanVien_Load(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dataGridView1, "select*from tblNhanVien"); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        string TenTK;
        int Dem = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Dem == 0)
            {
                TenTK = textBox1.Text;
                button2.Enabled = false;
                Dem = 1;
                textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = "";
            }
            else
            {
                button2.Enabled = true;
                if (textBox4.Text.Length - 1 == 0)
                    MessageBox.Show("Không được để trống tên nhân viên");
                else
                    if (textBox2.Text.Length - 1 == 0 || textBox3.Text.Length - 1 == 0)
                        MessageBox.Show("Không được để trống mật khẩu");
                    else
                        if (textBox3.Text.Length - 1 == 0)
                            MessageBox.Show("Không được để trống quyền hạn");
                        else
                            if (textBox5.Text.Length - 1 == 0)
                                MessageBox.Show("Không được để trống địa chỉ");
                            else
                                if (textBox8.Text.Length - 1 == 0)
                                    MessageBox.Show("Không được để trống chức vụ");
                                else
                                    if (textBox9.Text.Length - 1 == 0)
                                        MessageBox.Show("Không được để trống tuổi");
                                    else
                                        if (textBox6.Text.Length - 1 <= 0 || textBox6.Text.Length - 1 > 12)
                                            MessageBox.Show("Số điện thoại phải dài hơn 12 số và nhỏ hơn 0 số");
                                        else
                                            if (textBox9.Text.Length - 1 <= 17 || textBox9.Text.Length - 1 > 55)
                                                MessageBox.Show("Sai tuổi");
                                            else
                                            {
                                                string SQL = ("update tblNhanVien set MatKhau='" + textBox2.Text + "',QUYENHAN='" + textBox3.Text + "',TENNV='" + textBox4.Text + "',DiaChi='" + textBox5.Text + "',DIENTHOAI='" + textBox6.Text + "',EMAIL='" + textBox7.Text + "',ChucVu='" + textBox8.Text + "',Tuoi='" + textBox9.Text + "'where TaiKhoan='" + TenTK + "'");
                                                cls.ThucThiSQLTheoKetNoi(SQL);
                                                cls.LoadData2DataGridView(dataGridView1, "select*from tblNhanVien");
                                                MessageBox.Show("Đã Sửa thành công");
                                            }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox4.Text;
            if (textBox3.Text == "admin")
                MessageBox.Show("Không thể xóa tài khoản admin");
            else
                if (MessageBox.Show("Bạn có chắc chắn xóa thông tin nhân viên "+s,"Thông Báo Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string SQL = ("delete from tblNhanVien where TaiKhoan='" + textBox1.Text + "'");
                    cls.ThucThiSQLTheoKetNoi(SQL);
                    cls.LoadData2DataGridView(dataGridView1, "select*from tblNhanVien");
                    MessageBox.Show("Xóa thành công");
                }
                   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
