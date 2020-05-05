using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S4_N05_TranDucDung.DAL;
using S4_N05_TranDucDung.DTO;
using System.Data;
using System.Data.SqlClient;

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
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "XepLoai";
            command.Parameters.Add("@malop", SqlDbType.VarChar, 10).Value = maLop;
            command.Parameters.Add("@result", SqlDbType.NVarChar, 100).Direction = ParameterDirection.Output;
            return DataProvider.Instance.ExecuteNonQuery_output(command);
        }

        public string GetQuery(string malop, string makh)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "BieuMau";
            command.Parameters.Add("@malop", SqlDbType.VarChar, 10).Value = malop;
            command.Parameters.Add("@makh", SqlDbType.VarChar, 30).Value = makh;
            command.Parameters.Add("@result", SqlDbType.NVarChar, 10000).Direction = ParameterDirection.Output;
            return DataProvider.Instance.ExecuteNonQuery_output(command);
        }

        public DataTable BieuMau(string query)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            data.Columns[2].ColumnName = "AmNhac";
            data.Columns[3].ColumnName = "CongNghe";
            data.Columns[4].ColumnName = "DiaLy";
            data.Columns[5].ColumnName = "GDCD";
            data.Columns[6].ColumnName = "HoaHoc";
            data.Columns[7].ColumnName = "LichSu";
            data.Columns[8].ColumnName = "MyThuat";
            data.Columns[9].ColumnName = "SinhHoc";
            data.Columns[10].ColumnName = "Anh";
            data.Columns[11].ColumnName = "TheDuc";
            data.Columns[12].ColumnName = "Toan";
            data.Columns[13].ColumnName = "Van";
            data.Columns[14].ColumnName = "VatLy";
            return data;
        }

        public string GetGVCN(string maGVCN)
        {
            string query = "select TenGV from GiaoVien where MaGV = '" + maGVCN + "'";
            return (string)DataProvider.Instance.ExecuteScalar(query);
        }

        public string KiemTra(string malop, string mahk)
        {
            int i = (int)DataProvider.Instance.ExecuteScalar("select count(*) from ChiTietHocKy CT, TKB where CT.MaHK = '"+mahk+"' and TKB.MaMH = CT.MaMH and TKB.Malop = '"+malop+"'");
            if (i == 0)
            {
                return "Lớp chưa có môn học nào !";
            }
            else if (i == 13)
            {
                i = (int)DataProvider.Instance.ExecuteScalar(@"select count(DISTINCT MaMH) from Diem, (select MaHS from HocSinh where MaLop = '" + malop + "') as HS " +
                                                               " where Diem.MaHS = HS.MaHS " +
                                                               " and MaMH in (select CT.MaMH " +
                                                                            " from ChiTietHocKy CT, TKB " +
                                                                            " where CT.MaHK = '" + mahk + "' and TKB.MaMH = CT.MaMH and TKB.Malop = '" + malop + "')");
                if (i == 13)
                {
                    i = (int)DataProvider.Instance.ExecuteScalar("select count(distinct mahs) " +
                                                                 " from Diem, (select MaMH from TKB where Malop = '"+malop+"') as A " +
                                                                 " where Diem.MaMH = A.MaMH ");
                    if (i == (int)DataProvider.Instance.ExecuteScalar("select count(MaHS) from HocSinh where Malop = '"+malop+"'"))
                    {
                        return "done";
                    }
                    else
                    {
                        return "Lớp có học sinh chưa đủ điểm !";
                    }
                }else return "Lớp chưa đủ điểm !";
            }
            else return "Lớp chưa đủ môn học !";
        }

        public List<string> DanhSachXuat()
        {
            List<string> hks = GetDanhSachMaHK();
            List<string> mls = GetDanhSachMaLop();

            List<string> s = new List<string>();

            foreach(string item in hks)
            {
                foreach(string temp in mls)
                {
                    int i = (int)DataProvider.Instance.ExecuteScalar("select count(*) from ChiTietHocKy CT, TKB where CT.MaHK = '" + item + "' and TKB.MaMH = CT.MaMH and TKB.Malop = '" + temp + "'");
                    if (i == 13)
                    {
                        string str = temp +" "+ item;
                        s.Add(str);
                    }
                }
            }
            return s;
        }
        //nghiepvu
        public List<string> GetSoBanXuat()
        {
            List<string> hks = GetDanhSachMaHK();
            List<string> mls = GetDanhSachMaLop();

            List<string> s = new List<string>();
            int du = 0;
            int thieu = 0;
            int khongco = 0;

            foreach (string item in hks)
            {
                foreach (string temp in mls)
                {
                    string str = KiemTra(temp, item);
                    if (str == "done")
                    {
                        du++;
                    }
                    else if (str == "Lớp chưa đủ điểm !" || str == "Lớp có học sinh chưa đủ điểm !")
                    {
                        thieu++;
                    }
                    else khongco++;
                }
            }
            s.Add(du.ToString());
            s.Add(thieu.ToString());
            s.Add(khongco.ToString());
            return s;
        }

        public DataTable GetDiem(string malop, string mahs, string mamh, string makh)
        {
            DataTable data = new DataTable();
            if(malop == "None" && mahs == "None" && makh == "None" && mamh == "None")
            {
                data = DataProvider.Instance.ExecuteQuery("select ROW_NUMBER() OVER(ORDER BY TenHocSinh ASC) as STT, TenHocSinh, TenMH, HeSo, Diem, TenLop, MaHK " +
                                                            "from Diem, HocSinh, MonHoc, Lop where Diem.MaHS = HocSinh.MaHS and Diem.MaMH = MonHoc.MaMH and lop.MaLop=HocSinh.MaLop");
            }
            else
            {
                string congmalop ;
                string congmahs ;
                string congmamh ;
                string congmakh ;
                if (malop != "None")
                {
                    congmalop = " and HocSinh.MaLop = '" + malop + "' ";
                }
                else
                {
                    congmalop = " ";
                }
                if (mahs != "None")
                {
                    congmahs = " and HocSinh.MaHS = '" + mahs + "' ";
                }
                else
                {
                    congmahs = " ";
                }
                if (mamh != "None")
                {
                    congmamh = " and Diem.MaMH = '" + mamh + "' ";
                }
                else
                {
                    congmamh = " ";
                }
                if (makh != "None")
                {
                    congmakh = " and Diem.MaHK = '" + makh + "' ";
                }
                else
                {
                    congmakh = " ";
                }
                string query = ("select ROW_NUMBER() OVER(ORDER BY TenHocSinh ASC) as STT, TenHocSinh, TenMH, HeSo, Diem, TenLop, MaHK from Diem, HocSinh, MonHoc, Lop " +
                                "where Diem.MaHS = HocSinh.MaHS and Diem.MaMH = MonHoc.MaMH and lop.MaLop=HocSinh.MaLop " 
                                + congmahs + congmalop + congmamh + congmakh);
                data = DataProvider.Instance.ExecuteQuery(query);
            }
            data.Columns[0].ColumnName = "STT";
            data.Columns[1].ColumnName = "Tên HS";
            data.Columns[2].ColumnName = "Tên MH";
            data.Columns[3].ColumnName = "Hệ Số";
            data.Columns[4].ColumnName = "Điểm";
            data.Columns[5].ColumnName = "Tên Lớp";
            data.Columns[6].ColumnName = "Tên HK";
            return data;
        }
        public DataTable GetBangDiem(string malop, string mahs, string mamh, string makh)
        {
            DataTable data = new DataTable();
            if (malop == "None" && mahs == "None" && makh == "None" && mamh == "None")
            {
                data = DataProvider.Instance.ExecuteQuery("select ROW_NUMBER() OVER(ORDER BY TenHocSinh ASC) as STT, TenHocSinh, TenMH, ROUND(DiemTb, 1) DiemTb, XepLoai,MaHK"
                                                            +" from BangDiem, HocSinh, MonHoc, ChiTietHocKy "+
                                                            " where HocSinh.MaHS = BangDiem.MaHS and MonHoc.MaMH = BangDiem.MaMH and MonHoc.MaMH = ChiTietHocKy.MaMH");
            }
            else
            {
                string congmalop;
                string congmahs;
                string congmamh;
                string congmakh;
                if (malop != "None")
                {
                    congmalop = " and HocSinh.MaLop = '" + malop + "' ";
                }
                else
                {
                    congmalop = " ";
                }
                if (mahs != "None")
                {
                    congmahs = " and BangDiem.MaHS = '" + mahs + "' ";
                }
                else
                {
                    congmahs = " ";
                }
                if (mamh != "None")
                {
                    congmamh = " and MonHoc.MaMH = '" + mamh + "' ";
                }
                else
                {
                    congmamh = " ";
                }
                if (makh != "None")
                {
                    congmakh = " and ChiTietHocKy.MaHK = '" + makh + "' ";
                }
                else
                {
                    congmakh = " ";
                }
                string query = ("select ROW_NUMBER() OVER(ORDER BY TenHocSinh ASC) as STT, TenHocSinh, TenMH, ROUND(DiemTb, 1) DiemTb, XepLoai,MaHK"
                                 + " from BangDiem, HocSinh, MonHoc, ChiTietHocKy " +
                                  " where HocSinh.MaHS = BangDiem.MaHS and MonHoc.MaMH = BangDiem.MaMH and MonHoc.MaMH = ChiTietHocKy.MaMH"
                                + congmahs + congmalop + congmamh + congmakh);
                data = DataProvider.Instance.ExecuteQuery(query);
            }
            data.Columns[0].ColumnName = "STT";
            data.Columns[1].ColumnName = "Tên HS";
            data.Columns[2].ColumnName = "Tên MH";
            data.Columns[3].ColumnName = "Điểm TB";
            data.Columns[4].ColumnName = "Xếp Loại";
            data.Columns[5].ColumnName = "Tên HK";
            return data;
        }

        public List<MonHoc> ConvertMonHoc(DataTable datatable)
        {
            List<MonHoc> mhs = new List<MonHoc>();
            mhs = (from DataRow dr in datatable.Rows
                   select new MonHoc()
                   {
                       MaMH = dr["MaMH"].ToString(),
                       TenMH = dr["TenMH"].ToString(),
                       SoTiet = (int)dr["SoTiet"]
                    }).ToList();
            return mhs;
        }
        public List<MonHoc> GetDanhSachMonHoc()
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("select * from MonHoc");
            return ConvertMonHoc(data);
        }

        public DataTable GetDanhSachMonHocDT()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from MonHoc");
            data.Rows.Add(new Object[] { "None", "None", 0 });
            return data;
        }
        public DataTable GetDanhSachLopDT()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Lop");
            data.Rows.Add(new Object[] { "None", "None", "None", "None" });
            return data;
        }
        public DataTable GetDanhSachHocSinhDT()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from HocSinh");
            data.Rows.Add(new Object[] { "None", "None", "None", "1700-01-01", "None", "None", "None" });
            return data;
        }
        public List<string> GetDanhSachMonHocTrongLop(string malop, string mahk)
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("select TKB.MaMh from TKB, ChiTietHocKy where TKB.MaLop = '"+ malop +"' and TKB.MaMH = ChiTietHocKy.MaMH and ChiTietHocKy.MaHK = '"+ mahk +"'");
            return ConvertString(data);
        }
        public List<string> GetDanhSachHocSinhTrongLop(string malop)
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("select MaHS from HocSinh where MaLop = '"+malop+"'");
            return ConvertString(data);
        }
        public bool LuuDiem(string MaHS, string MaMh, int HeSo, float Diem, string MaLop, string MaHK)
        {
            List<string> ls = GetDanhSachMonHocTrongLop(MaLop, MaHK);
            List<string> ms = GetDanhSachHocSinhTrongLop(MaLop);
            foreach (string item in ls)
            {
                if(item == MaMh)
                {
                    foreach(string temp in ms)
                    {
                        string s = ((int)DataProvider.Instance.ExecuteScalar("select max(MaDiem) from Diem") + 1).ToString();
                        string query = "ThemDiem " + s + ", " + HeSo + ", " + Diem + ", '" + MaHS + "', '" + MaMh + "', '" + MaHK + "'";
                        DataProvider.Instance.ExecuteNonQuery(query);
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
        //danh muc
        public List<HocSinh> ConvertHocSinh(DataTable datatable)
        {
            List<HocSinh> hks = new List<HocSinh>();
            hks = (from DataRow dr in datatable.Rows
                   select new HocSinh()
                   {
                       MaHS = dr["MaHS"].ToString(),
                       TenHS = dr["TenHocSinh"].ToString(),
                       GioiTinh = dr["GioiTinh"].ToString(),
                       Ngaysinh = dr["NgaySinh"].ToString(),
                       DiaChi = dr["DiaChi"].ToString(),
                       GhiChu = dr["GhiChu"].ToString(),
                       MaLop = dr["MaLop"].ToString(),
                   }).ToList();
            return hks;
        }
        public List<GiaoVien> ConvertGiaoVien(DataTable datatable)
        {
            List<GiaoVien> hks = new List<GiaoVien>();
            hks = (from DataRow dr in datatable.Rows
                   select new GiaoVien()
                   {
                       MaGV = dr["MaGV"].ToString(),
                       TenGV = dr["TenGV"].ToString(),
                       GioiTinh = dr["GioiTinh"].ToString(),
                       NgaySinh = Convert.ToDateTime(dr["NgaySinh"]),
                       DiaChi = dr["DiaChi"].ToString(),
                       SDT = dr["SDT"].ToString(),
                   }).ToList();
            return hks;
        }
        public List<GiaoVien> GetDanhSachGiaoVien()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from GiaoVien");
            return ConvertGiaoVien(data);
        }
        public bool LuuHS(string tenHS, string diaChi, string gioiTinh, string ngaysinh, string ghiChu, string maLop)
        {
            try
            {
                int num = (int)DataProvider.Instance.ExecuteScalar("select count(MaHS) from HocSinh") + 1;
                string s = "ThemHS 'HS" + num + "', '" + tenHS + "', '" + gioiTinh + "', '" + ngaysinh + "', '" + diaChi + "', '" + ghiChu + "', '" + maLop + "'";
                DataProvider.Instance.ExecuteNonQuery(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool LuuGV(string tenGV, string diachi, string gioiTinh, string sDT, string ngaySinh)
        {
            try
            {
                int num = (int)DataProvider.Instance.ExecuteScalar("select count(MaGV) from GiaoVien") + 1;
                string s = "ThemGV '" + num + "', '" + tenGV + "', '" + ngaySinh + "', '" + gioiTinh + "', '" + sDT + "', '" + diachi + "'";
                DataProvider.Instance.ExecuteNonQuery(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaHS(string mahs, string tenHS, string diaChi, string gioiTinh, string ngaysinh, string ghiChu, string maLop)
        {
            try
            {
                string s = "update hocsinh set TenHocSinh = N'"+tenHS+"' , NgaySinh = '"+ngaysinh+"', DiaChi = N'"+diaChi+"' , GioiTinh = N'"+gioiTinh+"' , GhiChu = N'"+ghiChu+"' , MaLop = '"+maLop+"' where MaHS = '"+mahs+"'";
                DataProvider.Instance.ExecuteNonQuery(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaGV(string magv, string tenGV, string diachi, string gioiTinh, string sDT, string ngaySinh)
        {
            try
            {
                string s = "update giaovien set TenGV = N'" + tenGV + "', NgaySinh ='" + ngaySinh + "', GioiTinh = N'" + gioiTinh + "', SDT = '" + sDT + "', DiaChi =N'" + diachi + "' where MaGV ='"+magv+"'";
                DataProvider.Instance.ExecuteNonQuery(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaHS(string mahs)
        {
            try
            {
                string s = "delete from Diem where MaHS = '"+mahs+"'";
                DataProvider.Instance.ExecuteNonQuery(s);
                s = "delete from BangDiem where MaHS = '" + mahs + "'";
                DataProvider.Instance.ExecuteNonQuery(s);
                s = "delete from PhuHuynh where MaHS = '" + mahs + "'";
                DataProvider.Instance.ExecuteNonQuery(s);
                s = "delete from HocSinh where MaHS = '" + mahs + "'";
                DataProvider.Instance.ExecuteNonQuery(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaGV(string magv)
        {
            try
            {
                string s = "delete from GiangDay where MaGV = '" + magv + "'";
                DataProvider.Instance.ExecuteNonQuery(s);
                s = "delete from PhanCong where MaGV = '" + magv + "'";
                DataProvider.Instance.ExecuteNonQuery(s);
                s = "update Lop set MaGVCN = null where MaGVCN = '" + magv + "'";
                DataProvider.Instance.ExecuteNonQuery(s);
                s = "delete from GiaoVien where MaGV = '" + magv + "'";
                DataProvider.Instance.ExecuteNonQuery(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
