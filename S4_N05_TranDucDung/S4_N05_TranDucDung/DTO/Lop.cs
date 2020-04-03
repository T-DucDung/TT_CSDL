using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_N05_TranDucDung.DTO
{
    class Lop
    {
        private string maLop;
        private string tenLop;
        private string nienKhoa;
        private string maGVCN;

        public Lop()
        {
            this.maLop = "";
            this.tenLop = "";
            this.nienKhoa = "";
            this.maGVCN = "";
        }
        public Lop(string maLop, string tenLop, string nienKhoa, string maGVCN)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.nienKhoa = nienKhoa;
            this.maGVCN = maGVCN;
        }

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string NienKhoa { get => nienKhoa; set => nienKhoa = value; }
        public string MaGVCN { get => maGVCN; set => maGVCN = value; }
    }
}
