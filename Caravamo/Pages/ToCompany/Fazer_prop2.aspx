<%@ Page Title="" Language="C#" MasterPageFile="../../Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Fazer_prop2.aspx.cs" Inherits="Fazer_prop2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="../../css/steps.css" rel="stylesheet" />
    <link href="../../css/jquery-ui.min.css" rel="stylesheet" />
    <style>
        #aux .form-control:focus {
            border-color: #cccccc;
            -webkit-box-shadow: none;
            box-shadow: none;
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

        .selected {
            color: black;
            border: 2px solid black;
            background: white;
        }


        .auxiliar:hover {
            color: black;
            border: 2px solid;
        }
    </style>
    <div class="container col-lg-11">
        <div class="container">
            <div class="mt-5 mb-5 text-center">
                <asp:Literal ID="ltl_auxiliar" runat="server">
                </asp:Literal>
            </div>
            <ul class="step d-flex flex-nowrap">
                <li class="step-item  ">
                    <a href="Fazer_prop.aspx" class="">
                        <img src="../../img/Vehicles_and_cars_02-512.png" style="max-height: 30px;" />
                    </a>
                </li>
                <li class="step-item active ">
                    <a href="Fazer_prop2.aspx" class="">
                        <img src="../../img/Motorista.png" style="max-height: 30px; min-height: 30px;" />
                    </a>
                </li>
                <li class="step-item  ">
                    <a href="#" class="">
                        <img src="../../img/money.png" style="max-height: 30px; min-height: 30px;" />
                    </a>
                </li>

                <li class="step-item">
                    <a href="#" class="">
                        <img src="../../img/confirm.png" style="max-height: 30px; min-height: 30px;" />
                    </a>
                </li>

            </ul>

        </div>

        <br />
        <div class="container">
            <div class="container text-center">
                <div class="col-12 text-center mb-4">
                    <h3>Escolha o motorista que irá realizar a Viagem</h3>

                </div>
                <div class="row col-lg-12 align-content-center" id="rowcentro">

                    <asp:PlaceHolder ID="phl_mot" runat="server"></asp:PlaceHolder>

                </div>

            </div>

        </div>




        <hr />
        <div class="container mb-5   ">
            <asp:Label ID="lbl_id" runat="server" Style="font-size: .1px"></asp:Label>
            <div class="row col-lg-12">
                <div class="container col-6 col-lg-4">
                    <asp:LinkButton runat="server" ID="btnRetornar1" OnClick="btnRetornar1_Click" class="genric-btn danger btn-block float-left">
  <i class=' fa fa-arrow-left'></i>  Retornar
                    </asp:LinkButton>
                </div>


                <div class="container col-6 col-lg-4">

                    <asp:LinkButton runat="server" ID="btnAvancar1" OnClick="btnAvancar1_Click" class="genric-btn info btn-block float-right">
   Avançar <i class=' fa fa-arrow-right'></i>
                    </asp:LinkButton>

                </div>
            </div>
        </div>
    </div>



    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery-1.12.1.min.js"></script>

    <script src="js/jquery-ui.min.js"></script>
    <script src="js/alertify.min.js"></script>
    <script src="js/aos.js"></script>
    <script src="js/bootstrap-slider.min.js"></script>
    <script src="js/contact.js"></script>
    <script src="js/custom.js"></script>
    <script src="js/datepicker-pt-BR.js"></script>
    <script src="js/gmaps.min.js"></script>
    <script src="js/jquery-1.12.1.min.js"></script>
    <script src="js/jquery-3.3.1.slim.min.js"></script>
    <script src="js/Jquery-3.4.1.js"></script>
    <script src="js/jquery-ui.min.js"></script>
    <script src="js/jquery.ajaxchimp.min.js"></script>
    <script src="js/jquery.counterup.min.js"></script>
    <script src="js/jquery.easing.min.js"></script>
    <script src="js/jquery.form.js"></script>
    <script src="js/jquery.magnific-popup.js"></script>
    <script src="js/jquery.nice-select.js"></script>
    <script src="js/jquery.nice-select.min.js"></script>
    <script src="js/jquery.validate.min.js"></script>
    <script src="js/mail-script.js"></script>
    <script src="js/masonry.pkgd.js"></script>
    <script src="js/masonry.pkgd.min.js"></script>
    <script src="js/moment.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/particles.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/slick.min.js"></script>
    <script src="js/swiper.min.js"></script>
    <script src="js/swiper_custom.js"></script>
    <script src="js/waypoints.min.js"></script>




</asp:Content>

