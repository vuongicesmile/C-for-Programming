using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thigiuaki7d;

namespace Thigiuaki7d
{
    public partial class Form1 : Form
    {
        StudentManagement qlsv;
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadListView()
        {
            listView1.Items.Clear();
            foreach (Student sv in qlsv.danhsachsinhvien)
            {
                ThemSVvaoLV(sv);
            }
        }

        //them sinh vien trong danh sach sv vao list view
        public void ThemSVvaoLV(Student sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.Mssv);
            lvitem.SubItems.Add(sv.Hotenlot);
            lvitem.SubItems.Add(sv.Ten);
            string gt = "Nữ";
            if (sv.Gioitinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.Ngaysinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.Sodt);
            lvitem.SubItems.Add(sv.Cmnd);
            lvitem.SubItems.Add(sv.Diachi);
            string mhdk = "";
            foreach (string mh in sv.Monhocdangky)
            {
                mhdk += mh + ",";
            }
            mhdk = mhdk.Substring(0, mhdk.Length - 1);//?
            lvitem.SubItems.Add(mhdk);

            listView1.Items.Add(lvitem);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qlsv = new StudentManagement();
            qlsv.DocFile();
            LoadListView();

        }
    }
}
