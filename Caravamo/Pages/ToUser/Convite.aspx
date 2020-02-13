<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="Convite.aspx.cs" Inherits="Convite" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">

        <section class="container mb-30">
            <div class="row">
                <div class="col-lg-12 mt-30" style="text-align: center">
                    <asp:Label runat="server" CssClass="h2">Título da Caravana</asp:Label>
                </div>
                <div class="col-lg-12 mt-1" style="text-align: center">
                    <asp:Label runat="server" CssClass="h6">12/04/2020</asp:Label>
                </div>
            </div>
        </section>

        <section>
            <nav class="nav nav-tabs mb-30">
                <a href="Caravana_Criador.aspx" class="nav-item nav-link" style="color: #495057 !important">
                    <i class="fa fa-file-alt mr-1"></i>Visualização Geral
                </a>
                <a href="Visualizar_proposta.aspx" class="nav-item nav-link" style="color: #495057 !important">
                    <i class="fa fa-dollar-sign mr-1"></i>Propostas recebidas
                </a>
                <a href="#" class="nav-item nav-link active">
                    <i class="fa fa-envelope mr-1"></i>Convites
                </a>
                <a href="#" class="nav-item nav-link" style="color: #495057 !important">
                    <i class="fa mr-1"></i>Editar informações
                </a>
            </nav>
        </section>

        <div class="card bg-light card border border-dark">
            <div class="card-body">
                <div class="card-title">
                    <h3>Convites
                    </h3>
                    <hr />
                </div>

                <div class="container">

                    <div class="row">

                        <div class="row col-lg-7 col-12">

                            <p>
                                <asp:Label runat="server" ID="lblusu">Nome do Usuário</asp:Label>
                            </p>

                        </div>
                        <br class="d-none d-sm-block" />
                        <div class="row col-lg-5 col-12 mt  ">
                            <div class="row col-lg-6 col-5">
                                <asp:Button runat="server" ID="Button3" CssClass="genric-btn info btn-block" Text="Aceitar" />
                            </div>
                            <div class="row offset-1 col-lg-6 col-5">
                                <asp:Button runat="server" ID="Button4" CssClass="genric-btn danger btn-block" Text="Aceitar" />
                            </div>
                        </div>
                    </div>
                    <hr />
                </div>

            </div>
        </div>
    </div>
</asp:Content>

