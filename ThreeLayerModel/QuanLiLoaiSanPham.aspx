<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuanLiLoaiSanPham.aspx.cs" Inherits="ThreeLayerModel.QuanLiLoaiSanPham" %>

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
                    <td>Mã Loại Sản Phẩm
                    </td>
                    <td>
                        <asp:TextBox ID="txtMaLoaiSP" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Tên Loại Sản Phẩm
                    </td>
                    <td>
                        <asp:TextBox ID="txtTenLoaiSP" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Trạng Thái
                    </td>
                    <td>
                        <asp:CheckBox ID="cbTrangThai" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td></td>

                    <td>
                        <asp:Button ID="btnThem" runat="server" Text="Thêm" onClick="BtnThem_Click"/>
                        <asp:Button ID="btnSua" OnClick="BtnSua_Click" runat="server" Text="Sửa" />
                        <asp:Button ID="btnHuyBo" runat="server" Text="Hủy Bỏ" />
                    </td>
                </tr>

            </table>

            <asp:GridView ID="grvLoaiSanPham" runat="server" AutoGenerateColumns="False" DataKeyNames="MaLoaiSP" OnRowCommand="grvLoaiSanPham_RowCommand" >
                <Columns>
                    <asp:BoundField HeaderText="Mã Loại" DataField="MaLoaiSP" />
                     <asp:BoundField HeaderText="Tên Loại" DataField="TenLoaiSP" />
                    <asp:CheckBoxField HeaderText="Trạng Thái" DataField="TrangThai" />

                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="btnChon" runat="server" CausesValidation="false" CommandName="ChonSP" Text="Chọn" CommandArgument='<%#Eval("MaLoaiSP") %>' />
                             <asp:Button ID="btnXoa" runat="server" CausesValidation="false" CommandName="XoaSP" Text="Xóa" CommandArgument='<%#Eval("MaLoaiSP") %>' OnClientClick="return confirm('Bạn có chắc chắn muốn xóa? ') " />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
