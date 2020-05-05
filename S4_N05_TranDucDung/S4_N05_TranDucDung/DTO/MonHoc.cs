using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_N05_TranDucDung.DTO
{
    class MonHoc
    {
        private string maMH;
        private string tenMH;
        private int soTiet;

        public MonHoc()
        {
            this.maMH = "";
            this.tenMH = "";
            this.soTiet = 0;
        }
        public MonHoc(string maMon, string tenMon, int soTiet)
        {
            this.maMH = maMon;
            this.tenMH = tenMon;
            this.soTiet = soTiet;
        }

        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public int SoTiet { get => soTiet; set => soTiet = value; }
    }
}
