using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiSanPhamBUS
    {
        public static DataTable LayDSLoaiSanPham()
        {
            return LoaiSanPhamDAO.LayDSLoaiSanPham();
        }

        public static DataRow LayDSLoaiSanPham(string maLoaiSP)
        {
            if(LoaiSanPhamDAO.KTMaLoaiSanPhamTonTai(maLoaiSP))
            {
                return LoaiSanPhamDAO.LayLoaiSanPham(maLoaiSP);
            }
            else
            {
                return null;
            }
          
        }


        public static bool ThemLoaiSanPham(string maLoaiSP,string tenLoaiSP,bool trangThai)
        {
            if (LoaiSanPhamDAO.KTMaLoaiSanPhamTonTai(maLoaiSP))
            {
                return false;
            }
            else
            {
                return LoaiSanPhamDAO.ThemLoaiSanPham(maLoaiSP, tenLoaiSP, trangThai);
            }
        }

        public static bool SuaLoaiSanPham(string maLoaiSP, string tenLoaiSP, bool trangThai)
        {
            if (LoaiSanPhamDAO.KTMaLoaiSanPhamTonTai(maLoaiSP))
            {
                return LoaiSanPhamDAO.SualoaiSanPham(maLoaiSP, tenLoaiSP, trangThai);
            }
            else 
            { 
                return false;
            }
        }

        public static bool XoaLoaiSanPham(string maLoaiSP)
        {
            if (LoaiSanPhamDAO.KTMaLoaiSanPhamTonTai(maLoaiSP))
            {
                return LoaiSanPhamDAO.XoaLoaiSanPham(maLoaiSP);
            }
            else
            {
                return false;
            }
        }


    }
}
