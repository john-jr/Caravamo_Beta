<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Add_Vehicle_3.aspx.cs" Inherits="Pages_ToCompany_Add_Vehicle_3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="../../css/steps.css" rel="stylesheet" />

    <div class="container">
        <div class="mt-5 mb-5 text-center">
            <h2>Adicionar veículo</h2>
        </div>
        <ul class="step d-flex flex-nowrap">
            <li class="step-item ">
                <a href="Add_Vehicle_1.aspx" class="">Informações do Veículo</a>
            </li>
            <li class="step-item">
                <a href="Add_Vehicle_2.aspx" class="">Assentos e Acessórios</a>
            </li>
            <%--<li class="step-item active">
                <a href="#!" class="">Fotos do Veículo</a>
            </li>--%>
            <li class="step-item">
                <a href="Add_Vehicle_4.aspx" class="">Confirmar</a>
            </li>
        </ul>
    </div>

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

                <asp:LinkButton runat="server" ID="btnAvancar1" class="genric-btn info ml-lg-5 ml-md-5 ml-0 mb-2">
   Avançar <i class=' fa fa-arrow-right'></i>
                </asp:LinkButton>

            </div>
        </div>
    </div>

</asp:Content>

