using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S4_N05_TranDucDung.BUS;
using S4_N05_TranDucDung.DTO;

namespace S4_N05_TranDucDung.GUI
{
    public partial class NghiepVu : Form
    {
        Controller con = new Controller();

        private int index;
        public NghiepVu()
        {
            InitializeComponent();
        }

        private void buttonXuat_Click(object sender, EventArgs e)
        {
            XuatReport xuatReport = new XuatReport();
            this.Hide();
            xuatReport.FormClosed += XuatReport_FormClosed;
            xuatReport.Show();
        }

        private void XuatReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void NghiepVu_Load(object sender, EventArgs e)
        {
            List<string> s = con.GetSoBanXuat();
            labelok.Text = s[0];
            labelwarning.Text = s[1];
            labelerror.Text = s[2];
            comboBoxHeSo.SelectedIndex = 0;

            dataGridViewDiem.DataSource = con.GetDiem("None", "None", "None", "None");
            dataGridViewBangDiem.DataSource = con.GetBangDiem("None", "None", "None", "None");

            s.Clear();
            s = con.GetDanhSachMaHK();
            s.Add("None");
            List<string> s1 = con.GetDanhSachMaHK();
            List<string> s2 = con.GetDanhSachMaHK();
            s1.Add("None");
            comboBoxHKD.DataSource = s;
            comboBoxHKD.SelectedItem = "None";
            comboBoxKhoa.DataSource = s1;
            comboBoxKhoa.SelectedItem = "None";
            comboBoxChonHK.DataSource = s2;

            DataTable dataD = con.GetDanhSachMonHocDT();
            DataTable data = con.GetDanhSachMonHocDT();
            DataTable dataLuu = con.GetDanhSachMonHocDT();
            dataLuu.Rows[dataLuu.Rows.Count - 1].Delete();
            comboBoxMonHocD.DataSource = dataD;
            comboBoxMonHocD.ValueMember = "MaMH";
            comboBoxMonHocD.DisplayMember = "TenMH";
            comboBoxMonHocD.SelectedValue = "None";
            comboBoxMonHoc.DataSource = data;
            comboBoxMonHoc.ValueMember = "MaMH";
            comboBoxMonHoc.DisplayMember = "TenMH";
            comboBoxMonHoc.SelectedValue = "None";
            comboBoxChonMH.DataSource = dataLuu;
            comboBoxChonMH.ValueMember = "MaMH";
            comboBoxChonMH.DisplayMember = "TenMH";

            dataD = con.GetDanhSachLopDT();
            data = con.GetDanhSachLopDT();
            dataLuu = con.GetDanhSachLopDT();
            dataLuu.Rows[dataLuu.Rows.Count - 1].Delete();
            comboBoxTenLopD.DataSource = dataD;
            comboBoxTenLopD.ValueMember = "MaLop";
            comboBoxTenLopD.DisplayMember = "TenLop";
            comboBoxTenLopD.SelectedValue = "None";
            comboBoxTenLop.DataSource = data;
            comboBoxTenLop.ValueMember = "MaLop";
            comboBoxTenLop.DisplayMember = "TenLop";
            comboBoxTenLop.SelectedValue = "None";
            comboBoxChonLop.DataSource = dataLuu;
            comboBoxChonLop.ValueMember = "MaLop";
            comboBoxChonLop.DisplayMember = "TenLop";

            dataD = con.GetDanhSachHocSinhDT();
            data = con.GetDanhSachHocSinhDT();
            dataLuu = con.GetDanhSachHocSinhDT();
            dataLuu.Rows[dataLuu.Rows.Count - 1].Delete();
            comboBoxTenHSD.DataSource = dataD;
            comboBoxTenHSD.DisplayMember = "TenHocSinh";
            comboBoxTenHSD.ValueMember = "MaHS";
            comboBoxTenHSD.SelectedValue = "None";
            comboBoxTenHS.DataSource = data;
            comboBoxTenHS.DisplayMember = "TenHocSinh";
            comboBoxTenHS.ValueMember = "MaHS";
            comboBoxTenHS.SelectedValue = "None";
            comboBoxChonHS.DataSource = dataLuu;
            comboBoxChonHS.DisplayMember = "TenHocSinh";
            comboBoxChonHS.ValueMember = "MaHS";
        }

        private void buttonLocDiem_Click(object sender, EventArgs e)
        {
            dataGridViewDiem.DataSource = null;
            dataGridViewDiem.DataSource = con.GetDiem(comboBoxTenLopD.SelectedValue.ToString(),
                                   comboBoxTenHSD.SelectedValue.ToString(),
                                   comboBoxMonHocD.SelectedValue.ToString(),
                                   comboBoxHKD.SelectedValue.ToString());
        }

        private void buttonLocBangDiem_Click(object sender, EventArgs e)
        {
            dataGridViewBangDiem.DataSource = null;
            dataGridViewBangDiem.DataSource = con.GetBangDiem(comboBoxTenLop.SelectedValue.ToString(),
                                                        comboBoxTenHS.SelectedValue.ToString(),
                                                        comboBoxMonHoc.SelectedValue.ToString(),
                                                        comboBoxKhoa.SelectedValue.ToString());
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            int num=0;
            try{
                num = Convert.ToInt16(textBoxDiem.Text);
                Console.WriteLine(Convert.ToInt16(comboBoxHeSo.SelectedItem.ToString()));
                bool check = con.LuuDiem(comboBoxChonHS.SelectedValue.ToString(),
                                           comboBoxChonMH.SelectedValue.ToString(),
                                           Convert.ToInt16(comboBoxHeSo.SelectedItem.ToString()),
                                           num,
                                           comboBoxChonLop.SelectedValue.ToString(),
                                           comboBoxChonHK.SelectedValue.ToString());
                if(check == true)
                {
                    MessageBox.Show("Xong!");
                    dataGridViewBangDiem.DataSource = null;
                    dataGridViewBangDiem.DataSource = con.GetBangDiem(comboBoxTenLop.SelectedValue.ToString(),
                                                                comboBoxTenHS.SelectedValue.ToString(),
                                                                comboBoxMonHoc.SelectedValue.ToString(),
                                                                comboBoxKhoa.SelectedValue.ToString());
                    dataGridViewDiem.DataSource = null;
                    dataGridViewDiem.DataSource = con.GetDiem(comboBoxTenLopD.SelectedValue.ToString(),
                                           comboBoxTenHSD.SelectedValue.ToString(),
                                           comboBoxMonHocD.SelectedValue.ToString(),
                                           comboBoxHKD.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Môn học này không có trong lớp, hoặc học sinh này không trong lớp, vui lòng chọn lại!");
                }
            }
            catch
            {
                MessageBox.Show("Nhập lại điểm");
                textBoxDiem.Text = "";
            }
        }
    }
}
