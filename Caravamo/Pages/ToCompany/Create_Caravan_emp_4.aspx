<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="Create_Caravan_emp_4.aspx.cs" Inherits="Pages_ToUser_Create_Caravan_4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="../../css/steps.css" rel="stylesheet" />
    <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/jquery-1.12.1.min.js"></script>
    <script src="../../js/toastr.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <!-- <asp:Literal runat="server" ID="ltl_status"></asp:Literal> -->
    <style>
        #categorias label {
            font-size: 16px;
        }

        #categorias td {
            padding: 5px;
            padding-left: 70px;
        }

        #categorias input {
            margin-left: -20px;
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
            <li class="step-item active">
                <a href="#!" class="">Categoria</a>
            </li>
              <li class="step-item" id="caravan_motorista">
                <a  class="">Motorista</a>
            </li>
             <li class="step-item" id="caravan_veiculo">
                <a  class="">Veiculo</a>
            </li>
             <li class="step-item" id="caravan_preco">
                <a  class="">Preço</a>
            </li>

            <li class="step-item">
                <a href="Create_Caravan_5.aspx" class="">Confirmar</a>
            </li>

        </ul>
    </div>
    <br />
    <br />
    <div class="container">
        <div class="row">
            <div class="col-lg-6 col-xl-6 col-md-6 offset-1 offset-lg-2 offset-md-2 offset-xl-2">
                <h3>Escolha até duas categorias da sua caravana:</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-3 col-xl-3 offset-lg-3 offset-md-3 offset-xl-3" id="categorias">
                <asp:CheckBoxList runat="server" OnSelectedIndexChanged="cbl_categorias_SelectedIndexChanged" AutoPostBack="true" ID="cbl_categorias" RepeatColumns="3"
                    RepeatLayout="Table"
                    RepeatDirection="Horizontal">
                </asp:CheckBoxList>
            </div>

        </div>
    </div>
    <div class="row" style="margin: 0">
        <div class="col-lg-12 text-center mt-4 mb-1">
            <asp:Literal runat="server" ID="ltl_valid" />
        </div>
    </div>
    <br />
    <hr />
    <div class="container">

        <div class="row ">
            <div class="col-4 text-center">
                <asp:LinkButton runat="server" ID="LinkButton1" class="genric-btn danger ml-lg-5 ml-md-5 ml-0 mb-2">
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

    <script src="../../js/jquery-3.3.1.slim.min.js" type="text/javascript"></script>
    <script src="../../js/jquery.validate.min.js" type="text/javascript"></script>
    <script src="../../js/bootstrap.min.js"></script>

</asp:Content>

