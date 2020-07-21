<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="Create_Caravan_emp_8.aspx.cs" Inherits="Pages_ToUser_Create_Caravan_5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/jquery-1.12.1.min.js"></script>
    <script src="../../js/toastr.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <link href="../../css/steps.css" rel="stylesheet" />
    <style>
        b {
            color: black;
        }

        .big_font {
            font-size: 18px;
            margin-left: 15%;
        }

        

        .myOffSet {
            margin-left: 16%;
        }

        .aux {
            background-color: white;
        }
    </style>


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
                <a class="">Motorista</a>
            </li>
            <li class="step-item" id="caravan_veiculo">
                <a class="">Veiculo</a>
            </li>
            <li class="step-item " id="caravan_preco">
                <a class="">Preço</a>
            </li>

            <li class="step-item active">
                <a href="Create_Caravan_5.aspx" class="">Confirmar</a>
            </li>

        </ul>
    </div>
    <br />
    <div class="container">
        <div class="row">
            <div class="col-12 mb-2">
                <h3>Por favor, confirme as informações inseridas</h3>
            </div>

            <div class="container">

                <div class="col-12">
                    <div class=" big_font">
                        <b>Título da Caravana:</b>
                        <asp:Literal runat="server" ID="ltl_tituloCaravana"></asp:Literal>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-6 text-center">
                        <b>Privacidade:</b>
                        <asp:Literal runat="server" ID="ltl_tipoCaravana"></asp:Literal>
                    </div>

                    <div class="col-6 text-center">
                        <b>Categoria:</b>
                        <asp:Literal runat="server" ID="ltl_categoria"></asp:Literal>

                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-12 text-left">
                        <div class="myOffSet">
                            <b>Descrição:</b>
                            <asp:TextBox ID="ltl_descricaoCaravana" Rows="5" Columns="105" TextMode="multiline" Style="resize: none" Width="83%" ReadOnly="true" CssClass="form-control aux" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-6 text-center">
                        <b>Endereço de Saída:</b>
                        <asp:Literal runat="server" ID="ltl_endSaida"></asp:Literal>
                    </div>
                    <br />
                    <div class="col-6 text-center">
                        <b>Endereço de Destino:</b>
                        <asp:Literal runat="server" ID="ltl_endDest"></asp:Literal>
                    </div>
                </div>
                <br />
                <div class="row">
                    <br />
                    <div class="col-6 text-center">
                        <b>Data de Saída:</b>
                        <asp:Literal runat="server" ID="ltl_datSaida"></asp:Literal>
                    </div>
                    <br />
                    <div class="col-6 text-center">
                        <b>Data de Retorno:</b>
                        <asp:Literal runat="server" ID="ltl_datDest"></asp:Literal>
                    </div>
                    <br />

                </div>
                <br />

                <div class="row">
                    <br />
                    <div class="col-6 text-center">
                        <b>Veículo da Caravana:</b>
                        <asp:Literal runat="server" ID="ltl_veiculo"></asp:Literal>
                    </div>
                    <br />
                    <div class="col-6 text-center">
                        <b>Motorista da Caravana:</b>
                        <asp:Literal runat="server" ID="ltl_motorista"></asp:Literal>
                    </div>
                    <br />

                </div>
                <br />

                <div class="col-12">
                    <div class="big_font  text-center ml-0" style="display:flex; align-items:center; justify-content:center">
                        <b>Frete Total:</b>
                        <asp:Literal runat="server" ID="ltl_frete"></asp:Literal>
                    </div>

                </div>
            </div>

        </div>

    </div>



    <br />
    <hr />




    <div class="container">
        <div class="row ">
            <div class="col-4 text-center">
                <asp:Literal runat="server" ID="ltl_status"></asp:Literal>
                <asp:LinkButton runat="server" ID="LinkButton1" class="genric-btn danger ml-lg-5 ml-md-5 ml-0 mb-2">
  <i class=' fa fa-arrow-left'></i>  Retornar
                </asp:LinkButton>
            </div>
            <div class="col-4">
            </div>

            <div class="col-4">

                <asp:LinkButton runat="server" ID="btnAvancar1" OnClick="btnAvancar1_Click" class="genric-btn info ml-lg-5 ml-md-5 ml-0 mb-2">
   Confirmar
                </asp:LinkButton>

            </div>
        </div>
    </div>
</asp:Content>

