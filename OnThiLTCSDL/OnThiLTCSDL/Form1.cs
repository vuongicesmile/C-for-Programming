using OnThiLTCSDL.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnThiLTCSDL
{
    public partial class frmMain : Form
    {
        BindingSource banAnSource = new BindingSource();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BanAnDAO bananDAO = new BanAnDAO();
            dgvBanAn.DataSource = banAnSource;
            banAnSource.DataSource = bananDAO.LayDSBanAn();
            AddBindingSourceBanAn();
        }
        private void AddBindingSourceBanAn()
        {
            txtID.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "Id"));
            txtName.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "Name"));
            nrudSoChoNgoi.DataBindings.Add(new Binding("Value", dgvBanAn.DataSource, "Capacity"));
            comboBox1.DataBindings.Add(new Binding("SelectedIndex", dgvBanAn.DataSource, "Status"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int status =Convert.ToInt32(nrudSoChoNgoi.Value);
            int capacity = 0;
            if(comboBox1.SelectedItem.ToString().Equals("Co nguoi"))
                capacity = 1;
            BanAnDAO banAnDAO = new BanAnDAO();
            bool thanhcong= banAnDAO.TaoBanAn(name, status, capacity);

            if (thanhcong == false)
            {
                MessageBox.Show("Co loi trong qua trinh", "thong bao loi");
                return;
            }
            dgvBanAn.DataSource = banAnDAO.LayDSBanAn();

        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(txtID.Text);
            string name = txtName.Text;
            int status = Convert.ToInt32(nrudSoChoNgoi.Value);
            int capacity = 0;
            if (comboBox1.SelectedItem.ToString().Equals("Co nguoi"))
                capacity = 1;

            BanAnDAO banAnDAO = new BanAnDAO();
            bool capnhatthanhcong =banAnDAO.CapNhatBanAn(id, name, status, capacity);

            if(capnhatthanhcong==false)
            {
                MessageBox.Show("co loi trong qua trinh cap nhat", "Thong bao loi");
                return;
            }
            MessageBox.Show("cap nhat thanh cong", "thong bao");
            dgvBanAn.DataSource = banAnDAO.LayDSBanAn();



        }

        private void dgvBanAn_Click(object sender, EventArgs e)
        {
            if (dgvBanAn.SelectedRows.Count == 0) return;

            int tableId = Convert.ToInt32(dgvBanAn.SelectedRows[0].Cells["Id"].Value.ToString());

            ChiTietHoaDonDAO chitiethoadonDAO = new ChiTietHoaDonDAO();
            dgvCTHD.DataSource = chitiethoadonDAO.LayChiTietHoaDonTheoBan(tableId);
        }
    }
}
