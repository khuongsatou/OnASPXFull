using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThreeLayerModel
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ClickBtnDangNhap(object sender,EventArgs e)
        {
            string tenTK = txtTenTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            if (TaiKhoanBUS.KTDangNhap(tenTK, mk))
            {
                Response.Write("<script>alert('Đăng Nhập Thành Công');</script>");
            }
            else
            {
                Response.Write("<script>alert('Đăng Nhập Thất Bại');</script>");
            }
        }
    }
}