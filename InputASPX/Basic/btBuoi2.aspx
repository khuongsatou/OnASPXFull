<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="btBuoi2.aspx.cs" Inherits="InputASPX.btBuoi2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="lblResult" runat="server">
            UserName: <asp:TextBox ID="txtUser" runat="server" />
            <br />
            PassWord: <asp:TextBox ID="txtPass" runat="server"
                TextMode="Password" />
            <br />
            <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="ClickBtnLogin"/>
               
        </div>
    </form>
</body>
</html>
