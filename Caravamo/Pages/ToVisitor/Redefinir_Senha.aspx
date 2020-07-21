<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Redefinir_Senha.aspx.cs" Inherits="Tipo_cad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastre-se no Caravamo</title>
    <link href="../../css/bootstrap.min.css" rel="stylesheet" />
  
    <link rel="stylesheet" href="../../css/bootstrap.min.css" />
    <!-- animate CSS -->
    <link rel="stylesheet" href="../../css/animate.css" />
    <!-- owl carousel CSS -->
    <link rel="stylesheet" href="../../css/owl.carousel.min.css" />
    <!-- font awesome CSS -->
    <link rel="stylesheet" href="../../css/all.css" />
    <!-- flaticon CSS -->
    <link rel="stylesheet" href="../../css/flaticon.css" />
    <link rel="stylesheet" href="../../css/themify-icons.css" />
    <link rel="stylesheet" href="../../css/nice-select.css" />
    <!-- font awesome CSS -->
    <link rel="stylesheet" href="../../css/magnific-popup.css" />
    <!-- swiper CSS -->
    <link rel="stylesheet" href="../../css/slick.css" />
    <!-- style CSS -->
    <link rel="stylesheet" href="../../css/style.css" />
    <link rel="stylesheet" href="../../css/jquery-ui.min.css" />
   
    <style>
        .swal-text{
            text-align: center;
        }
    </style>

</head>



<body>
    

    <div class="main_menu home_menu">
        <div class="container">
            <div class="l-box-content text-center">
                <a href="Index.aspx">
                    <img src="../../img/logo.png" style="width: 30%;" /></a>
            </div>
        </div>

    </div>
    <form id="form1" runat="server">
        <div class="container" style="padding-top:20px;">
            <hr  style="padding-top:5px;" />
            <div class="row">
                <div class="col-md-12  text-center">
                    <h1>Redefinir Senha</h1>
                 
                </div>
                  </div>
            <br />
                <div class="row">
                <div class="col-md-12 text-center"> 
                    <h4>Digite o E-mail de sua conta para redefinir a senha</h4>
                    </div> 
                    <div class=" offset-lg-3 col-6">
                     <asp:TextBox runat="server" ID="txtEmail" type="email" CssClass="form-control" placeholder="E-mail"></asp:TextBox>
                </div>
                    </div>
            <br />
            <div class="row offset-lg-4 col-4">
                <asp:LinkButton runat="server" ID="btn_redefinir" OnClick="btn_redefinir_Click" class="genric-btn primary w-100">Confirmar</asp:LinkButton>
            </div>
          

        </div>
    </form>

  
      <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/Jquery-3.4.1.min.js"></script>
   
     <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

      <asp:Literal ID="ltl_status" runat="server"></asp:Literal>

</body>
</html>
