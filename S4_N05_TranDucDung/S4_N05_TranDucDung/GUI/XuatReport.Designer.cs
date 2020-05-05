namespace S4_N05_TranDucDung
{
    partial class XuatReport
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
            this.buttonChon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMaHK = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNamHoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMaLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTenLop = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChon
            // 
            this.buttonChon.Location = new System.Drawing.Point(18, 360);
            this.buttonChon.Name = "buttonChon";
            this.buttonChon.Size = new System.Drawing.Size(79, 31);
            this.buttonChon.TabIndex = 1;
            this.buttonChon.Text = "Chọn";
            this.buttonChon.UseVisualStyleBackColor = true;
            this.buttonChon.Click += new System.EventHandler(this.buttonChon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Lớp :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxok);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxMaHK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNamHoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxMaLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxTenLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonChon);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 806);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa Chọn";
            // 
            // textBoxok
            // 
            this.textBoxok.Location = new System.Drawing.Point(18, 478);
            this.textBoxok.Multiline = true;
            this.textBoxok.Name = "textBoxok";
            this.textBoxok.ReadOnly = true;
            this.textBoxok.Size = new System.Drawing.Size(212, 307);
            this.textBoxok.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Các lớp có thể xuất báo cáo :";
            // 
            // comboBoxMaHK
            // 
            this.comboBoxMaHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaHK.FormattingEnabled = true;
            this.comboBoxMaHK.Location = new System.Drawing.Point(18, 240);
            this.comboBoxMaHK.Name = "comboBoxMaHK";
            this.comboBoxMaHK.Size = new System.Drawing.Size(212, 24);
            this.comboBoxMaHK.TabIndex = 10;
            this.comboBoxMaHK.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaHK_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Năm Học :";
            // 
            // textBoxNamHoc
            // 
            this.textBoxNamHoc.Enabled = false;
            this.textBoxNamHoc.Location = new System.Drawing.Point(18, 320);
            this.textBoxNamHoc.Name = "textBoxNamHoc";
            this.textBoxNamHoc.Size = new System.Drawing.Size(212, 22);
            this.textBoxNamHoc.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã Học Kỳ :";
            // 
            // comboBoxMaLop
            // 
            this.comboBoxMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaLop.FormattingEnabled = true;
            this.comboBoxMaLop.Location = new System.Drawing.Point(18, 80);
            this.comboBoxMaLop.Name = "comboBoxMaLop";
            this.comboBoxMaLop.Size = new System.Drawing.Size(212, 24);
            this.comboBoxMaLop.TabIndex = 6;
            this.comboBoxMaLop.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Lớp :";
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.Enabled = false;
            this.textBoxTenLop.Location = new System.Drawing.Point(18, 160);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(212, 22);
            this.textBoxTenLop.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "S4_N05_TranDucDung.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(286, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1240, 812);
            this.reportViewer1.TabIndex = 0;
            // 
            // XuatReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 812);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "XuatReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTenLop;
        private System.Windows.Forms.ComboBox comboBoxMaLop;
        private System.Windows.Forms.ComboBox comboBoxMaHK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNamHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxok;
        private System.Windows.Forms.Label label5;
    }
}

