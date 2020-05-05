using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_N05_TranDucDung.DTO
{
    class HocSinh
    {
        private string maHS;
        private string tenHS;
        private string diaChi;
        private string gioiTinh;
        private string ngaysinh;
        private string ghiChu;
        private string maLop;

        public HocSinh()
        {
            this.maHS = "";
            this.tenHS = "";
            this.diaChi = "";
            this.gioiTinh = "";
            this.ngaysinh = "";
            this.ghiChu = "";
            this.maLop = "";
        }
        public HocSinh(string maHS, string tenHS, string diaChi, string gioiTinh, string ngaysinh, string ghiChu, string maLop)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.ngaysinh = ngaysinh;
            this.ghiChu = ghiChu;
            this.maLop = maLop;
        }

        public string MaHS { get => maHS; set => maHS = value; }
        public string TenHS { get => tenHS; set => tenHS = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string MaLop { get => maLop; set => maLop = value; }
    }
}
