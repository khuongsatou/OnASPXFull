using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;

namespace ThreeLayerModel
{
    public partial class DangKi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ClickBtnDangKi(object sender, EventArgs e)
        {
            string tenTaiKhoan = txtTenTaiKhoan.Text.ToString();
            string matKhau = txtMatKhau.Text.ToString();
            string email = txtEmail.Text.ToString();
            string sdt = txtSDT.Text.ToString();
            string diaChi = txtDiaChi.Text.ToString();
            string hoTen = txtHoTen.Text.ToString();
            if (TaiKhoanBUS.KTDangKi(tenTaiKhoan, matKhau,email,sdt,diaChi,hoTen))
            {
                Response.Write("<script> alert('Thêm Thành Công'); </script>");
            }
            else
            {
                Response.Write("<script> alert('Thêm Thất Bại'); </script>");
            }
        }
    }
}