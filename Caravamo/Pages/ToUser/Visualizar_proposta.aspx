    <%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="Visualizar_proposta.aspx.cs" Inherits="Visualizar_proposta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


   <link rel="stylesheet" href="../../css/toastr.min.css" />
    <style>
        .linha-vertical {
            height: 250px; /*Altura da linha*/
            border-left: 1px solid; /* Adiciona borda esquerda na div como ser fosse uma linha.*/
        }
    </style>
   


    <div class="container col-lg-11">
        
        <section class="container mb-30">
            <div class="row">
                <div class="col-lg-12 mt-30" style="text-align: center">
                    <asp:Label runat="server" CssClass="h2" ID="lbl_titulo">Título da Caravana</asp:Label>
                </div>
                <div class="col-lg-12 mt-1" style="text-align: center">
                    <asp:Label runat="server" CssClass="h6" ID="lbl_DataHoraSaida">12/04/2020</asp:Label>
                </div>
            </div>
        </section>

        <section>
            <nav class="nav nav-tabs mb-30">
                <a href="Caravana_Criador.aspx" class="nav-item nav-link" style="color: #495057 !important">
                    <i class="fa fa-file-alt mr-1"></i>Visualização Geral
                </a>
                <a href="#" class="nav-item nav-link active">
                    <i class="fa fa-dollar-sign mr-1"></i>Propostas recebidas
                </a>
                <a href="Convite.aspx" class="nav-item nav-link" style="color: #495057 !important">
                    <i class="fa fa-envelope mr-1"></i>Convites
                </a>
                <a href="#" class="nav-item nav-link" style="color: #495057 !important">
                    <i class="fa mr-1"></i>Editar informações
                </a>
            </nav>
        </section>

        <div class="row">
            <div class="container col-lg-2 d-none d-xl-block">
                <div class="card">
                    <div class="card-header text-center">
                        <div class="row">
                            <div style="padding-left: 15px;margin-top:5px">
                                <i class="fa fa-filter fa-lg" aria-hidden="true"></i>
                              
                            </div>
                            <div class="col-lg-8 col-2 ">
                                <h3>Filtros</h3>
                            </div>
                        </div>
                    </div>
                    <div class="card-body">
                        <asp:RadioButtonList runat="server" ID="rblFiltro">
                            <asp:ListItem Text="&nbsp Menor Preço " Selected="True" Value="M"> </asp:ListItem>
                            <asp:ListItem Text=" &nbsp Mais Recente " Value="R"> </asp:ListItem>
                            <asp:ListItem Text=" &nbsp Mais Antiga " Value="A"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="card-footer">

                        <div class="container">
                            <asp:Button runat="server" CssClass=" primary-border genric-btn btn-block" Text="Filtrar" />
                        </div>
                    </div>
                </div>
            </div>


            <div class="container col-lg-9">
                <div class=" container col-lg-11 col-md-10 ">
                    
                  <asp:PlaceHolder runat="server" ID="phl_propostas"></asp:PlaceHolder>

                    
                </div>


                
            </div>
        </div>



    </div>
    <div class="modal fade" id="Modalcontra">
        <div class="modal-dialog modal-md">
            <div class="modal-content">
                <!-- Modal Header -->
                <div class="modal-header">
                    <h3>Contraproposta</h3>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <!-- Modal body -->
                <div class="container col-11 mt-4 ">
                    <div class="row col-lg-12">
                        <div class="col-lg-6 col-md-6">
                            <p>
                                Contraproposta para:
                            </p>
                        </div>
                        <div class="col-lg-6 col-md-6">
                            <p>
                                <asp:Label runat="server">GT Tur SA </asp:Label>
                            </p>
                        </div>
                    </div>
                    <div class="row mt-2 col-lg-12">
                        <div class="col-lg-6 col-md-6">
                            <p>
                                Proposta Recebida:
                            </p>
                        </div>
                        <div class="col-lg-6 col-md-6">
                            <p>
                                <asp:Label runat="server">R$159,00 </asp:Label>
                            </p>
                        </div>
                    </div>
                    <div class="row mt-2 col-lg-12">
                        <div class="col-lg-6 col-md-5 ">
                            <p>
                                Contraproposta(R$):
                            </p>
                        </div>
                        <div class="col-lg-6 col-md-7">
                            <div class="input-group mb-3">
                                <div class="input-group-prepend">
                                    <span class="input-group-text">R$</span>
                                </div>
                                <asp:TextBox runat="server" ID="txtValor" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                <div class="input-group-append">
                                    <span class="input-group-text">.00</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row col-lg-12">
                        <div class="col-lg-5 col-md-5 ">
                            <p>
                                Observação:
                            </p>
                        </div>
                        <div class="col-lg-12 col-md-12">
                            <div class="form-group">
                                <asp:TextBox runat="server" ID="txtOb" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                </div>
                <!-- Modal footer -->
                <div class="modal-footer ">
                    <div class=" col-lg-4 col-md-8 ">
                        <asp:Button runat="server" ID="btnEnviar" CssClass="genric-btn success btn-block float-right" Text="Enviar" />



                    </div>
                </div>
            </div>
        </div>
    </div>
   
    <link rel="icon" href="../../img/favicon.png" />
    
  
    <script src="../../js/jquery-1.12.1.min.js"></script>
      <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/toastr.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
  
   <asp:Literal runat="server" ID="ltl_status"></asp:Literal>
       
    

</asp:Content>

