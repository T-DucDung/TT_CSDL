using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S4_N05_TranDucDung.DAL;
using S4_N05_TranDucDung.DTO;
using System.Data;

namespace S4_N05_TranDucDung.BUS
{
    class Controller
    {
        public List<Lop> ConvertLop(DataTable datatable)
        {
            List<Lop> lops = new List<Lop>();
            lops = (from DataRow dr in datatable.Rows
                    select new Lop()
                    {
                        MaLop = dr["MaLop"].ToString(),
                        TenLop = dr["TenLop"].ToString(),
                        NienKhoa = dr["NienKhoa"].ToString(),
                        MaGVCN = dr["MaGVCN"].ToString()
                    }).ToList();
            return lops;
        }
        public List<HocKy> ConvertHocKy(DataTable datatable)
        {
            List<HocKy> hks = new List<HocKy>();
            hks = (from DataRow dr in datatable.Rows
                    select new HocKy()
                    {
                        MaHK = dr["MaHK"].ToString(),
                        NamHoc = dr["NamHoc"].ToString(),
                    }).ToList();
            return hks;
        }
        public List<string> ConvertString(DataTable datatable)
        {
            List<string> strs = new List<string>();
            foreach (DataRow dr in datatable.Rows)
            {
                strs.Add(dr[0].ToString());
            }
            return strs;
        }

        public List<Lop> GetDanhSachLop()
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("select * from Lop");
            return ConvertLop(data); 
        }

        public List<string> GetDanhSachMaLop()
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("select MaLop from Lop");
            return ConvertString(data);
        }

        public List<HocKy> GetDanhHocKy()
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("select * from HocKy");
            return ConvertHocKy(data);
        }

        public List<string> GetDanhSachMaHK()
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("select MaHK from HocKy");
            return ConvertString(data);
        }

        public string GetXepLoai(string maLop)
        {
            return DataProvider.Instance.ExecuteNonQuery_output("XepLoai", maLop);
        }

        public string GetGVCN(string maGVCN)
        {
            string query = "select TenGV from GiaoVien where MaGV = '" + maGVCN + "'";
            return (string)DataProvider.Instance.ExecuteScalar(query);
        }
    }
}
