<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="Convite.aspx.cs" Inherits="Convite" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
      <link rel="stylesheet" href="../../css/toastr.min.css" />

    <div class="container">

        <section class="container mb-30">
            <div class="row">
                <div class="col-lg-12 mt-30" style="text-align: center">
                    <asp:Label runat="server" ID="lbl_titulo" CssClass="h2">Título da Caravana</asp:Label>
                </div>
                <div class="col-lg-12 mt-1" style="text-align: center">
                    <asp:Label runat="server" ID="lbl_DataHoraSaida" CssClass="h6">12/04/2020</asp:Label>
                </div>
            </div>
        </section>

        <section>
            <nav class="nav nav-tabs mb-30">
                <a href="Caravana_Criador.aspx" class="nav-item nav-link" style="color: #495057 !important">
                    <i class="fa fa-file-alt mr-1"></i>Visualização Geral
                </a>
                <a href="Visualizar_proposta.aspx" class="nav-item nav-link" runat="server" id="propostas" style="color: #495057 !important">
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
                    <h3>Link de Convite da Caravana
                    </h3>
                </div>

                <div class="container">
                    <div class="row">
                        <div class="row col-lg-12 col-12 ">
                            <div class="row col-lg-9 col-9">
                                <asp:TextBox ID="ltl_linkCaravana" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="row  offset-lg-1 col-lg-2 col-2 mb-1">
                                <button id="btn_copiar" class="genric-btn primary btn-block" type="button" onclick="copy();">Copiar</button>
                                <%--   <asp:Button runat="server" ID="btn_copiar" Cssclass="genric-btn primary btn-block"  OnClick="btn_copiar_Click"></asp:Button>--%>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </div>

        <br />








        <div class="card bg-light card border border-dark">
            <div class="card-body">
                <div class="card-title">
                    <h3>Convites Aguardando Aprovação
                    </h3>
                    <hr />
                </div>

                  <asp:PlaceHolder ID="plh_status" runat="server"></asp:PlaceHolder>  


            



            </div>
        </div>
    </div>
    <script src="../../js/jquery-1.12.1.min.js"></script>
    <script src="../../js/bootstrap.min.js"></script>


    <script src="https://unpkg.com/@popperjs/core@2/dist/umd/popper.min.js"></script>
    <script src="https://unpkg.com/tippy.js@6/dist/tippy-bundle.umd.js"></script>
     <script src="../../js/toastr.js"></script>

    <script>
        function copy() {
            var copyText = document.getElementById("<%= ltl_linkCaravana.ClientID%>");

    copyText.select();
    copyText.setSelectionRange(0, 99999);
    document.execCommand("copy");
    document.getElementById("<%= ltl_linkCaravana.ClientID%>").blur();


        }
    </script>
    <script>
        tippy('#btn_copiar', {
            placement: 'bottom',
            trigger: 'click',
            content: 'Copiado!'
        });
    </script>
    <asp:Literal runat="server" ID="javascript"></asp:Literal>


</asp:Content>

