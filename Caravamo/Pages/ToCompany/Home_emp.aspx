﻿<%@ Page Title="" Language="C#" MasterPageFile="../../Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Home_emp.aspx.cs" Inherits="Home_emp" %>

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

        .card-title {
            text-align: center;
        }
    </style>

    <br />
    <div class="container mt-3">
        <div class="container text-center">
            <h1><asp:Label runat="server" ID="lbl_nomeEmp">...</asp:Label></h1>
        </div>

        <div class="container ">
            <!-- Propostas -->
            <div class="container">
                <div class="row">
                    <div class="col-lg-11  mb-lg-3">
                        <h2>Ultimas propostas realizadas</h2>
                    </div>
                </div>
                <div class="row">
                    <div class=" col-lg-4 col-md-6 col-sm-6 col-12  mb-lg-4 mb-4">
                        <!--CARD-->
                        <a href="#">
                            <div class="card">
                                <div class="card-body">
                                    <div class="card-title h5 text-center">

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
                                    <br />
                                    <div class="container">
                                        <asp:Button runat="server" CssClass="genric-btn primary btn-more form-control" Text="Aguardando" />

                                    </div>
                                </div>
                            </div>
                        </a>

                    </div>

                    <div class=" col-lg-4 col-md-6  col-sm-6 col-12   mb-lg-4 mb-4">
                        <!--CARD-->
                        <a href="#">
                            <div class="card">
                                <div class="card-body">
                                    <div class="card-title h5 text-center">
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
                                    <br />
                                    <div class="container">
                                        <asp:Button runat="server" CssClass="genric-btn btn-success btn-more form-control" Text="Aceita" />

                                    </div>
                                </div>
                            </div>
                        </a>

                    </div>


                    <div class=" col-lg-4 col-md-6  col-sm-6 col-12   mb-lg-4 mb-4">
                        <!--CARD-->
                        <a href="#">
                            <div class="card">
                                <div class="card-body">
                                    <div class="card-title h5 text-center">

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
                                    <br />
                                    <div class="container">
                                        <asp:Button runat="server" CssClass="genric-btn danger btn-more form-control" Text="Recusada" />

                                    </div>
                                </div>
                            </div>
                        </a>

                    </div>


                    <div class="col-lg-12">
                        <a href="#">
                            <h6 class="float-right">Ver todas as propostas</h6>
                        </a>
                    </div>

                </div>


                <hr />
            </div>
            <br />
            <!-- Proximas Viagens -->
            <div class="container">
                <div class="row">

                    <div class="col-lg-11 mt-lg-2 mb-lg-3">
                        <h2>Próximas viagens</h2>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-4 col-sm-6 mb-lg-2 mb-4">
                        <!--CARD-->
                        <div class="card">
                            <div class="card-body">
                                <div class="card-title text-center h5">
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
                                <br />
                                <div class="container">
                                    <asp:Button runat="server" CssClass="genric-btn primary btn-more form-control " Text="Ver mais" />
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-4 col-sm-6 lg-2 mb-4">
                        <!--CARD-->
                        <div class="card">
                            <div class="card-body">
                                <div class="card-title text-center h5">
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

                                <br />
                                <div class="container">
                                    <asp:Button runat="server" CssClass="genric-btn primary btn-more form-control " Text="Ver mais" />
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-4 col-sm-6 lg-2 mb-4">
                        <!--CARD-->
                        <div class="card">
                            <div class="card-body">
                                <div class="card-title text-center h5">
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

                                <br />
                                <div class="container">
                                    <asp:Button runat="server" CssClass="genric-btn primary btn-more form-control " Text="Ver mais" />
                                </div>
                            </div>
                        </div>
                    </div>


                    <div class="col-lg-12">
                        <a href="#">
                            <h6 class="float-right">Ver todas as viagens</h6>
                        </a>
                    </div>

                </div>
                <hr />
            </div>


            <!-- Requisições -->
            <div class="container">
                <div class="row">
                    <div class="col-lg-11  mt-lg-2 mb-lg-3">
                        <h2>Novas requisições</h2>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-4 col-sm-6  mb-lg-2 mb-4">
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

                                <br />
                                <div class="container">
                                    <asp:Button runat="server" CssClass="genric-btn primary btn-more form-control" Text="Ver mais" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-sm-6 lg-2 mb-4">
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

                                <br />
                                <div class="container">
                                    <asp:Button runat="server" CssClass="genric-btn primary btn-more form-control" Text="Ver mais" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-sm-6 lg-2 mb-4">
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

                                <br />
                                <div class="container">
                                    <asp:Button runat="server" CssClass="genric-btn primary btn-more form-control" Text="Ver mais" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-12">
                        <a href="Requisicoes.aspx">
                            <h6 class="float-right">Ver todas as requisições</h6>
                        </a>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <br />
    <footer class="footer_part">
        <div class="container ">

            <hr />
            <div class="row ">
                <div class="col-lg-12  ">
                    <div class="copyright_text">
                        <p>
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                            Este site tem como propósito apresentar um trabalho acadêmico. Todas suas
                            informações aqui distribuídas podem ou não serem de cunho verídico. Não há nenhum
                            vínculo com autor ou empresa real.<a />
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        </p>
                    </div>
                </div>

            </div>
        </div>
    </footer>



</asp:Content>

