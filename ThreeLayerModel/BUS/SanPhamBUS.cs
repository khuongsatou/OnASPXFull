using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamBUS
    {
        public static List<SanPhamDTO> layDSSanPham()
        {
            return SanPhamDAO.layDSSanPham();
        }

        public static List<SanPhamDTO> layDSSanPham(string maLoaiSP)
        {
            return SanPhamDAO.layDSSanPham(maLoaiSP);
        }

    }
}
