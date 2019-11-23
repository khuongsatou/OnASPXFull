<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="InputASPX.ADO.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" integrity="sha384-HSMxcRTRxnN+Bdg0JdbxYKrThecOKuH5zCYotlSAcp1+c8xmyTe9GYg1l9a69psu" crossorigin="anonymous" />

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap-theme.min.css" integrity="sha384-6pzBo3FDv/PJ8r2KRkGHifhEocL+1X2rVCTTkUfGk7/0pbek5mMa1upzvWbrUbOZ" crossorigin="anonymous" />

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js" integrity="sha384-aJ21OjlMXNL5UyIl/XNwTMqvzeRMZH2w8c5cRVpzpU8Y5bApTppSuUkhZXN0VxHd" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <h1>Reader</h1>
                    <asp:Label ID="lblReader" runat="server" />
                    <h1>Adapter</h1>
                    <asp:Label ID="lblAdapter" runat="server" />
                    <h1>Scalar</h1>
                    <asp:Label ID="lblScalar" runat="server" />
                </div>
                <div class="col-md-3">
                    <h1>Insert</h1>
                    <asp:Label CssClass="badge badge-light" ID="lblError" runat="server" Text="Thông Báo Lỗi" Visible="false" /><br />
                    UserName:
                    <asp:TextBox CssClass="form-control" ID="txtUserName" runat="server" /><br />
                    Password:
                    <asp:TextBox CssClass="form-control" ID="txtPassWord" runat="server" /><br />
                    <asp:Button CssClass="btn btn-danger" ID="btnInsert" Text="Add" runat="server" OnClick="ClickBtnInsert" />

                    <h1>Update</h1>
                    <asp:Label CssClass="badge badge-light" ID="lblErrorUp" runat="server" Text="Thông Báo Lỗi" Visible="false" /><br />
                    ID:
                    <asp:TextBox CssClass="from-control" ID="txtIdUp" runat="server" TextMode="Number" Text="1" />
                    <br />
                    UserName:
                    <asp:TextBox CssClass="form-control" ID="txtUserNameUp" runat="server" /><br />
                    Password:
                    <asp:TextBox CssClass="form-control" ID="txtPassWordUp" runat="server" /><br />
                    <asp:Button CssClass="btn btn-danger" ID="btnUpdate" Text="Add" runat="server" OnClick="ClickBtnUpdate" />

                    <h1>Delete</h1>
                    <asp:Label CssClass="badge badge-light" ID="lblErrorDelete" runat="server" Text="Thông Báo Lỗi" Visible="false" /><br />
                    ID:
                    <asp:TextBox CssClass="from-control" ID="txtIDDelete" runat="server" TextMode="Number" Text="1" />
                    <br />
                    <asp:Button CssClass="btn btn-danger" ID="btnDelete" Text="Delete" runat="server" OnClick="ClickBtnDelete" />
                </div>
                <div class="col-md-3">
                    <h1>Parameter Delete</h1>
                    <asp:Label CssClass="badge badge-light" ID="lblDeletePara" runat="server" Text="Thông Báo Lỗi" Visible="false" /><br />
                    ID:
                    <asp:TextBox CssClass="from-control" ID="txtDeleteParaID" runat="server" TextMode="Number" Text="1" />
                    <br />
                    <asp:Button CssClass="btn btn-danger" ID="btnDeleteParaID" Text="Delete" runat="server" OnClick="ClickBtnDeletePara" />
                </div>
            </div>
        </div>

    </form>
</body>
</html>
