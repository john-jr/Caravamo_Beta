<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Drivers.aspx.cs" Inherits="Pages_ToCompany_Drivers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <style>
        .btn-more {
            font-size: medium;
        }

        .m {
            color: white;
        }

            .m:hover {
                color: black;
            }

        #tipoV td {
            padding-left: 30px;
        }

        .modal-dialog {
            margin-top: 10px;
        }
    </style>
    <div class="row" style="margin: 0">

        <div class="col-md-12 text-center mt-5">

            <h2>Lista de Motoristas</h2>
        </div>
    </div>


    <div class="row" style="margin: 0">
        <asp:PlaceHolder ID="plh_status" runat="server"></asp:PlaceHolder>
    </div>



    <div class="row" style="margin: 0">

        <div class="col-md-3 offset-md-9 col-12 mt-3 text-center">
            <asp:LinkButton runat="server" ID="btn_AdicionarMotoristas" OnClick="btn_AdicionarMotoristas_Click" CssClass="genric-btn primary w-100">
                     <i class="fa fa-user-plus"></i>
                   &nbsp; Adicione um novo motorista
            </asp:LinkButton>
        </div>
    </div>


     <div class="container">
        <div class="modal fade" tabindex="-1" id="loginModal">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5>Editar Informações</h5>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>

                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-lg-6 offset-lg-3 col-12">
                                <br />
                                <h4 class="mb-1">Nome completo: </h4>
                                <asp:TextBox ID="txt_nome" runat="server" CssClass="form-control" Style="height: calc(1.5em + .75rem + 5px)"> </asp:TextBox>
                            </div>
                          
                            <div class="col-lg-6 offset-lg-3 col-12" id="tipoV">
                                <br />
                                <h4 class="mb-1">Gênero: </h4>
                              <asp:RadioButtonList runat="server" ID="rbl_sexo" RepeatDirection="Vertical">
                    <asp:ListItem Value="M" Selected="True">Masculino</asp:ListItem>
                    <asp:ListItem Value="F">Feminino</asp:ListItem>
                    <asp:ListItem Value="O">Outro</asp:ListItem>
                </asp:RadioButtonList>
                            </div>

                                 <div class="col-lg-6 offset-lg-3 col-12">
                                <br />
                                <h4 class="mb-1">Data de Nascimento: </h4>
                                <asp:TextBox ID="txt_nasc" runat="server" TextMode="Date" CssClass="form-control" Style="height: calc(1.5em + .75rem + 5px)"> </asp:TextBox>
                            </div>


                              <div class="col-lg-6 offset-lg-3 col-12">
                                <br />
                                <h4 class="mb-1">E-mail: </h4>
                                <asp:TextBox ID="txt_email" runat="server" TextMode="Email" CssClass="form-control" Style="height: calc(1.5em + .75rem + 5px)"> </asp:TextBox>
                            </div>


                        </div>
                    </div>
                     <div class="modal-footer" style="display: flex;justify-content: space-between">
                          <asp:Button runat="server" type="submit" CssClass="genric-btn danger" style="width:30%;" Text="Cancelar" ID="btn_Cancelar"/>
                         <asp:Label ID="lbl_id" runat="server" style="font-size:.1px"></asp:Label>               
                         <asp:Button runat="server" type="submit" CssClass="genric-btn info" style="width:30%;" Text="Salvar"  ID="btn_ConfirmarEdicao" OnClick="btn_ConfirmarEdicao_Click" />
                        
                        
                    </div>
                </div>
            </div>
        </div>
    </div>


    <script src="../../js/jquery-3.3.1.min.js"></script>
    <script src="../../js/popper.min.js"></script>
    <script src="../../js/bootstrap.min.js"></script>

</asp:Content>

