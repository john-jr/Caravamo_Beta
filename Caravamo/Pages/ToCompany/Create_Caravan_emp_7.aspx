<%@ Page Title="" Language="C#" MasterPageFile="../../Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Create_Caravan_emp_7.aspx.cs" Inherits="Fazer_prop3" %>

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
            <h2>Criar Caravana</h2>
        </div>
        <ul class="step d-flex flex-nowrap">
            <li class="step-item ">
                <a href="Create_Caravan_1.aspx" class="">Título e Descrição</a>
            </li>
            <li class="step-item">
                <a href="Create_Caravan_2.aspx" class="">Endereços</a>
            </li>
            <li class="step-item ">
                <a href="Create_Caravan_3.aspx" class="">Datas</a>
            </li>
            <li class="step-item">
                <a href="#!" class="">Categoria</a>
            </li>
              <li class="step-item " id="caravan_motorista">
                <a  class="">Motorista</a>
            </li>
             <li class="step-item" id="caravan_veiculo">
                <a  class="">Veiculo</a>
            </li>
             <li class="step-item active" id="caravan_preco">
                <a  class="">Preço</a>
            </li>

            <li class="step-item">
                <a href="Create_Caravan_5.aspx" class="">Confirmar</a>
            </li>

        </ul>
    </div>
    <br />


        <div class="container col-xl-11">
            <div class="col-12 text-center mb-4 mt-4">
                <h3>Insira o Valor Total da Viagem</h3>

            </div>
            <div class="row ">
                <div class=" container cor col-xl-4 col-lg-6 col-md-8 col-sm-8 col-10      mb-4 " id="preco">

                    <div class="card-body">
                        <div class="row">

                            <div class=" container col-lg-9 col-11 mt-3 mb-3">

                                <div class="input-group  mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text ">R$</span>
                                    </div>
                                       <asp:TextBox runat="server"  ClientIDMode="Static" ID="price" CssClass="form-control text-center font-weight-bold col-lg-12 border-dark" style="font-size: 20px; background-color: white;"></asp:TextBox>     
                                    <div class="input-group-append">
                                        <span class="input-group-text">,00</span>
                                    </div>
                                </div>

                                <asp:Literal ID="ltl_valor" runat="server"></asp:Literal>
                            </div>
                            <div class=" container col-lg-10 mt-2 mb-3">


                                <div id="slider-range"></div>

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
                    <asp:LinkButton runat="server" ID="btnCancelar1" OnClick="btnCancelar1_Click" class="genric-btn danger btn-block float-left">
  <i class=' fa fa-arrow-left'></i>  Retornar
                    </asp:LinkButton>
                </div>


                <div class="container col-6 col-lg-3 col-md-5">

                    <asp:LinkButton runat="server" ID="btnAvancar1" OnClick="btnAvancar1_Click" class="genric-btn info btn-block float-right">
   Avançar <i class=' fa fa-arrow-right'></i>
                    </asp:LinkButton>

                </div>
            </div>





        </div>

    </div>
    <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/jquery-1.12.1.min.js"></script>
   <script src="../../js/jquery-ui.min.js"></script>


    <script type="text/javascript">
        $(function () {
            $("#slider-range").slider({
                range: "max",
                min: 100,
                max: 5000,
                step: 10,
                slide: function (event, ui) {
                    $("#price").val(ui.value);
                }
            });
            $("#price").val($("#slider-range").slider("value"));
        });
    </script>
</asp:Content>

