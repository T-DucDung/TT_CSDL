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
    }
}
