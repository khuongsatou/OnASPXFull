using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
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

        public static bool Them(TaiKhoanDTO tk)
        {
            string query = "INSERT INTO [dbo].[TaiKhoan] ([TenTaiKhoan] ,[MatKhau] ,[Email] ,[SDT] ,[DiaChi] ,[HoTen], LaAdmin,AnhDaiDien,TrangThai ) VALUES (@TenTaiKhoan ,@MatKhau,@Email,@SDT,@DiaChi,@HoTen,@LaAdmin,@AnhDaiDien,@TrangThai)";
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@TenTaiKhoan", tk.TenTaiKhoan);
            param[1] = new SqlParameter("@MatKhau", tk.MatKhau);
            param[2] = new SqlParameter("@Email", tk.Email);
            param[3] = new SqlParameter("@SDT", tk.Sdt);
            param[4] = new SqlParameter("@DiaChi", tk.DiaChi);
            param[5] = new SqlParameter("@HoTen", tk.HoTen);
            param[6] = new SqlParameter("@LaAdmin", tk.LaAdmin);
            param[7] = new SqlParameter("@AnhDaiDien", tk.AnhDaiDien);
            param[8] = new SqlParameter("@TrangThai", tk.TrangThai);
           
            return DataProvider.ExecuteInsertQuery(query, param) == 1;
        }

        public static List<TaiKhoanDTO> LayDSTaiKHoan()
        {
            string query = "SELECT * FROM TaiKhoan";
            SqlParameter [] param = new SqlParameter[0];
            DataTable dtbTaiKhoan = DataProvider.ExecuteSelectQuery(query, param);
            List<TaiKhoanDTO> lstTaiKhoan = new List<TaiKhoanDTO>();
            foreach (DataRow dr in dtbTaiKhoan.Rows)
            {
                lstTaiKhoan.Add(ConvertToDTO(dr));
            }
            return lstTaiKhoan;
        }

        public static TaiKhoanDTO LayThongTinTaiKhoan(string tenTK)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return ConvertToDTO(DataProvider.ExecuteSelectQuery(query, param).Rows[0]);
        }

        public static TaiKhoanDTO ConvertToDTO(DataRow dr)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenTaiKhoan = dr["TenTaiKhoan"].ToString();
            tk.MatKhau = dr["TenTaiKhoan"].ToString();
            tk.Email = dr["SDT"].ToString();
            tk.DiaChi = dr["DiaChi"].ToString();
            tk.HoTen = dr["HoTen"].ToString();
            tk.LaAdmin =Convert.ToBoolean(dr["LaAdmin"].ToString());
            tk.AnhDaiDien = dr["AnhDaiDien"].ToString();
            tk.TrangThai =Convert.ToBoolean(dr["TrangThai"].ToString());
            return tk;

        }

    }
}
