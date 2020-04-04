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
        private List<HocKy> hks = new List<HocKy>();
        private Controller con = new Controller();

        private string maLop;
        private string tenLop;
        private string hocKy;
        private string namHoc;
        private DateTime date;
        private string tenGVCN;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lops = con.GetDanhSachLop();
            hks = con.GetDanhHocKy();
            comboBoxMaHK.DataSource = con.GetDanhSachMaHK();
            comboBoxMaLop.DataSource = con.GetDanhSachMaLop();

            date = DateTime.Today;
        }

        private void buttonChon_Click(object sender, EventArgs e)
        {
            ReportParameter reportTenLop = new ReportParameter("ReportParameterTenLop", "Lớp : "+ tenLop );
            ReportParameter reportNamHoc = new ReportParameter("ReportParameterNamHoc", "Điểm tổng kết năm học : " + namHoc);
            ReportParameter reportHocKy = new ReportParameter("ReportParameterHocKy", "Học Kỳ :  " + hocKy);
            ReportParameter reportXepLoai = new ReportParameter("ReportParameterXepLoai", con.GetXepLoai(maLop));
            ReportParameter reportDate = new ReportParameter("ReportParameterThuNgayThang", "Hà Nội, Thứ " + (int)date.DayOfWeek + " Ngày " + date.Day + " Tháng " + date.Month +" Năm " + date.Year);
            ReportParameter reportTenGVCN = new ReportParameter("ReportParameterGVCN", tenGVCN);


            ReportParameterCollection reports = new ReportParameterCollection();
            reports.Add(reportTenLop);
            reports.Add(reportNamHoc);
            reports.Add(reportHocKy);
            reports.Add(reportXepLoai);
            reports.Add(reportDate);
            reports.Add(reportTenGVCN);

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
                    maLop = item.MaLop;
                    tenLop = textBoxTenLop.Text;
                    tenGVCN = con.GetGVCN(item.MaGVCN);
                    break;
                }
            }
        }

        private void comboBoxMaHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (HocKy item in hks)
            {
                if (item.MaHK == comboBoxMaHK.Text)
                {
                    textBoxNamHoc.Text = item.NamHoc;
                    namHoc = item.NamHoc;
                    break;
                }
            }
            string[] strs = comboBoxMaHK.Text.Split('-');
            hocKy = strs[1];
            hocKy = hocKy.Remove(0,1);
        }
    }
}
