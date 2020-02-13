<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tipo_cad.aspx.cs" Inherits="Tipo_cad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastre-se no Caravamo</title>
    <link href="../../css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/Jquery-3.4.1.js"></script>
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
            <hr  style="padding-top:50px;" />
            <div class="row">
                <div class="col-md-6  text-center">
                    <h1>Cadastre-se para viajar</h1>
                    <a href="Cad_cli.aspx"  class="genric-btn primary radius">Cadastrar como Viajante</a>
                </div>
                <div class="col-md-6 text-center"> 
                    <h1>Cadastrar como Empresa</h1>
                    <a href="Cad_emp.aspx"  class="genric-btn primary radius">Cadastrar como Empresa</a>
                </div>
            </div>
        </div>
    </form>

</body>
</html>
