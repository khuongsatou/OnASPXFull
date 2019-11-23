using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThreeLayerModel
{
    public partial class QuanLiSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                rptSanPham.DataSource = SanPhamBUS.layDSSanPham();
                rptSanPham.DataBind();

                ddlSanPham.DataSource = SanPhamBUS.layDSSanPham();
                ddlSanPham.DataTextField = "TenSP";
                ddlSanPham.DataValueField = "MaLoaiSP";
                ddlSanPham.AutoPostBack = true;
                ddlSanPham.DataBind();
            }
        }

        protected void ddlSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLoaiSP = ddlSanPham.SelectedValue;
            rptSanPham.DataSource = SanPhamBUS.layDSSanPham(maLoaiSP);
            rptSanPham.DataBind();
        }
    }
}