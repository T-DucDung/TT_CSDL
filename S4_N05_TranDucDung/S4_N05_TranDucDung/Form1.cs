using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using S4_N05_TranDucDung.DTO;
using S4_N05_TranDucDung.BUS;


namespace S4_N05_TranDucDung
{
    public partial class Form1 : Form
    {
        private List<Lop> lops = new List<Lop>();
        private Controller con = new Controller();

        private string tenLop;
        private string nienKhoa;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lops = con.GetDanhSachLop();
            comboBoxMaLop.DataSource = con.GetDanhSachMaLop();
        }

        private void buttonChon_Click(object sender, EventArgs e)
        {
            ReportParameter reportTenLop = new ReportParameter("ReportParameterTenLop", "Lớp : "+ tenLop );
            ReportParameter reportNienKhoa = new ReportParameter("ReportParameterNamHoc", "Điểm tổng kết năm học : " + nienKhoa);

            ReportParameterCollection reports = new ReportParameterCollection();
            reports.Add(reportTenLop);
            reports.Add(reportNienKhoa);

            this.reportViewer1.LocalReport.SetParameters(reports);
            this.reportViewer1.RefreshReport();
        }

        private void comboBoxMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Lop item in lops)
            {
                if(item.MaLop == comboBoxMaLop.Text)
                {
                    textBoxTenLop.Text = item.TenLop;
                    tenLop = textBoxTenLop.Text;
                    nienKhoa = item.NienKhoa;
                    break;
                }
            }
        }
    }
}
