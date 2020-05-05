namespace S4_N05_TranDucDung.GUI
{
    partial class DanhMuc
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
            this.comboBoxMaLop = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNSHS = new System.Windows.Forms.TextBox();
            this.buttonXoaHS = new System.Windows.Forms.Button();
            this.buttonHuyHS = new System.Windows.Forms.Button();
            this.textBoxGhiChuHS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDiaChiHS = new System.Windows.Forms.TextBox();
            this.textBoxTenHS = new System.Windows.Forms.TextBox();
            this.dataGridViewHocSinh = new System.Windows.Forms.DataGridView();
            this.buttonLuuHS = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonThemHS = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxGTHS = new System.Windows.Forms.ComboBox();
            this.dataGridViewGiaoVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxNSGV = new System.Windows.Forms.TextBox();
            this.buttonXoaGV = new System.Windows.Forms.Button();
            this.textBoxDiaChiGV = new System.Windows.Forms.TextBox();
            this.textBoxTenGV = new System.Windows.Forms.TextBox();
            this.buttonHuyGV = new System.Windows.Forms.Button();
            this.buttonLuuGV = new System.Windows.Forms.Button();
            this.buttonThemGV = new System.Windows.Forms.Button();
            this.textBoxSDTGV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGTGV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaoVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMaLop);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxNSHS);
            this.groupBox1.Controls.Add(this.buttonXoaHS);
            this.groupBox1.Controls.Add(this.buttonHuyHS);
            this.groupBox1.Controls.Add(this.textBoxGhiChuHS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDiaChiHS);
            this.groupBox1.Controls.Add(this.textBoxTenHS);
            this.groupBox1.Controls.Add(this.dataGridViewHocSinh);
            this.groupBox1.Controls.Add(this.buttonLuuHS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonThemHS);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.comboBoxGTHS);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 776);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Học Sinh";
            // 
            // comboBoxMaLop
            // 
            this.comboBoxMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaLop.FormattingEnabled = true;
            this.comboBoxMaLop.Location = new System.Drawing.Point(572, 78);
            this.comboBoxMaLop.Name = "comboBoxMaLop";
            this.comboBoxMaLop.Size = new System.Drawing.Size(172, 24);
            this.comboBoxMaLop.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(493, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 63;
            this.label12.Text = "Mã Lớp :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(323, 17);
            this.label10.TabIndex = 62;
            this.label10.Text = "Nhập ngày tháng năm sinh dưới dạng 11-11-1111";
            // 
            // textBoxNSHS
            // 
            this.textBoxNSHS.Location = new System.Drawing.Point(142, 78);
            this.textBoxNSHS.Name = "textBoxNSHS";
            this.textBoxNSHS.Size = new System.Drawing.Size(340, 22);
            this.textBoxNSHS.TabIndex = 61;
            this.textBoxNSHS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNSHS_KeyPress);
            // 
            // buttonXoaHS
            // 
            this.buttonXoaHS.Enabled = false;
            this.buttonXoaHS.Location = new System.Drawing.Point(511, 302);
            this.buttonXoaHS.Name = "buttonXoaHS";
            this.buttonXoaHS.Size = new System.Drawing.Size(233, 47);
            this.buttonXoaHS.TabIndex = 60;
            this.buttonXoaHS.Text = "Xóa";
            this.buttonXoaHS.UseVisualStyleBackColor = true;
            this.buttonXoaHS.Click += new System.EventHandler(this.buttonXoaHS_Click);
            // 
            // buttonHuyHS
            // 
            this.buttonHuyHS.Enabled = false;
            this.buttonHuyHS.Location = new System.Drawing.Point(14, 302);
            this.buttonHuyHS.Name = "buttonHuyHS";
            this.buttonHuyHS.Size = new System.Drawing.Size(239, 47);
            this.buttonHuyHS.TabIndex = 54;
            this.buttonHuyHS.Text = "Hủy";
            this.buttonHuyHS.UseVisualStyleBackColor = true;
            this.buttonHuyHS.Click += new System.EventHandler(this.buttonHuyHS_Click);
            // 
            // textBoxGhiChuHS
            // 
            this.textBoxGhiChuHS.Location = new System.Drawing.Point(142, 180);
            this.textBoxGhiChuHS.Name = "textBoxGhiChuHS";
            this.textBoxGhiChuHS.Size = new System.Drawing.Size(602, 22);
            this.textBoxGhiChuHS.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Ghi Chú :";
            // 
            // textBoxDiaChiHS
            // 
            this.textBoxDiaChiHS.Location = new System.Drawing.Point(143, 133);
            this.textBoxDiaChiHS.Name = "textBoxDiaChiHS";
            this.textBoxDiaChiHS.Size = new System.Drawing.Size(601, 22);
            this.textBoxDiaChiHS.TabIndex = 57;
            // 
            // textBoxTenHS
            // 
            this.textBoxTenHS.Location = new System.Drawing.Point(142, 29);
            this.textBoxTenHS.Name = "textBoxTenHS";
            this.textBoxTenHS.Size = new System.Drawing.Size(340, 22);
            this.textBoxTenHS.TabIndex = 55;
            // 
            // dataGridViewHocSinh
            // 
            this.dataGridViewHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHocSinh.Location = new System.Drawing.Point(6, 361);
            this.dataGridViewHocSinh.Name = "dataGridViewHocSinh";
            this.dataGridViewHocSinh.ReadOnly = true;
            this.dataGridViewHocSinh.RowTemplate.Height = 24;
            this.dataGridViewHocSinh.Size = new System.Drawing.Size(738, 407);
            this.dataGridViewHocSinh.TabIndex = 1;
            this.dataGridViewHocSinh.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewHocSinh_RowHeaderMouseDoubleClick);
            // 
            // buttonLuuHS
            // 
            this.buttonLuuHS.Enabled = false;
            this.buttonLuuHS.Location = new System.Drawing.Point(259, 302);
            this.buttonLuuHS.Name = "buttonLuuHS";
            this.buttonLuuHS.Size = new System.Drawing.Size(246, 47);
            this.buttonLuuHS.TabIndex = 53;
            this.buttonLuuHS.Text = "Lưu";
            this.buttonLuuHS.UseVisualStyleBackColor = true;
            this.buttonLuuHS.Click += new System.EventHandler(this.buttonLuuHS_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Tên Học Sinh :";
            // 
            // buttonThemHS
            // 
            this.buttonThemHS.Location = new System.Drawing.Point(14, 225);
            this.buttonThemHS.Name = "buttonThemHS";
            this.buttonThemHS.Size = new System.Drawing.Size(730, 55);
            this.buttonThemHS.TabIndex = 52;
            this.buttonThemHS.Text = "Thêm";
            this.buttonThemHS.UseVisualStyleBackColor = true;
            this.buttonThemHS.Click += new System.EventHandler(this.buttonThemHS_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(35, 136);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 17);
            this.label20.TabIndex = 48;
            this.label20.Text = "Địa Chỉ :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(493, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 17);
            this.label19.TabIndex = 45;
            this.label19.Text = "Giới Tính :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 17);
            this.label18.TabIndex = 49;
            this.label18.Text = "Ngày Sinh :";
            // 
            // comboBoxGTHS
            // 
            this.comboBoxGTHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGTHS.FormattingEnabled = true;
            this.comboBoxGTHS.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.comboBoxGTHS.Location = new System.Drawing.Point(572, 29);
            this.comboBoxGTHS.Name = "comboBoxGTHS";
            this.comboBoxGTHS.Size = new System.Drawing.Size(172, 24);
            this.comboBoxGTHS.TabIndex = 47;
            // 
            // dataGridViewGiaoVien
            // 
            this.dataGridViewGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGiaoVien.Location = new System.Drawing.Point(7, 361);
            this.dataGridViewGiaoVien.Name = "dataGridViewGiaoVien";
            this.dataGridViewGiaoVien.ReadOnly = true;
            this.dataGridViewGiaoVien.RowTemplate.Height = 24;
            this.dataGridViewGiaoVien.Size = new System.Drawing.Size(738, 407);
            this.dataGridViewGiaoVien.TabIndex = 0;
            this.dataGridViewGiaoVien.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewGiaoVien_RowHeaderMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxNSGV);
            this.groupBox2.Controls.Add(this.buttonXoaGV);
            this.groupBox2.Controls.Add(this.textBoxDiaChiGV);
            this.groupBox2.Controls.Add(this.textBoxTenGV);
            this.groupBox2.Controls.Add(this.buttonHuyGV);
            this.groupBox2.Controls.Add(this.buttonLuuGV);
            this.groupBox2.Controls.Add(this.dataGridViewGiaoVien);
            this.groupBox2.Controls.Add(this.buttonThemGV);
            this.groupBox2.Controls.Add(this.textBoxSDTGV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxGTGV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(769, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 776);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giáo Viên";
            // 
            // textBoxNSGV
            // 
            this.textBoxNSGV.Location = new System.Drawing.Point(139, 106);
            this.textBoxNSGV.Name = "textBoxNSGV";
            this.textBoxNSGV.Size = new System.Drawing.Size(309, 22);
            this.textBoxNSGV.TabIndex = 62;
            this.textBoxNSGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNSHS_KeyPress);
            // 
            // buttonXoaGV
            // 
            this.buttonXoaGV.Enabled = false;
            this.buttonXoaGV.Location = new System.Drawing.Point(515, 302);
            this.buttonXoaGV.Name = "buttonXoaGV";
            this.buttonXoaGV.Size = new System.Drawing.Size(229, 45);
            this.buttonXoaGV.TabIndex = 45;
            this.buttonXoaGV.Text = "Xóa";
            this.buttonXoaGV.UseVisualStyleBackColor = true;
            this.buttonXoaGV.Click += new System.EventHandler(this.buttonXoaGV_Click);
            // 
            // textBoxDiaChiGV
            // 
            this.textBoxDiaChiGV.Location = new System.Drawing.Point(139, 180);
            this.textBoxDiaChiGV.Name = "textBoxDiaChiGV";
            this.textBoxDiaChiGV.Size = new System.Drawing.Size(594, 22);
            this.textBoxDiaChiGV.TabIndex = 44;
            // 
            // textBoxTenGV
            // 
            this.textBoxTenGV.Location = new System.Drawing.Point(139, 51);
            this.textBoxTenGV.Name = "textBoxTenGV";
            this.textBoxTenGV.Size = new System.Drawing.Size(310, 22);
            this.textBoxTenGV.TabIndex = 42;
            // 
            // buttonHuyGV
            // 
            this.buttonHuyGV.Enabled = false;
            this.buttonHuyGV.Location = new System.Drawing.Point(7, 302);
            this.buttonHuyGV.Name = "buttonHuyGV";
            this.buttonHuyGV.Size = new System.Drawing.Size(244, 47);
            this.buttonHuyGV.TabIndex = 41;
            this.buttonHuyGV.Text = "Hủy";
            this.buttonHuyGV.UseVisualStyleBackColor = true;
            this.buttonHuyGV.Click += new System.EventHandler(this.buttonHuyGV_Click);
            // 
            // buttonLuuGV
            // 
            this.buttonLuuGV.Enabled = false;
            this.buttonLuuGV.Location = new System.Drawing.Point(257, 302);
            this.buttonLuuGV.Name = "buttonLuuGV";
            this.buttonLuuGV.Size = new System.Drawing.Size(252, 47);
            this.buttonLuuGV.TabIndex = 40;
            this.buttonLuuGV.Text = "Lưu";
            this.buttonLuuGV.UseVisualStyleBackColor = true;
            this.buttonLuuGV.Click += new System.EventHandler(this.buttonLuuGV_Click);
            // 
            // buttonThemGV
            // 
            this.buttonThemGV.Location = new System.Drawing.Point(7, 225);
            this.buttonThemGV.Name = "buttonThemGV";
            this.buttonThemGV.Size = new System.Drawing.Size(737, 55);
            this.buttonThemGV.TabIndex = 39;
            this.buttonThemGV.Text = "Thêm";
            this.buttonThemGV.UseVisualStyleBackColor = true;
            this.buttonThemGV.Click += new System.EventHandler(this.buttonThemGV_Click);
            // 
            // textBoxSDTGV
            // 
            this.textBoxSDTGV.Location = new System.Drawing.Point(533, 106);
            this.textBoxSDTGV.MaxLength = 11;
            this.textBoxSDTGV.Name = "textBoxSDTGV";
            this.textBoxSDTGV.Size = new System.Drawing.Size(200, 22);
            this.textBoxSDTGV.TabIndex = 38;
            this.textBoxSDTGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSDTHS_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tên Giáo Viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "SDT :";
            // 
            // comboBoxGTGV
            // 
            this.comboBoxGTGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGTGV.FormattingEnabled = true;
            this.comboBoxGTGV.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.comboBoxGTGV.Location = new System.Drawing.Point(533, 51);
            this.comboBoxGTGV.Name = "comboBoxGTGV";
            this.comboBoxGTGV.Size = new System.Drawing.Size(200, 24);
            this.comboBoxGTGV.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ngày Sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Giới Tính :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Địa Chỉ :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 791);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(466, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Click đúp chuột vào đầu mỗi dòng trong datagridview để sửa hoặc xóa !!! ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(136, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(323, 17);
            this.label11.TabIndex = 63;
            this.label11.Text = "Nhập ngày tháng năm sinh dưới dạng 11-11-1111";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(530, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 17);
            this.label14.TabIndex = 66;
            this.label14.Text = "Nhập tối đa 11 kí tự ";
            // 
            // DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 812);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhMuc";
            this.Load += new System.EventHandler(this.DanhMuc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaoVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewHocSinh;
        private System.Windows.Forms.DataGridView dataGridViewGiaoVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxGhiChuHS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDiaChiHS;
        private System.Windows.Forms.TextBox textBoxTenHS;
        private System.Windows.Forms.Button buttonHuyHS;
        private System.Windows.Forms.Button buttonLuuHS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonThemHS;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxGTHS;
        private System.Windows.Forms.TextBox textBoxDiaChiGV;
        private System.Windows.Forms.TextBox textBoxTenGV;
        private System.Windows.Forms.Button buttonHuyGV;
        private System.Windows.Forms.Button buttonLuuGV;
        private System.Windows.Forms.Button buttonThemGV;
        private System.Windows.Forms.TextBox textBoxSDTGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGTGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonXoaHS;
        private System.Windows.Forms.Button buttonXoaGV;
        private System.Windows.Forms.TextBox textBoxNSHS;
        private System.Windows.Forms.TextBox textBoxNSGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxMaLop;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
    }
}