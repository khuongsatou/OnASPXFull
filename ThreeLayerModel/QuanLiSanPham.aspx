<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuanLiSanPham.aspx.cs" Inherits="ThreeLayerModel.QuanLiSanPham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
             <asp:DropDownList ID="ddlSanPham" runat="server" DataTextField="TenSP" DataValueField="MaSP" OnSelectedIndexChanged="ddlSanPham_SelectedIndexChanged"></asp:DropDownList>
            <div class="row">
               
                <asp:Repeater ID="rptSanPham" runat="server" >
                    <ItemTemplate>
                        <div class="col-md-3">
                            <div class="card">
                                <asp:Image ID="imgAnhMinhHoa" runat="server" CssClass="card-img-top"
                                    ImageUrl='<%# "img/product/" + Eval("AnhMinhHoa") %>' />
                                <div class="card-body">
                                    <h4 class="card-title">
                                        <asp:Label ID="lblTenSP" runat="server" Text='<%#
Eval("TenSP") %>'></asp:Label>
                                    </h4>
                                    <p class="card-text">
                                        <asp:Label ID="lblGiaTien" runat="server" Text='<%#
Eval("GiaTien") %>'></asp:Label>
                                    </p>
                                </div>
                                <div class="card-footer">
                                    <asp:Button ID="btnThemGH" runat="server" CssClass="btn btnsuccess" Text="Thêm GH" CommandName="ThemGH" CommandArgument='<%#
Eval("MaSP") %>'></asp:Button>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>

                </asp:Repeater>

            </div>

           
        </div>
        
    </form>
    
</body>
</html>
