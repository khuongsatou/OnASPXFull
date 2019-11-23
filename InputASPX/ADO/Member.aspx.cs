using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InputASPX.ADO
{
    public partial class Member : System.Web.UI.Page
    {
        DataProvider data = new DataProvider();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SelectReader();
                SelectAdapter();
                SelectScalar();
            }
            else     
            {
                txtUserName.Text = "";
            }
        }

        protected void ClickBtnUpdate(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdUp.Text.Trim());
            string userName = txtUserNameUp.Text.Trim();
            string passWord = txtPassWordUp.Text.Trim();
            lblErrorUp.Visible = true;

            if (userName.Equals(""))
            {
                lblErrorUp.Text = "Bạn chưa nhập User";
                txtUserName.Focus();
                return;
            }
            if (passWord.Equals(""))
            {
                lblErrorUp.Text = "Bạn chưa nhập Pass";
                txtPassWord.Focus();
                return;
            }
            lblErrorUp.Text = data.UpdateUseExeNonquery(id, userName, passWord).ToString();
            restartPage();

        }

        private void restartPage()
        {
            SelectReader();
        }

        protected void ClickBtnInsert(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string passWord = txtPassWord.Text.Trim();
            lblError.Visible = true;
            if (userName.Equals(""))
            {
                lblError.Text = "Bạn chưa nhập User";
                txtUserName.Focus();
                return;
            }
            if (passWord.Equals(""))
            {
                lblError.Text = "Bạn chưa nhập Pass";
                txtPassWord.Focus();
                return;
            }
            lblError.Text = data.InsertUseExeNonquery(userName, passWord).ToString();
            restartPage();
        }

        protected void ClickBtnDelete(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDDelete.Text.Trim());
            lblDeletePara.Visible = true;
            lblDeletePara.Text = data.DeleteUseExeNonquery(id).ToString();
           
            restartPage();
        }

        protected void ClickBtnDeletePara(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDDelete.Text.Trim());
            lblErrorDelete.Visible = true;
            lblErrorDelete.Text = data.DeleteUseExeNonqueryParam(id).ToString();

            restartPage();
        }

        private void SelectScalar()
        {
            lblScalar.Text = data.SelectUseExeScalar().ToString();
        }

        private void SelectAdapter()
        {
            lblAdapter.Text = data.SelectUseExeAdapter();
        }

        private void SelectReader()
        {
            lblReader.Text = data.SelectUseExeReader();
        }
    }
}