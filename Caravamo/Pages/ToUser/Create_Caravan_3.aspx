<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="Create_Caravan_3.aspx.cs" Inherits="Pages_ToUser_Create_Caravan_3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
            <li class="step-item active">
                <a href="#!" class="">Datas</a>
            </li>
            <li class="step-item">
                <a href="Create_Caravan_4.aspx" class="">Categoria</a>
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
            <div class="col-lg-2 col-xl-2 col-md-2 col-12 text-lg-right text-xl-right">
                <label for="txt_data">Data de Saída:</label>
            </div>


            <div class="col-md-4 col-lg-4 col-6 offset-3 offset-lg-0 offset-md-0 offset-xl-0">
                <asp:TextBox runat="server" ID="txt_dataSaida" TextMode="Date" CssClass="form-control mb-30 mb-lg-0 mb-md-0 mb-xl-0"></asp:TextBox>
            </div>

            <div class="col-lg-2 col-xl-2 col-md-2 col-12 text-lg-right text-xl-right pt-5 pt-lg-0 pt-md-0 pt-xl-0">
                <label for="txt_data">Data de Retorno:</label>
            </div>
            <div class="col-md-4 col-lg-4 col-6 offset-3 offset-lg-0 offset-md-0 offset-xl-0">
                <asp:TextBox runat="server" ID="txt_dataRetorno" TextMode="Date" CssClass="form-control"></asp:TextBox>
            </div>

        </div>

        <br />


         <div class="row">
            <div class="col-lg-2 col-xl-2 col-md-2 col-12 text-lg-right text-xl-right text-right">
                <label for="txt_data">Hora de Saída:</label>
            </div>


            <div class="col-md-2 col-lg-2 col-2 offset-3 offset-lg-0 offset-md-0 offset-xl-0">
                <asp:TextBox runat="server" ID="txt_horaDeSaida" type="Time"   CssClass="form-control mb-30 mb-lg-0 mb-md-0 mb-xl-0"></asp:TextBox>
            </div>


        </div>

    </div>
    <div class="container" style="min-height: 200px">
        <asp:Literal runat="server" ID="lbl_statusDatas"></asp:Literal>
    </div>






    <hr />
    <div class="container">
        <div class="row ">
            <div class="col-4 text-center">
                <asp:LinkButton runat="server" ID="btnRetornar1" OnClick="btnRetornar1_Click" class="genric-btn danger ml-lg-5 ml-md-5 ml-0 mb-2">
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




</asp:Content>

