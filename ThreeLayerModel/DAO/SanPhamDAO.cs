using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        public static List<SanPhamDTO> layDSSanPham()
        {
            string query = "SELECT * FROM SanPham";
            SqlParameter[] param = new SqlParameter[0];
            //mảng 2 chiều
            DataTable dtbKetQua = DataProvider.ExecuteSelectQuery(query, param);
            List<SanPhamDTO> lstSanPham = new List<SanPhamDTO>();
            //lấy ra mảng 1 chiều
            foreach (DataRow dr in dtbKetQua.Rows)
            {
                lstSanPham.Add(ConvertToDTO(dr));
            }

            return lstSanPham;
        }
        //overLoad
        public static List<SanPhamDTO> layDSSanPham(string maLoaiSP)
        {
            string query = "SELECT * FROM SanPham WHERE MaLoaiSP = @MaLoaiSP";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
            //mảng 2 chiều
            DataTable dtbKetQua = DataProvider.ExecuteSelectQuery(query, param);
            List<SanPhamDTO> lstSanPham = new List<SanPhamDTO>();
            //lấy ra mảng 1 chiều
            foreach (DataRow dr in dtbKetQua.Rows)
            {
                lstSanPham.Add(ConvertToDTO(dr));
            }

            return lstSanPham;
        }

        public static SanPhamDTO ConvertToDTO(DataRow dr)
        {
            SanPhamDTO sp = new SanPhamDTO();
            sp.MaSP = dr["MaSP"].ToString();
            sp.TenSP = dr["TenSP"].ToString();
            sp.ThongTin = dr["ThongTin"].ToString();
            sp.GiaTien = Convert.ToInt32(dr["GiaTien"]);
            sp.SoLuongTonKho = Convert.ToInt32(dr["SoLuongTonKho"]);
            sp.MaLoaiSP = dr["MaLoaiSP"].ToString();
            sp.AnhMinhHoa = dr["AnhMinhHoa"].ToString();
            sp.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
            return sp;
        }
    }
}
