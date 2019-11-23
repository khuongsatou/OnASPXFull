using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class TaiKhoanBUS
    {
        public static bool KTDangNhap(string tenTK,string mk)
        {
            if (!TaiKhoanDAO.KTTKTonTai(tenTK))
            {
                return false;
            }
            else
            {
                return mk == TaiKhoanDAO.LayMatKhau(tenTK);
            }
        }

        public static bool KTDangKi(TaiKhoanDTO tk)
        {
            if (TaiKhoanDAO.KTTKTonTai(tk.TenTaiKhoan))
            {
                return false;
            }
            else
            {
                return TaiKhoanDAO.Them(tk);
            }
        }

        public static List<TaiKhoanDTO> LayDSTaiKhoan()
        {
            return TaiKhoanDAO.LayDSTaiKHoan();
        }

        public static TaiKhoanDTO LayThongTinTaiKhoan(string tenTK)
        {
            if (!TaiKhoanDAO.KTTKTonTai(tenTK))
            {
                return null;
            }
            else
            {
                return TaiKhoanDAO.LayThongTinTaiKhoan(tenTK);
            }
        }
    }
}
