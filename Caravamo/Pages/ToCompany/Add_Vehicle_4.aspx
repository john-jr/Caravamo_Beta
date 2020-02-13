<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Add_Vehicle_4.aspx.cs" Inherits="Pages_ToCompany_Add_Vehicle_4" %>

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
            <li class="step-item ">
                <a href="Add_Vehicle_2.aspx" class="">Assentos e Acessórios</a>
            </li>
            <%--<li class="step-item ">
                <a href="Add_Vehicle_3.aspx" class="">Fotos do Veículo</a>
            </li>--%>
            <li class="step-item active">
                <a href="#!" class="">Confirmar</a>
            </li>

        </ul>
    </div>
    <br />
    <div class="container">
        <div class="row">
            <div class="col-12 text-center">
                <br />
                <h3>Por Favor, confirme as informações</h3>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-2">
            </div>
            <div class="col-md-8 text-center">
                <i class="fa fa-shuttle-van fa-4x"></i>

                <br />


            </div>
            <div class="col-md-2">
            </div>
        </div>

        <div class="row">
            <div class="col-md-2">
            </div>
            <div class="col-md-8 text-center">
                <h4>&nbsp;Dados do Veículo</h4>



            </div>
            <div class="col-md-2">
            </div>

        </div>

        <br />


        <div class="row">

            <div class="col-md-2">
            </div>

            <div class="col-md-4">


                <div class="row">
                    <div class="col-md-12 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="lbl_MarcaVeiculo" Text="Marca: "></asp:Label>
                    </div>
                    <br class="d-none d-sm-block" />
                    <br />
                    <div class="col-md-12 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="lbl_ModeloVeiculo" Text="Modelo: "></asp:Label>
                    </div>
                    <br class="d-none d-sm-block" />
                    <br />
                    <div class="col-md-12 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="lbl_TipoVeiculo" Text="Tipo: "></asp:Label>
                    </div>
                    <br class="d-none d-sm-block" />
                    <br />
                    <div class="col-md-12 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="lbl_qntassentos" Text="Quantidade de Assentos: "></asp:Label>
                    </div>
                    <br class="d-none d-sm-block" />
                    <br />


                </div>
            </div>
            <div style="border-left: 1px solid lightgrey; margin: 0 7.5px;"></div>
            <div class="col-md-4">
                <div class="row">
                    <div class="col-md-12 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="lbl_Placa" Text="Placa: "></asp:Label>
                    </div>
                    <br class="d-none d-sm-block" />
                    <br />
                    <div class="col-md-12 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="lbl_ano" Text="Ano: "></asp:Label>
                    </div>
                    <br class="d-none d-sm-block" />
                    <br />
                    <div class="col-md-12 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="lbl_crlv" Text="CRLV: "></asp:Label>
                        <br class="d-none d-sm-block" />
                        <br />
                    </div>
                    <div class="col-md-3 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="Label2" Text="Acessórios: "></asp:Label>
                    </div>
                    <div class="col-lg-8 col-md-7 mb-2 mb-lg-0 mb-md-0 ml-md-4">
                     <asp:ListBox ID="lbx_acessorios"  Rows="3" Width="115%" SelectionMode="Single" CssClass="form-control" runat="server"></asp:ListBox>
                    </div>
                    <div class="col-md-3">
                    </div>


                </div>
            </div>



        </div>









    </div>

    <hr />


    <div class="container">
        <div class="row ">
            <div class="col-4 text-center">
                <asp:Literal runat="server" ID="ltl_status"></asp:Literal>
                 <asp:LinkButton runat="server" ID="retornar" OnClick="retornar_Click" class="genric-btn danger ml-lg-5 ml-md-5 ml-0 mb-2">
  <i class=' fa fa-arrow-left'></i>  Retornar
                </asp:LinkButton>
            </div>
            <div class="col-4">
            </div>

            <div class="col-4">

                <asp:LinkButton runat="server" ID="btnConfirmar" OnClick="btnConfirmar_Click" class="genric-btn info ml-lg-5 ml-md-5 ml-0 mb-2">
   Confirmar
                </asp:LinkButton>

            </div>
        </div>
    </div>


    <br />


</asp:Content>

