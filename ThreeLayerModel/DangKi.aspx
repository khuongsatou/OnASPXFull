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
            <asp:GridView ID="grvDSTaiKhoan" runat="server" AutoGenerateColumns="False" DataKeyNames="TenTaiKhoan" OnRowCommand="grvDSTaiKhoan_RowCommand">
                <Columns>
                    <asp:BoundField DataField="TenTaiKhoan" HeaderText="TenTaiKhoan" ReadOnly="True" SortExpression="TenTaiKhoan" />
                    <asp:BoundField DataField="MatKhau" HeaderText="MatKhau" SortExpression="MatKhau" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="SDT" HeaderText="SDT" SortExpression="SDT" />
                    <asp:BoundField DataField="DiaChi" HeaderText="DiaChi" SortExpression="DiaChi" />
                    <asp:BoundField DataField="HoTen" HeaderText="HoTen" SortExpression="HoTen" />
                    <asp:CheckBoxField DataField="LaAdmin" HeaderText="LaAdmin" SortExpression="LaAdmin" />
                    <asp:BoundField DataField="AnhDaiDien" HeaderText="AnhDaiDien" SortExpression="AnhDaiDien" />
                    <asp:CheckBoxField DataField="TrangThai" HeaderText="TrangThai" SortExpression="TrangThai" />

                  
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="btnChon" runat="server" CausesValidation="false" CommandName="btnChon" Text="Chọn" CommandArgument='<%#Eval("TenTaiKhoan") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                  
                </Columns>

            </asp:GridView>
           <%-- <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebBanHangConnectionString %>" SelectCommand="SELECT * FROM [TaiKhoan]"></asp:SqlDataSource>--%>
        </div>
    </form>
</body>
</html>
