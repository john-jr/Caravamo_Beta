<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="Home_User.aspx.cs" Inherits="Pages_ToUser_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>
        .link-color {
            color: black;
        }

        .btn-more {
            font-size: medium;
        }

        .row {
            margin-left: 0;
            margin-right: 0;
        }
    </style>

    <section>
        <div class="container-fluid">
            <div class="row mt-4">
                <h3 class="col-lg-12 text-center">Pesquise por uma caravana...</h3>
                <div class="col-lg-12">
                    <div class="col-lg-8 input-group offset-lg-2">
                        <asp:LinkButton runat="server" BorderColor="#f8f9fa" BorderStyle="none" BorderWidth="0px" Style="background-color: white; padding: 8px; padding-top: 10px !important;">
                            <i class="fa fa-search" style="color: black"></i>
                        </asp:LinkButton>
                        <asp:TextBox type="search" runat="server" CssClass="form-control border-2 bg-light mt-1"></asp:TextBox>
                    </div>
                </div>
                <br />
                <br />
                <div class="col-lg-12 text-center mt-lg-1 mb-lg-3">
                    <p style="font-size: 17px"><a href="Create_Caravan_1.aspx" class="text-center link-color">...ou crie a sua!</a></p>
                </div>
            </div>
        </div>
    </section>
    <br />
    <section>
        <div class="row">
            <div class="col-lg-11 offset-lg-1 mb-lg-3">
                <h3>Minhas caravanas</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-3 offset-lg-1 mb-lg-4 mb-4">
                <!--CARD-->
                <div class="card">
                    <div class="card-body">
                        <div class="card-title h5">
                            <asp:Label runat="server">BGS 2019</asp:Label>
                            <hr />
                        </div>
                        <div class="card-text">
                            <p>
                                <asp:Label runat="server">São Paulo</asp:Label>
                            </p>
                        </div>
                        <div class="card-text">
                            <p>
                                <asp:Label runat="server">20 de outubro</asp:Label>
                            </p>
                        </div>
                        <asp:Button runat="server" CssClass="genric-btn primary btn-more float-lg-right" Text="Ver mais" />
                    </div>
                </div>
            </div>
        </div>
    </section>
    <br />
    <section>
        <div class="row">
            <div class="col-lg-11 offset-lg-1 mt-lg-2 mb-lg-3">
                <h3>Recentes</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-3 offset-lg-1 mb-lg-2 mb-4">
                <!--CARD-->
                <div class="card">
                    <div class="card-body">
                        <div class="card-title h5">
                            <asp:Label runat="server">BGS 2019</asp:Label>
                            <hr />
                        </div>
                        <div class="card-text">
                            <p>
                                <asp:Label runat="server">São Paulo</asp:Label>
                            </p>
                        </div>
                        <div class="card-text">
                            <p>
                                <asp:Label runat="server">20 de outubro</asp:Label>
                            </p>
                        </div>
                        <asp:Button runat="server" CssClass="genric-btn primary btn-more float-lg-right" Text="Ver mais" />
                    </div>
                </div>
            </div>
            <div class="col-lg-3 mb-4">
                <!--CARD-->
                <div class="card">
                    <div class="card-body">
                        <div class="card-title h5">
                            <asp:Label runat="server">BGS 2019</asp:Label>
                            <hr />
                        </div>
                        <div class="card-text">
                            <p>
                                <asp:Label runat="server">São Paulo</asp:Label>
                            </p>
                        </div>
                        <div class="card-text">
                            <p>
                                <asp:Label runat="server">20 de outubro</asp:Label>
                            </p>
                        </div>
                        <asp:Button runat="server" CssClass="genric-btn primary btn-more float-lg-right" Text="Ver mais" />
                    </div>
                </div>
            </div>
            <div class="col-lg-3 mb-4">
                <!--CARD-->
                <div class="card">
                    <div class="card-body">
                        <div class="card-title h5">
                            <asp:Label runat="server">BGS 2019</asp:Label>
                            <hr />
                        </div>
                        <div class="card-text">
                            <p>
                                <asp:Label runat="server">São Paulo</asp:Label>
                            </p>
                        </div>
                        <div class="card-text">
                            <p>
                                <asp:Label runat="server">20 de outubro</asp:Label>
                            </p>
                        </div>
                        <asp:Button runat="server" CssClass="genric-btn primary btn-more float-lg-right" Text="Ver mais" />
                    </div>
                </div>
            </div>
            <div class="col-lg-10">
                <a href="#">
                    <h6 class="float-right">Ver todas as caravanas</h6>
                </a>
            </div>
        </div>
    </section>
    <br />
    <section>
        <div class="row">
            <div class="col-lg-11 offset-lg-1 mt-lg-2 mb-lg-3">
                <h3>Rankings</h3>
            </div>
        </div>
        <div class="row">
            <div class="card col-lg-5 offset-lg-1 mb-4" style="border: hidden">
                <!--RANKING 1-->
                <div class="card-header">
                    <strong>Empresas com maior avaliação</strong>
                </div>
                <ul class="list-group list-group-flush">
                    <li class="list-group-item">
                        <asp:Label runat="server">Empresa 1</asp:Label>
                    </li>
                    <li class="list-group-item">
                        <asp:Label runat="server">Empresa 2</asp:Label>
                    </li>
                    <li class="list-group-item">
                        <asp:Label runat="server">Empresa 3</asp:Label>
                    </li>
                </ul>
            </div>
            <div class="card col-lg-5 mb-lg-4" style="border: hidden">
                <!--RANKING 2-->
                <div class="card-header">
                    <strong>Destinos mais visitados</strong>
                </div>
                <ul class="list-group list-group-flush">
                    <li class="list-group-item">
                        <asp:Label runat="server">Campos do Jordão</asp:Label>
                    </li>
                    <li class="list-group-item">
                        <asp:Label runat="server">São Paulo</asp:Label>
                    </li>
                    <li class="list-group-item">
                        <asp:Label runat="server">Belo Horizonte</asp:Label>
                    </li>
                </ul>
            </div>
        </div>
        <br />
        <br />
        <br />
    </section>


</asp:Content>

