using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_N05_TranDucDung.DTO
{
    class Diem
    {
        private int maDiem;
        private int heSo;
        private float diemmh;
        private string maHs;
        private string maMh;
        private string maHk;

        public Diem()
        {
            this.maDiem = 0;
            this.heSo = 0;
            this.diemmh = 0;
            this.maHs = "";
            this.maMh = "";
            this.maHk = "";
        }
        public Diem(int maDiem, int heSo, float diemmh, string maHs, string maMh, string maHk)
        {
            this.maDiem = maDiem;
            this.heSo = heSo;
            this.diemmh = diemmh;
            this.maHs = maHs;
            this.maMh = maMh;
            this.maHk = maHk;
        }

        public int MaDiem { get => maDiem; set => maDiem = value; }
        public int HeSo { get => heSo; set => heSo = value; }
        public float Diemmh { get => diemmh; set => diemmh = value; }
        public string MaHs { get => maHs; set => maHs = value; }
        public string MaMh { get => maMh; set => maMh = value; }
        public string MaHk { get => maHk; set => maHk = value; }
    }
}
