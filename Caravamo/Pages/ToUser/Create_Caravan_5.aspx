<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="Create_Caravan_5.aspx.cs" Inherits="Pages_ToUser_Create_Caravan_5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
        <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/jquery-1.12.1.min.js"></script>
    <script src="../../js/toastr.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
      

    <link href="../../css/steps.css" rel="stylesheet" />
 
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
            <li class="step-item">
                <a href="Create_Caravan_3.aspx" class="">Datas</a>
            </li>
            <li class="step-item">
                <a href="Create_Caravan_4.aspx" class="">Categoria</a>
            </li>
            <li class="step-item active">
                <a href="#!" class="">Confirmar</a>
            </li>

        </ul>
    </div>
    <br />
    <br />

    <div class="container">
        <div class="row">
            <div class="col-12 mb-2">
                <h3>Por favor, confirme as informações inseridas</h3>
            </div>

            <div class="container">

                <div class="col-12">
                    Título da Caravana:
                    <asp:Literal runat="server" ID="ltl_tituloCaravana"></asp:Literal>
                </div>
                <br />
                <div class="col-12">
                    Tipo:
                    <asp:Literal runat="server" ID="ltl_tipoCaravana"></asp:Literal>
                </div>
                <br />

                <div class="col-12">
                    Descrição:
                    <asp:Literal runat="server" ID="ltl_descricaoCaravana"></asp:Literal>
                </div>
                <br />
                <div class="col-12">
                    Endereço de Saída:
                    <asp:Literal runat="server" ID="ltl_endSaida"></asp:Literal>
                </div>
                <br />
                <div class="col-12">
                    Endereço de Destino:
                    <asp:Literal runat="server" ID="ltl_endDest"></asp:Literal>
                </div>
                <br />
                <div class="col-12">
                    Data de Saída:
                    <asp:Literal runat="server" ID="ltl_datSaida"></asp:Literal>
                </div>
                <br />
                <div class="col-12">
                    Data de Retorno:
                    <asp:Literal runat="server" ID="ltl_datDest"></asp:Literal>
                </div>
                <br />
                <div class="col-12">
                    Categoria:
                    <asp:Literal runat="server" ID="ltl_categoria"></asp:Literal>
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

