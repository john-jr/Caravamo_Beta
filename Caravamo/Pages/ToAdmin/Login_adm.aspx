<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login_adm.aspx.cs" Inherits="Pages_Login_adm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Administrador</title>
    <link rel="icon" href="../../img/favicon.png" />
    <link rel="stylesheet" href="../../css/bootstrap.min.css" />
    <link rel="stylesheet" href="../../css/animate.css" />
    <link rel="stylesheet" href="../../css/owl.carousel.min.css" />
    <link rel="stylesheet" href="../../css/all.css" />
    <link rel="stylesheet" href="../../css/flaticon.css" />
    <link rel="stylesheet" href="../../css/themify-icons.css" />
    <link rel="stylesheet" href="../../css/nice-select.css" />
    <link rel="stylesheet" href="../../css/magnific-popup.css" />
    <link rel="stylesheet" href="../../css/slick.css" />
    <link rel="stylesheet" href="../../css/style.css" />

    <style>

        body{
            background-color: #efebeb;
        }

        @media screen and (max-width: 768px) {
            .login {
                margin-top: 4em !important;
            }
        }

        p{
            font-size: 1em !important;
        }

        .genric-btn.black {
            color: white;
            background: black;
            border: 1px solid transparent;
        }

            .genric-btn.black:hover {
                color: black;
                border: 1px solid black;
                background: white;
            }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-5 col-10 login" style="margin-top: 10em">
                    <div class="card">
                        <div class="card-body text-center">
                            <i class="fa fa-lock fa-3x mb-30" style="color: #a09b9b;"></i>
                            <asp:TextBox runat="server" placeholder="Email" CssClass="form-control mt-2 mb-3"></asp:TextBox>
                            <asp:TextBox runat="server" placeholder="Senha" CssClass="form-control"></asp:TextBox>
                            <%--<p class="text-right"><a href="!#" class="font-weight-light">Esqueceu a senha?</a></p>--%>
                            <asp:Button runat="server" Text="Login" CssClass="genric-btn primary btn-block" style="margin-top: 3em; font-size: 15px"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
