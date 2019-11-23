<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKi.aspx.cs" Inherits="ThreeLayerModel.DangKi" %>

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
                    <td><asp:TextBox runat="server" ID="txtTenTaiKhoan" /></td>
                </tr>
                <tr>
                    <td>Mật Khẩu</td>
                    <td><asp:TextBox runat="server" ID="txtMatKhau" /></td>
                </tr>
                 <tr>
                    <td>Email</td>
                    <td><asp:TextBox runat="server" ID="txtEmail" /></td>
                </tr>
                <tr>
                    <td>SDT</td>
                    <td><asp:TextBox runat="server" ID="txtSDT" /></td>
                </tr>
                <tr>
                    <td>Địa Chỉ</td>
                    <td><asp:TextBox runat="server" ID="txtDiaChi" /></td>
                </tr>
                <tr>
                    <td>Họ Tên</td>
                    <td><asp:TextBox runat="server" ID="txtHoTen" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button runat="server" ID="btnDangKi" Text="Đăng Kí" OnClick="ClickBtnDangKi" />
                        <asp:Button runat="server" ID="btnHuyBo" Text="Hủy Bỏ" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
