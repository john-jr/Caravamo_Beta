<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Propostas_Realizadas.aspx.cs" Inherits="Pages_ToCompany_Propostas_Realizadas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container col-11 mt-3 ">
        <div class="Container text-center mb-3">
            <h1>Propostas Realizadas</h1>
        </div>
        <div class="container ">
            <div class="row">
                
                 <asp:PlaceHolder runat="server" ID="plh_propostas"></asp:PlaceHolder>

            </div>
        </div>

    </div>
    <div class="modal fade " id="myModal">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <!-- Modal Header -->
                <div class="modal-header">
                    <h3>
                        <asp:Label runat="server" ID="lbl_caravana"></asp:Label>

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
                                                  <h5>Placa:</h5> <asp:Label runat="server" ID="lbl_Placa"></asp:Label>
                                                </p>
                                                <p class="mt-1">
                                                  <h5>Marca:</h5> <asp:Label runat="server" ID="lbl_Marca">jhlkjhlkjhh</asp:Label>
                                                </p>
                                              
                                                 <p class="mt-1">
                                                  <h5>Ano:</h5> <asp:Label runat="server" ID="lbl_Ano">kljhlkhj</asp:Label>
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
                                                <img src="../../img/index_images/noimg.png" />
                                            </div>
                                            <div class="col-lg-6 text-center mb-5 mb-lg-0">
                                                <p>
                                               <h5>Nome:</h5><asp:Label runat="server" ID="lbl_nome">jgkhfghjfjhgfjhgfhgjfjhfjhgfhjgfhjfhjfjhfjhfjhfhjfhjfhjfjhfjhf</asp:Label>
                                                </p>
                                                 <p class="mt-1">
                                               <h5>Idade:</h5><asp:Label runat="server" ID="lbl_idade">51 Anos</asp:Label>
                                                </p>
                                            </div>
                                        </div>

                                    </div>
                                </div>

                            </div>
                            <hr />
                            <div class="form-group ">
                                <div class=" row text-center" style="padding:0">

                                    <div class="col-lg-12 text-center">

                                        <h3><i class="fa fa-money-bill-alt fa-1x m-2"></i>Valor da Proposta: R$ <asp:Literal runat="server"  ID="lblValor">2000,00</asp:Literal></h3>
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
                <div class="modal-footer">
                    <div class="container text-center">
                        <div class="row ">

                            <div class="col-lg-6  col-12 mt-2">
                                <h4>
                                    <!--   <asp:Label runat="server">30 Pessoas demonstraram interesse</asp:Label></h4>-->
                            </div>
                            <div class="col-lg-6 col-12">
                                <asp:Button runat="server" CssClass="genric-btn primary btn-more btn-block mt-2 mt-lg-0" OnClick="Unnamed_Click" Text="Ir para a página da Caravana" />

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
  

</asp:Content>

