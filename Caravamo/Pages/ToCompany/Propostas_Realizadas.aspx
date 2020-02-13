<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Propostas_Realizadas.aspx.cs" Inherits="Pages_ToCompany_Propostas_Realizadas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container col-11 mt-3 ">
        <div class="Container text-center mb-3">
            <h1>Histórico de Viagens</h1>
        </div>
        <div class="container ">
            <div class="row">
                <div class=" col-lg-4 col-md-6 col-sm-6 col-12  mb-lg-4 mb-4">
                    <!--CARD-->

                    <asp:LinkButton ID="card" runat="server" OnClick="card_Click">
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
                                    <asp:Label runat="server" CssClass="genric-btn primary w-100" Text="Aguardando" />

                                </div>
                            </div>
                        </div>
                    </asp:LinkButton>


                </div>

                <div class=" col-lg-6 col-md-6 col-sm-12 col-12   mb-lg-4 mb-4">
                </div>
            </div>
        </div>

    </div>
    <div class="modal fade " id="myModal">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <!-- Modal Header -->
                <div class="modal-header">
                    <h3>
                        <asp:Label runat="server">Título da Caravana</asp:Label>

                    </h3>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <!-- Modal body -->
                <div class="container col-12 mt-4 ">
                    <div class="container col-xl-10 col-lg-10 col-12">
                        <div class="col-12 text-center mb-1 mt-2">
                            <h3>Proposta Feita</h3>

                        </div>
                        <div class="container col mt-3">
                            <div class="container col-lg-12 col-md-12 col-12">
                                <div class="container col-lg-12 ">

                                    <div class="row">
                                        <div class="row col-lg-6 col-md-12 col-12 ">
                                            <div class="container col-lg-4 col-md col-4  ">
                                                <img src="../../img/Vehicles_and_cars_02-512.png" style="max-height: 40px;" />
                                            </div>
                                            <div class="row col-lg-8 col-md-8 col-8 ">
                                                <h2>Veículo</h2>
                                            </div>

                                            <div class="col-lg-6 col-md-12">
                                                <img src="../../img/1498585513-sprinter-415-van-15-1-k42e--b-.jpg" />
                                            </div>
                                            <div class="col-lg-6 text-center mb-5 mb-lg-0">
                                                <p>
                                                    <asp:Label runat="server" ID="lblVeiculo">Nome do Carro</asp:Label>
                                                </p>
                                            </div>
                                        </div>
                                        <span class="border-right d-none d-lg-block"></span>
                                        <div class="row col-lg-6 col-md-12 col-12 ">
                                            <div class="container col-lg-4 col-md col-4  ">
                                                <img src="../../img/Motorista.png" style="max-height: 40px;" />
                                            </div>
                                            <div class="row col-lg-8 col-md-8 col-8 ">
                                                <h2>Motorista</h2>
                                            </div>

                                            <div class="col-lg-6 col-md-12">
                                                <img src="../../img/1498585513-sprinter-415-van-15-1-k42e--b-.jpg" />
                                            </div>
                                            <div class="col-lg-6 text-center mb-5 mb-lg-0">
                                                <p>
                                                    <asp:Label runat="server" ID="Label1">Nome do Motorista</asp:Label>
                                                </p>
                                            </div>
                                        </div>

                                    </div>
                                </div>

                            </div>
                            <hr />
                            <div class="form-group ">
                                <div class=" row col-lg-12 text-center">

                                    <div class="col-lg-8">

                                        <h2><i class="fa fa-money-bill-alt fa-1x m-2"></i>Valor da Proposta</h2>
                                    </div>

                                    <div class="col-lg-4">
                                        <h1>
                                            <asp:Label runat="server" ID="lblValor">2000,00R$</asp:Label>
                                        </h1>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class="col-lg-6">
                            <!-- <asp:Button runat="server" ID="btnLink" Text="Ir para a página da Caravana" CssClass="genric-btn info" />-->
                        </div>
                    </div>

                </div>
                <!-- Modal footer -->
                <div class="modal-footer mt-3">
                    <div class="container text-center">
                        <div class="row ">

                            <div class="col-lg-6  col-12 mt-2">
                                <h4>
                                    <!--   <asp:Label runat="server">30 Pessoas demonstraram interesse</asp:Label></h4>-->
                            </div>
                            <div class="col-lg-6 col-12">
                                <asp:Button runat="server" CssClass="genric-btn primary btn-more btn-block mt-2 mt-lg-0" Text="Aguardando" />

                            </div>

                        </div>


                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Modal FIM -->

    <script src="../../js/jquery-3.3.1.min.js"></script>
    <script src="../../js/bootstrap.min.js"></script>
    <script>


        swal("Em construção","Prepare-se para novidades! :)")
            .then((value) => 
                {
                    window.location.replace('Home_emp.aspx');
                });

    </script>


</asp:Content>

