using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_N05_TranDucDung.DTO
{
    class HocKy
    {
        private string maHK;
        private string namHoc;

        public HocKy()
        {
            this.maHK = "";
            this.namHoc = "";
        }
        public HocKy(string maHK, string namHoc)
        {
            this.maHK = maHK;
            this.namHoc = namHoc;
        }

        public string MaHK { get => maHK; set => maHK = value; }
        public string NamHoc { get => namHoc; set => namHoc = value; }
    }
}
