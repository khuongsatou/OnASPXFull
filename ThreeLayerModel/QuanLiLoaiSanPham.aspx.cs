using BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThreeLayerModel
{
    public partial class QuanLiLoaiSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //gửi lên server, binding khi chạy lần đầu tiên, 
            if (!Page.IsPostBack)
            {
                grvLoaiSanPham.DataSource = LoaiSanPhamBUS.LayDSLoaiSanPham();
                //cho nó gắn vào các column như cột bên dưới grid không có nó sẽ không hiện
                grvLoaiSanPham.DataBind();
            }
           
        }
        protected void BtnThem_Click(object sender, EventArgs e)
        {
            string maLoaiSP = txtMaLoaiSP.Text;
            string tenLoaiSP = txtTenLoaiSP.Text;
            bool trangThai = cbTrangThai.Checked;
            if (LoaiSanPhamBUS.ThemLoaiSanPham(maLoaiSP,tenLoaiSP,trangThai))
            {
                grvLoaiSanPham.DataSource = LoaiSanPhamBUS.LayDSLoaiSanPham();
                grvLoaiSanPham.DataBind();
            }
            else
            {
                Response.Write("<script> alert('Thêm Thất Bại') </script>");
            }
        }

       

        protected void BtnSua_Click(object sender,EventArgs e)
        {
            string maLoaiSP = txtMaLoaiSP.Text;
            string tenLoaiSP = txtTenLoaiSP.Text;
            bool trangThai = cbTrangThai.Checked;

            if (LoaiSanPhamBUS.SuaLoaiSanPham(maLoaiSP,tenLoaiSP,trangThai))
            {
                //Select Lại
                grvLoaiSanPham.DataSource = LoaiSanPhamBUS.LayDSLoaiSanPham();
                grvLoaiSanPham.DataBind();

                txtMaLoaiSP.Text = string.Empty;
                txtTenLoaiSP.Text = string.Empty;
                cbTrangThai.Checked = true;
                txtMaLoaiSP.Enabled = true;
            }
            else
            {
                Response.Write("<script> alert('Thêm Thất Bại') </script>");
            }
        }

       

        protected void grvLoaiSanPham_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ChonSP")
            {
                string maLoaiSP = e.CommandArgument.ToString();
                DataRow dr = LoaiSanPhamBUS.LayDSLoaiSanPham(maLoaiSP);
                if (dr != null)
                {
                    txtMaLoaiSP.Text = dr["MaLoaiSP"].ToString();
                    txtTenLoaiSP.Text = dr["TenLoaiSP"].ToString();
                    cbTrangThai.Checked = Convert.ToBoolean(dr["TrangThai"]);
                    txtMaLoaiSP.Enabled = false;
                }
            }
           if(e.CommandName == "XoaSP")
            {
                string maLoaiSP = e.CommandArgument.ToString();
                if (LoaiSanPhamBUS.XoaLoaiSanPham(maLoaiSP))
                {
                    grvLoaiSanPham.DataSource = LoaiSanPhamBUS.LayDSLoaiSanPham();
                    grvLoaiSanPham.DataBind();
                }
                else
                {

                }
            }
        }


    }
}