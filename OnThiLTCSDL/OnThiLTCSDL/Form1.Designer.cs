namespace OnThiLTCSDL
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvBanAn = new System.Windows.Forms.DataGridView();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbValue = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpDate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nrudSoChoNgoi = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudSoChoNgoi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBanAn);
            this.groupBox1.Location = new System.Drawing.Point(-1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sach ban an";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpDate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(350, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thong tin ban an";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCTHD);
            this.groupBox3.Location = new System.Drawing.Point(350, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 287);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiet hoa don";
            // 
            // dgvBanAn
            // 
            this.dgvBanAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanAn.BackgroundColor = System.Drawing.Color.White;
            this.dgvBanAn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBanAn.Location = new System.Drawing.Point(3, 16);
            this.dgvBanAn.MultiSelect = false;
            this.dgvBanAn.Name = "dgvBanAn";
            this.dgvBanAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBanAn.Size = new System.Drawing.Size(339, 419);
            this.dgvBanAn.TabIndex = 0;
            this.dgvBanAn.Click += new System.EventHandler(this.dgvBanAn_Click);
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHD.Location = new System.Drawing.Point(3, 16);
            this.dgvCTHD.MultiSelect = false;
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.Size = new System.Drawing.Size(301, 268);
            this.dgvCTHD.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(7, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 27);
            this.panel1.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 4);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(57, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.cbbValue);
            this.panel2.Location = new System.Drawing.Point(173, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 27);
            this.panel2.TabIndex = 2;
            // 
            // cbbValue
            // 
            this.cbbValue.AutoSize = true;
            this.cbbValue.Location = new System.Drawing.Point(13, 4);
            this.cbbValue.Name = "cbbValue";
            this.cbbValue.Size = new System.Drawing.Size(34, 13);
            this.cbbValue.TabIndex = 0;
            this.cbbValue.Text = "Value";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Trong",
            "Co nguoi"});
            this.comboBox1.Location = new System.Drawing.Point(74, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Location = new System.Drawing.Point(7, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 27);
            this.panel3.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(91, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ten ban an";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Them";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpDate
            // 
            this.btnUpDate.Location = new System.Drawing.Point(90, 98);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.Size = new System.Drawing.Size(58, 23);
            this.btnUpDate.TabIndex = 5;
            this.btnUpDate.Text = "Cap nhat";
            this.btnUpDate.UseVisualStyleBackColor = true;
            this.btnUpDate.Click += new System.EventHandler(this.btnUpDate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(161, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "xoa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(226, 98);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(53, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Thoat";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nrudSoChoNgoi);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(175, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(132, 27);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "so cho ngoi";
            // 
            // nrudSoChoNgoi
            // 
            this.nrudSoChoNgoi.Location = new System.Drawing.Point(71, 4);
            this.nrudSoChoNgoi.Name = "nrudSoChoNgoi";
            this.nrudSoChoNgoi.Size = new System.Drawing.Size(46, 20);
            this.nrudSoChoNgoi.TabIndex = 1;
            this.nrudSoChoNgoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 436);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly nha hang";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudSoChoNgoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBanAn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label cbbValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nrudSoChoNgoi;
        private System.Windows.Forms.Label label1;
    }
}

