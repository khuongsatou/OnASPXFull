using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiSanPhamDAO
    {
        public static DataTable LayDSLoaiSanPham()
        {
            string query = "SELECT * FROM LoaiSanPham";
            SqlParameter[] param = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, param);

        }

        public static bool ThemLoaiSanPham(string maLoaiSP,string tenLoaiSP,bool trangThai)
        {
            string query = "INSERT INTO LoaiSanPham(MaloaiSP,TenLoaiSP,TrangThai) VALUES(@MaLoaiSP,@TenLoaiSP,@TrangThai)";
            SqlParameter[] param = new SqlParameter[3];
            param[0] =  new SqlParameter("@MaLoaiSP", maLoaiSP);
            param[1] = new SqlParameter("@TenLoaiSP", tenLoaiSP);
            param[2] = new SqlParameter("@TrangThai", trangThai);
            return DataProvider.ExecuteInsertQuery(query, param) == 1;
        }

        public static bool KTMaLoaiSanPhamTonTai(string maLoaiSP)
        {
            string query = "SELECT COUNT(*) FROM LoaiSanPham WHERE MaLoaiSP = @MaloaiSP";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
          
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }

        public static DataRow LayLoaiSanPham(string maLoaiSP)
        {
            string query = "SELECT * FROM LoaiSanPham WHERE MaLoaiSP = @MaLoaiSP";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
            return DataProvider.ExecuteSelectQuery(query, param).Rows[0];
        }
        public static bool SualoaiSanPham(string maLoaiSP, string tenLoaiSP, bool TrangThai)
        {
            string query = "Update LoaiSanPham SET TenLoaiSP =@TenLoaiSP,TrangThai =@TrangThai WHERE MaLoaiSP = @MaLoaiSP";
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
            param[1] = new SqlParameter("@TenLoaiSP", tenLoaiSP);
            param[2] = new SqlParameter("@TrangThai", TrangThai);
            return DataProvider.ExecuteUpdateQuery(query, param) == 1;
        }
        public static bool XoaLoaiSanPham(string maLoaiSP)
        {
            string query = "UPDATE LoaiSanPham SET TrangThai =0 WHERE MaLoaiSP = @MaLoaiSP";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
            return DataProvider.ExecuteDeleteQuery(query, param) == 1;
        }

    }
}
