<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test2 - Cópia .aspx.cs" Inherits="Pages_ToAdmin_test2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../css/toastr.min.css" rel="stylesheet" />
    <script src="../../js/jquery-3.4.1.min.js"></script>
    <script src="../../js/toastr.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal runat="server" ID="ltlTeste"></asp:Literal>
            <asp:Button runat="server" ID="btn" Text="teste" OnClick="btn_Click" />
           

        </div>
    </form>


</body>
</html>
