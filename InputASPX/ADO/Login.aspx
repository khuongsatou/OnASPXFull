<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="InputASPX.ADO.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            UserName:<asp:Textbox ID="txtUserName" runat="server"/><br />
            PassWord:<asp:Textbox ID="txtPassWord" runat="server"/><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="ClickBtnLogin" />
        </div>
    </form>
</body>
</html>
