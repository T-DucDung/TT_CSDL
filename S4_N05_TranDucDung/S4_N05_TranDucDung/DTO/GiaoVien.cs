using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_N05_TranDucDung.DTO
{
    class GiaoVien
    {
        private string maGV;
        private string tenGV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string sDT;
        private string diaChi;

        public GiaoVien()
        {
            this.maGV = "";
            this.tenGV = "";
            this.ngaySinh = new DateTime(1950, 01, 01);
            this.gioiTinh = "";
            this.sDT = "";
            this.diaChi = "";
        }
        public GiaoVien(string maGV, string tenGV, DateTime ngaySinh, string gioiTinh, string sDT, string diaChi)
        {
            this.maGV = maGV;
            this.tenGV = tenGV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.sDT = sDT;
            this.diaChi = diaChi;
        }

        public string MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
