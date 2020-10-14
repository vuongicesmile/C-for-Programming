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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        Class.clsDatabase cls = new QuanLyThuVien.Class.clsDatabase();
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length - 1 < 5)//kiểm tra mật khẩu mới xem co lờn hơn 6 ký tụ ko
                MessageBox.Show("mật khẩu mới quá ngắn");
            else
                if (textBox2.Text.Length - 1 > 30)//kiểm tra mật khẩu mới xem có bé hơn 30 ký tụ ko
                    MessageBox.Show("mật khẩu mới quá dài");
                else
                    if (textBox2.Text != textBox3.Text)//kiểm tra mật khẩu mới và xác nhận mk co trung nha
                        MessageBox.Show("mật khẩu mới không trùng hãy nhập lại");
                    else
                        if (textBox1.Text != Main.MatKhau)//kiểm tra mật khẩu cũ
                            MessageBox.Show("Mật khẩu cũ sai hãy nhập lại mật khẩu");
                        else
                        {
                            try//thục hiên cau lệnh để thay đổi mật khẩu
                            {
                                string strUpdate = "Update tblNhanVien set MATKHAU='" + textBox2.Text + "'where MATKHAU='" + textBox1.Text + "'";
                                cls.ThucThiSQLTheoKetNoi(strUpdate);
                                MessageBox.Show("đổi mật khẩu thành công");
                            }
                            catch (Exception E)
                            { MessageBox.Show("" + E.ToString()); }
                        }
        //    string strUpdate = "Update tblNhanVien set MATKHAU='" + textBox2.Text + "'where MATKHAU='" + textBox1.Text + "'";
        //    cls.ThucThiSQLTheoKetNoi(strUpdate);
        //    MessageBox.Show("Đổi mật khẩu thành công");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '\0';
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

    }
}
