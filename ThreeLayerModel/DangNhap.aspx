<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="ThreeLayerModel.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Tên Tài Khoản:</td>
                    <td><asp:TextBox runat="server" ID ="txtTenTaiKhoan" /></td>
                </tr>
                <tr>
                    <td> Mật Khẩu</td>
                    <td><asp:TextBox runat="server" ID ="txtMatKhau" /></td>
                </tr>
                  <tr>
                    <td></td>
                    <td>
                        <asp:Button runat="server" ID="btnDangNhap" Text="Đăng Nhập" OnClick="ClickBtnDangNhap" />
                        <asp:Button runat="server" ID="btnHuyBo" Text="Hủy Bỏ" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
