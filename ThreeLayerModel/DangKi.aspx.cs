using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace ThreeLayerModel
{
    public partial class DangKi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                grvDSTaiKhoan.DataSource = TaiKhoanBUS.LayDSTaiKhoan();
                grvDSTaiKhoan.DataBind();
            }
        }
        protected void ClickBtnDangKi(object sender, EventArgs e)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenTaiKhoan = txtTenTaiKhoan.Text.ToString();
            tk.MatKhau = txtMatKhau.Text.ToString();
            tk.Email = txtEmail.Text.ToString();
            tk.Sdt = txtSDT.Text.ToString();
            tk.DiaChi = txtDiaChi.Text.ToString();
            tk.HoTen = txtHoTen.Text.ToString();
            if (TaiKhoanBUS.KTDangKi(tk))
            {
                grvDSTaiKhoan.DataSource = TaiKhoanBUS.LayDSTaiKhoan();
                grvDSTaiKhoan.DataBind();
                //Response.Write("<script> alert('Thêm Thành Công'); </script>");
            }
            else
            {
                Response.Write("<script> alert('Thêm Thất Bại'); </script>");
            }
        }

        protected void grvDSTaiKhoan_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "btnChon")
            {
                string tenTK = e.CommandArgument.ToString();
                TaiKhoanDTO tk = TaiKhoanBUS.LayThongTinTaiKhoan(tenTK);
                if (tk != null)
                {
                    txtTenTaiKhoan.Text = tk.TenTaiKhoan;
                    txtMatKhau.Text = tk.MatKhau;
                    txtEmail.Text = tk.Email;
                    txtSDT.Text = tk.Sdt;
                    txtDiaChi.Text = tk.DiaChi;
                    txtHoTen.Text = tk.HoTen;
                    

                }
            }
        }
    }
}