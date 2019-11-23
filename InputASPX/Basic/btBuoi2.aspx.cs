using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InputASPX
{
    public partial class btBuoi2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                lblResult.Visible = false;
            }
        }

        protected void ClickBtnLogin(object sender, EventArgs e)
        {
            Response.Write("UserName:" + txtUser.Text.ToString() + "<br/> PassWord:" + txtPass.Text.ToString());
        }


    }
}