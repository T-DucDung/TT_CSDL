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

namespace S4_N05_TranDucDung.GUI
{
    public partial class DanhMuc : Form
    {
        Controller con = new Controller();

        private string mahs;
        private string magv;
        public DanhMuc()
        {
            InitializeComponent();
        }

        private void DanhMuc_Load(object sender, EventArgs e)
        {
            DataTable data = con.GetDanhSachHocSinhDT();
            data.Rows[data.Rows.Count - 1].Delete();
            dataGridViewHocSinh.DataSource = con.ConvertHocSinh(data);

            dataGridViewGiaoVien.DataSource = con.GetDanhSachGiaoVien();

            data = con.GetDanhSachLopDT();
            data.Rows[data.Rows.Count - 1].Delete();
            comboBoxMaLop.DataSource = data;
            comboBoxMaLop.ValueMember = "MaLop";
            comboBoxMaLop.DisplayMember = "TenLop";
        }

        private void dataGridViewHocSinh_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttonThemHS.Enabled = false;
            buttonLuuHS.Enabled = true;
            buttonHuyHS.Enabled = true;
            buttonXoaHS.Enabled = true;
            int index = e.RowIndex;
            DataGridViewRow row = dataGridViewHocSinh.Rows[index];
            mahs = row.Cells[0].Value.ToString();
            textBoxTenHS.Text = row.Cells[1].Value.ToString();
            textBoxDiaChiHS.Text = row.Cells[2].Value.ToString();
            comboBoxGTHS.SelectedItem = row.Cells[3].Value.ToString();
            string[] NS = row.Cells[4].Value.ToString().Split(' ');
            string[] ns = NS[0].Split('/');
            string nshs = ns[0] + "-" + ns[1] + "-" + ns[2];
            textBoxNSHS.Text = nshs; 
            textBoxGhiChuHS.Text = row.Cells[5].Value.ToString();
            comboBoxMaLop.SelectedValue = row.Cells[6].Value.ToString();
        }

        private void buttonHuyHS_Click(object sender, EventArgs e)
        {
            buttonThemHS.Enabled = true;
            buttonLuuHS.Enabled = false;
            buttonHuyHS.Enabled = false;
            buttonXoaHS.Enabled = false;
            textBoxTenHS.Text = "";
            textBoxNSHS.Text = "";
            comboBoxGTHS.SelectedItem = "Nam";
            textBoxDiaChiHS.Text = "";
            textBoxGhiChuHS.Text = "";
            comboBoxMaLop.SelectedValue = "A1";
        }

