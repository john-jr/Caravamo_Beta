<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Add_Vehicle_2.aspx.cs" Inherits="Pages_ToCompany_Add_Vehicle_2" %>

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

        #acessorios label {
            font-size: 16px;
            margin-right: 15px;
        }

        #acessorios input {
            width: 15px;
            height: 15px;
           
        }
    </style>
    <div class="container">
        <div class="mt-5 mb-5 text-center">
            <h2>Adicionar veículo</h2>
        </div>
        <ul class="step d-flex flex-nowrap">
            <li class="step-item ">
                <a href="Add_Vehicle_1.aspx" class="">Informações do Veículo</a>
            </li>
            <li class="step-item active">
                <a href="#!" class="">Assentos e Acessórios</a>
            </li>
            <%--<li class="step-item ">
                <a href="Add_Vehicle_3.aspx" class="">Fotos do Veículo</a>
            </li>--%>
            <li class="step-item">
                <a href="Add_Vehicle_4.aspx" class="">Confirmar</a>
            </li>
        </ul>
    </div>
    <br />
    <div class="container">
        <div class="row">
            <div class="col-12 text-center">
                <h3>Insira as informações do veículo</h3>
                <br />
                <br />
            </div>
            <div class="col-12 text-center">
                <h5>Insira quantos assentos tem o veículo</h5>
            </div>
            <div class="col-12 text-center">
                <h5>(Incluindo o do motorista)</h5>
            </div>
            <div class="col-md-5">
            </div>
            <div class="col-md-2 col-lg-2 col-4 offset-4 offset-lg-0 offset-md-0 text-center px-5">
                <asp:TextBox runat="server" ClientIDMode="Static" ID="amount" CssClass="form-control text-center font-weight-bold " style="font-size: 20px; background-color: white;"></asp:TextBox>
              <!--  <input type="text" id="amount" readonly class="form-control text-center font-weight-bold " style="font-size: 20px; background-color: white;" /> -->
                <asp:Literal ID="ltl_assentos" runat="server"></asp:Literal>
                <br />
            </div>
            <div class="col-md-5">
            </div>


            <div class="col-md-4">
            </div>
            <div class="col-8 col-lg-4 col-md-4 text-center offset-2 offset-lg-0">

                <div id="slider-range"></div>

            </div>
            <div class="col-md-4">
            </div>


            <div class="col-md-12">
                <br />
                <br />
                <br />
            </div>

            <div class="col-md-7">
                <div class="row">
                    <div class="col-md-2">
                    </div>
                    <div class="col-md-6 text-center">
                        <h4>Insira os acessórios do veículo</h4>
                    </div>
                    <div class="col-md-4">
                    </div>

                </div>
                <div class="row">
                    <div class="col-md-2">
                    </div>
                    <div class="col-md-6 text-center">
                        <div class="input-group" id="aux">


                            <asp:TextBox ID="txt_novoAcessorio" runat="server" placeholder="Adicionar acessório na lista" CssClass=" form-control" Style="height: calc(1.5em + .75rem + 6px);"></asp:TextBox>
                            <div class="input-group-prepend">
                                <asp:LinkButton ID="btn_add" runat="server" CssClass="genric-btn black" OnClick="btn_add_Click">
                             <i class="fa fa-plus"></i>
                                </asp:LinkButton>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                    </div>

                </div>
            </div>
            <div class="col-md-5 mt-2 mt-lg-0 mt-md-0 ml-2 ml-lg-0 ml-md-0" id="acessorios">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <h4 class="d-none d-sm-block">Acessórios Disponíveis</h4>
                    </div>
                </div>

                <asp:CheckBoxList runat="server" ID="cbl_acessorios" RepeatColumns="3"
                    RepeatLayout="Table"
                    RepeatDirection="Horizontal">
                </asp:CheckBoxList>
            </div>


        </div>



    </div>


    <hr />
    <div class="container">
        <div class="row ">
            <div class="col-4 text-center">
                <asp:LinkButton runat="server" ID="btnRetornar" OnClick="btnRetornar_Click" class="genric-btn danger ml-lg-5 ml-md-5 ml-0 mb-2">
  <i class=' fa fa-arrow-left'></i>  Retornar
                </asp:LinkButton>
            </div>
            <div class="col-4">
            </div>

            <div class="col-4">

                <asp:LinkButton runat="server" ID="btnAvancar1" OnClick="btnAvancar1_Click" class="genric-btn info ml-lg-5 ml-md-5 ml-0 mb-2">
   Avançar <i class=' fa fa-arrow-right'></i>
                </asp:LinkButton>

            </div>
        </div>
    </div>
    <script src="../../js/jquery-1.12.1.min.js"></script>

    <script src="../../js/jquery-ui.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#slider-range").slider({
                range: "max",
                min: 2,
                max: 42,

                slide: function (event, ui) {
                    $("#amount").val(ui.value);
                }
            });
            $("#amount").val($("#slider-range").slider("value"));
        });
    </script>
</asp:Content>

