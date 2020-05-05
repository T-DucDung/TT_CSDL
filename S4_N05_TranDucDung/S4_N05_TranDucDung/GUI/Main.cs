using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S4_N05_TranDucDung
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonNV_Click(object sender, EventArgs e)
        {
            GUI.NghiepVu nv = new GUI.NghiepVu();
            this.Hide();
            nv.FormClosed += Nv_FormClosed;
            nv.Show();
        }

        private void Nv_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonDM_Click(object sender, EventArgs e)
        {
            GUI.DanhMuc dm = new GUI.DanhMuc();
            this.Hide();
            dm.FormClosed += Dm_FormClosed;
            dm.Show();
        }

        private void Dm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