        private void dataGridViewGiaoVien_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttonThemGV.Enabled = false;
            buttonLuuGV.Enabled = true;
            buttonHuyGV.Enabled = true;
            buttonXoaGV.Enabled = true;
            int index = e.RowIndex;
            DataGridViewRow row = dataGridViewGiaoVien.Rows[index];
            magv = row.Cells[0].Value.ToString();
            textBoxTenGV.Text = row.Cells[1].Value.ToString();
            string[] NS = row.Cells[2].Value.ToString().Split(' ');
            string[] ns = NS[0].Split('/');
            string nsgv = ns[0] + "-" + ns[1] + "-" + ns[2];
            textBoxNSGV.Text = nsgv;
            comboBoxGTGV.SelectedItem = row.Cells[3].Value.ToString();
            textBoxSDTGV.Text = row.Cells[4].Value.ToString();
            textBoxDiaChiGV.Text = row.Cells[5].Value.ToString();
        }

        private void buttonHuyGV_Click(object sender, EventArgs e)
        {
            buttonThemGV.Enabled = true;
            buttonLuuGV.Enabled = false;
            buttonHuyGV.Enabled = false;
            buttonXoaGV.Enabled = false;
            textBoxTenGV.Text = "";
            textBoxNSGV.Text = "";
            comboBoxGTGV.SelectedItem = "Nam";
            textBoxSDTGV.Text = "";
            textBoxDiaChiGV.Text = "";
        }

        private void buttonThemHS_Click(object sender, EventArgs e)
        {
            try
            {
                string[] str = textBoxNSHS.Text.ToString().Split('-');
                DateTime date = new DateTime(Convert.ToInt32(str[2]), Convert.ToInt32(str[1]), Convert.ToInt32(str[0]));
                bool check = con.LuuHS(textBoxTenHS.Text, textBoxDiaChiHS.Text, comboBoxGTHS.SelectedItem.ToString(), textBoxNSHS.Text, textBoxGhiChuHS.Text, comboBoxMaLop.SelectedValue.ToString());
                if (check==true)
                {
                    MessageBox.Show("Xong!");
                    DataTable data = con.GetDanhSachHocSinhDT();
                    data.Rows[data.Rows.Count - 1].Delete();
                    dataGridViewHocSinh.DataSource = null;
                    dataGridViewHocSinh.DataSource = con.ConvertHocSinh(data);
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
            }
            catch
            {
                MessageBox.Show("Nhập Sai!");
            }
        }

        private void buttonThemGV_Click(object sender, EventArgs e)
        {
            try
            {
                string[] str = textBoxNSGV.Text.ToString().Split('-');
                DateTime date = new DateTime(Convert.ToInt32(str[2]), Convert.ToInt32(str[1]), Convert.ToInt32(str[0]));
                bool check = con.LuuGV(textBoxTenGV.Text, textBoxDiaChiGV.Text, comboBoxGTGV.SelectedItem.ToString(), textBoxSDTGV.Text, textBoxNSGV.Text);
                if (check == true)
                {
                    MessageBox.Show("Xong!");
                    dataGridViewGiaoVien.DataSource = null;
                    dataGridViewGiaoVien.DataSource = con.GetDanhSachGiaoVien();
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
            }
            catch
            {
                MessageBox.Show("Nhập Sai!");
            }
        }

        private void textBoxSDTHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNSHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if(e.KeyChar == '-')
            {
                e.Handled = false;
            }
        }

        private void buttonLuuHS_Click(object sender, EventArgs e)
        {
            try
            {
                string[] str = textBoxNSHS.Text.ToString().Split('-');
                DateTime date = new DateTime(Convert.ToInt32(str[2]), Convert.ToInt32(str[1]), Convert.ToInt32(str[0]));
                bool check = con.SuaHS(mahs, textBoxTenHS.Text, textBoxDiaChiHS.Text, comboBoxGTHS.SelectedItem.ToString(), textBoxNSHS.Text, textBoxGhiChuHS.Text, comboBoxMaLop.SelectedValue.ToString());
                if (check == true)
                {
                    MessageBox.Show("Xong!");
                    DataTable data = con.GetDanhSachHocSinhDT();
                    data.Rows[data.Rows.Count - 1].Delete();
                    dataGridViewHocSinh.DataSource = null;
                    dataGridViewHocSinh.DataSource = con.ConvertHocSinh(data);
                    buttonThemHS.Enabled = true;
                    buttonLuuHS.Enabled = false;
                    buttonHuyHS.Enabled = false;
                    buttonXoaHS.Enabled = false;
                    textBoxTenHS.Text = "";
                    textBoxNSHS.Text = "";
                    comboBoxGTHS.SelectedItem = "Nam";
                    textBoxDiaChiHS.Text = "";
                    textBoxGhiChuHS.Text = "";
                    comboBoxMaLop.SelectedValue = "A1";
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
            }
            catch
            {
                MessageBox.Show("Nhập Sai!");
            }
        }

        private void buttonLuuGV_Click(object sender, EventArgs e)
        {
            try
            {
                string[] str = textBoxNSGV.Text.ToString().Split('-');
                DateTime date = new DateTime(Convert.ToInt32(str[2]), Convert.ToInt32(str[1]), Convert.ToInt32(str[0]));
                bool check = con.SuaGV(magv, textBoxTenGV.Text, textBoxDiaChiGV.Text, comboBoxGTGV.SelectedItem.ToString(), textBoxSDTGV.Text, textBoxNSGV.Text);
                if (check == true)
                {
                    MessageBox.Show("Xong!");
                    dataGridViewGiaoVien.DataSource = null;
                    dataGridViewGiaoVien.DataSource = con.GetDanhSachGiaoVien();
                    buttonThemGV.Enabled = true;
                    buttonLuuGV.Enabled = false;
                    buttonHuyGV.Enabled = false;
                    buttonXoaGV.Enabled = false;
                    textBoxTenGV.Text = "";
                    textBoxNSGV.Text = "";
                    comboBoxGTGV.SelectedItem = "Nam";
                    textBoxSDTGV.Text = "";
                    textBoxDiaChiGV.Text = "";
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
            }
            catch
            {
                MessageBox.Show("Nhập Sai!");
            }
        }

        private void buttonXoaHS_Click(object sender, EventArgs e)
        {
            try
            {
                bool check;
                check = con.XoaHS(mahs);
                if (check == true)
                {
                    MessageBox.Show("Xong!");
                    DataTable data = con.GetDanhSachHocSinhDT();
                    data.Rows[data.Rows.Count - 1].Delete();
                    dataGridViewHocSinh.DataSource = null;
                    dataGridViewHocSinh.DataSource = con.ConvertHocSinh(data);
                    buttonThemHS.Enabled = true;
                    buttonLuuHS.Enabled = false;
                    buttonHuyHS.Enabled = false;
                    buttonXoaHS.Enabled = false;
                    textBoxTenHS.Text = "";
                    textBoxNSHS.Text = "";
                    comboBoxGTHS.SelectedItem = "Nam";
                    textBoxDiaChiHS.Text = "";
                    textBoxGhiChuHS.Text = "";
                    comboBoxMaLop.SelectedValue = "A1";
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void buttonXoaGV_Click(object sender, EventArgs e)
        {
            try
            {
                bool check;
                check = con.XoaGV(magv);
                if (check == true)
                {
                    MessageBox.Show("Xong!");
                    dataGridViewGiaoVien.DataSource = null;
                    dataGridViewGiaoVien.DataSource = con.GetDanhSachGiaoVien();
                    buttonThemGV.Enabled = true;
                    buttonLuuGV.Enabled = false;
                    buttonHuyGV.Enabled = false;
                    buttonXoaGV.Enabled = false;
                    textBoxTenGV.Text = "";
                    textBoxNSGV.Text = "";
                    comboBoxGTGV.SelectedItem = "Nam";
                    textBoxSDTGV.Text = "";
                    textBoxDiaChiGV.Text = "";
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
