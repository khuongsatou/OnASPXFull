using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        public static bool KTTKTonTai(string tenTK)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan =@TenTaiKhoan ";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }

        public static string LayMatKhau(string tenTK)
        {
            string query = "SELECT MatKhau FROM TaiKhoan WHERE TenTaiKhoan =@TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return DataProvider.ExecuteSelectQuery(query, param).Rows[0][0].ToString();
        }

        public static bool Them(string tenTK, string mk, string email, string sdt,string diaChi, string hoTen)
        {
            string query = "INSERT INTO [dbo].[TaiKhoan] ([TenTaiKhoan] ,[MatKhau] ,[Email] ,[SDT] ,[DiaChi] ,[HoTen]) VALUES (@TenTaiKhoan ,@MatKhau,@Email,@SDT,@DiaChi,@HoTen)";
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            param[1] = new SqlParameter("@MatKhau", mk);
            param[2] = new SqlParameter("@Email", email);
            param[3] = new SqlParameter("@SDT", sdt);
            param[4] = new SqlParameter("@DiaChi", diaChi);
            param[5] = new SqlParameter("@HoTen", hoTen);
           
            return DataProvider.ExecuteInsertQuery(query, param) == 1;
        }

    }
}
