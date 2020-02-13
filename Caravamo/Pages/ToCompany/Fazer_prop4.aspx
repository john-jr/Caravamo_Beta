<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Fazer_prop4.aspx.cs" Inherits="Pages_ToCompany_Fazer_prop4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
         <script src="../../js/bootstrap.min.js"></script>
     <script src="../../js/jquery-1.12.1.min.js"></script>
     <script src="../../js/toastr.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

    <link href="../../css/steps.css" rel="stylesheet" />
    <link href="../../css/jquery-ui.min.css" rel="stylesheet" />
    <link href="../../css/rangeslider.css" rel="stylesheet" />



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



        .auxiliar:hover {
            color: black;
            border: 2px solid;
        }

        .cor {
            background-color: #d9d9d9;
        }

        .border-dark {
            color: black;
            border: 2px solid;
        }

        #preco {
            border: 2px solid;
        }
    </style>
    <div class="container col-lg-11">

        <div class="container">
            <div class="mt-5 mb-5 text-center">
                 <asp:Literal runat="server" ID="ltl_auxiliar"></asp:Literal>
            </div>
            <ul class="step d-flex flex-nowrap">
                <li class="step-item  ">
                    <a href="Fazer_prop.aspx" class="">
                        <img src="../../img/Vehicles_and_cars_02-512.png" style="max-height: 30px;" />
                    </a>
                </li>
                <li class="step-item ">
                    <a href="Fazer_prop2.aspx" class="">
                        <img src="../../img/Motorista.png" style="max-height: 30px; min-height: 30px;" />
                    </a>
                </li>
                <li class="step-item ">
                    <a href="Fazer_prop3.aspx" class="">
                        <img src="../../img/money.png" style="max-height: 30px; min-height: 30px;" />
                    </a>
                </li>

                <li class="step-item active">
                    <a href="Fazer_prop4.aspx" class="">
                        <img src="../../img/confirm.png" style="max-height: 30px; min-height: 30px;" />
                    </a>
                </li>

            </ul>
        </div>


        <div class="row mt-2">
            <div class="container col-xl-10 col-lg-10 ">
                <div class="col-12 text-center mb-1 mt-4">
                    <h3>Confirme Sua Proposta</h3>

                </div>
                <div class="container col mt-3">
                    <div class="container col-lg-12 col-md-10">
                        <div class="container col-lg-12 ">

                            <div class="row">
                                <div class="row col-lg-6 col-md-6 col-12 ">
                                    <div class="container col-lg-4 col-md col-4  ">
                                        <img src="../../img/Vehicles_and_cars_02-512.png" style="max-height: 40px;" />
                                    </div>
                                    <div class="row col-lg-8 col-md-8 col-8 ">
                                        <h2>Veículo</h2>
                                    </div>

                                    <div class="col-lg-6 col-md-12">
                                        <img src="../../img/1498585513-sprinter-415-van-15-1-k42e--b-.jpg" />
                                    </div>
                                    <div class="col-lg-6 text-center mb-5 mb-lg-0">
                                        <p style="font-size:medium">
                                            <asp:Label runat="server" ID="lblVeiculo">Nome do Carro</asp:Label>
                                        </p>
                                    </div>
                                </div>
                                <span class="border-right d-none d-md-block"></span>
                                <div class="row col-lg-6 col-md-6 col-12 ">
                                    <div class="container col-lg-4 col-md col-4  ">
                                        <img src="../../img/Motorista.png" style="max-height: 40px;" />
                                    </div>
                                    <div class="row col-lg-8 col-md-8 col-8 ">
                                        <h2>Motorista</h2>
                                    </div>

                                    <div class="col-lg-6 col-md-12">
                                        <img src="../../img/Motorista.png" />
                                    </div>
                                    <div class="col-lg-6 text-center mb-5 mb-lg-0">
                                        <p style="font-size:medium">
                                            <asp:Label runat="server" ID="lbl_motorista">Nome do Motorista</asp:Label>
                                        </p>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <hr />
                    <div class="form-group ">
                        <div class=" row col-lg-12 text-center">

                            <div class="col-lg-12">

                                <h2><i class="fa fa-money-bill-alt fa-1x m-2"></i>Valor da Proposta</h2>
                            </div>

                            <div class="col-lg-12 text-center">
                                <h1>
                                    <asp:Label runat="server" ID="lblValor">2000,00R$</asp:Label>
                                </h1>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>



        <hr />




        <div class="container mb-5  ">
            <div class="row col-lg-12">
                <div class="container col-6 col-lg-3 col-md-5">
                    <asp:Literal ID="ltl_status" runat="server"></asp:Literal>
                    <asp:LinkButton runat="server" ID="LinkButton1" class="genric-btn danger btn-block float-left">
  <i class=' fa fa-arrow-left'></i>  Retornar
                    </asp:LinkButton>
                </div>


                <div class="container col-6 col-lg-3 col-md-5">

                    <asp:LinkButton runat="server" ID="btnAvancar1" OnClick="btnAvancar1_Click" class="genric-btn info btn-block float-right">
   Concluir
                    </asp:LinkButton>

                </div>
            </div>





        </div>

    </div>
  

</asp:Content>

