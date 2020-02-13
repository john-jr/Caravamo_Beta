<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Vehicles.aspx.cs" Inherits="Pages_ToCompany_Vehicle" %>

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
        .modal-dialog{
            margin-top: 10px;
        }

    </style>
    <div class="row" style="margin: 0">
        <div class="col-md-12 text-center mt-5">

            <h2>Lista de Veículos</h2>
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
                                <h4 class="mb-1">Placa: </h4>
                                <asp:TextBox ID="txt_placa" runat="server" CssClass="form-control" Style="height: calc(1.5em + .75rem + 5px)"> </asp:TextBox>
                            </div>
                            <div class="col-lg-6 offset-lg-3 col-12">
                                <br />


                                <h4 class="mb-1">Ano: </h4>
                                <asp:DropDownList runat="server" ID="ddl_ano" CssClass="form-control ">
                                    <asp:ListItem Value="90">1990</asp:ListItem>
                                    <asp:ListItem Value="91">1991</asp:ListItem>
                                    <asp:ListItem Value="92">1992</asp:ListItem>
                                    <asp:ListItem Value="93">1993</asp:ListItem>
                                    <asp:ListItem Value="94">1994</asp:ListItem>
                                    <asp:ListItem Value="95">1995</asp:ListItem>
                                    <asp:ListItem Value="96">1996</asp:ListItem>
                                    <asp:ListItem Value="97">1997</asp:ListItem>
                                    <asp:ListItem Value="98">1998</asp:ListItem>
                                    <asp:ListItem Value="99">1999</asp:ListItem>
                                    <asp:ListItem Value="00">2000</asp:ListItem>
                                    <asp:ListItem Value="01">2001</asp:ListItem>
                                    <asp:ListItem Value="02">2002</asp:ListItem>
                                    <asp:ListItem Value="03">2003</asp:ListItem>
                                    <asp:ListItem Value="04">2004</asp:ListItem>
                                    <asp:ListItem Value="05">2005</asp:ListItem>
                                    <asp:ListItem Value="06">2006</asp:ListItem>
                                    <asp:ListItem Value="07">2007</asp:ListItem>
                                    <asp:ListItem Value="08">2008</asp:ListItem>
                                    <asp:ListItem Value="09">2009</asp:ListItem>
                                    <asp:ListItem Value="10">2010</asp:ListItem>
                                    <asp:ListItem Value="11">2011</asp:ListItem>
                                    <asp:ListItem Value="12">2012</asp:ListItem>
                                    <asp:ListItem Value="13">2013</asp:ListItem>
                                    <asp:ListItem Value="14">2014</asp:ListItem>
                                    <asp:ListItem Value="15">2015</asp:ListItem>
                                    <asp:ListItem Value="16">2016</asp:ListItem>
                                    <asp:ListItem Value="17">2017</asp:ListItem>
                                    <asp:ListItem Value="18">2018</asp:ListItem>
                                    <asp:ListItem Value="19" Selected="True">2019</asp:ListItem>
                                </asp:DropDownList>
                            </div>


                            <div class="col-lg-6 offset-lg-3 col-12" id="tipoV">
                                <br />
                                <h4 class="mb-1">Tipo: </h4>
                                <asp:RadioButtonList runat="server" ID="rbl_tipoVeiculo" RepeatDirection="Horizontal">
                                    <asp:ListItem Value="V">Van</asp:ListItem>
                                    <asp:ListItem Value="M">Micro-ônibus</asp:ListItem>
                                    <asp:ListItem Value="O">Ônibus</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>

                             <div class="col-lg-6 offset-lg-3 col-12">
                                <br />
                                <h4 class="mb-1">Marca: </h4>
                                <asp:TextBox ID="txt_marca" runat="server" CssClass="form-control" Style="height: calc(1.5em + .75rem + 5px)"> </asp:TextBox>
                            </div>
                             <div class="col-lg-6 offset-lg-3 col-12">
                                <br />
                                <h4 class="mb-1">Modelo: </h4>
                                <asp:TextBox ID="txt_modelo" runat="server" CssClass="form-control" Style="height: calc(1.5em + .75rem + 5px)"> </asp:TextBox>
                            </div>
                              <div class="col-lg-6 offset-lg-3 col-12">
                                <br />
                                <h4 class="mb-1">Quantidade de Assentos: </h4>
                                <asp:TextBox ID="txt_qntAssentos" runat="server" TextMode="Number" CssClass="form-control" Style="height: calc(1.5em + .75rem + 5px)"> </asp:TextBox>
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


    <div class="row" style="margin: 0"> 
          <asp:PlaceHolder ID="plh_status" runat="server"></asp:PlaceHolder>  
    </div>
         





    



      <div class="row" style="margin: 0"> 
           
            <div class="col-md-3 offset-md-9 col-12 text-center">
                <asp:LinkButton runat="server" ID="LinkButton1" OnClick="btn_AdicionarVeiculos_Click" CssClass="genric-btn primary mt-sm-3 w-100">
                    <i class="fa fa-plus-circle"></i>
                   &nbsp; Adicione um novo veiculo
                </asp:LinkButton>
            </div>
        </div>

       <script src="../../js/jquery-3.3.1.min.js"></script>
        <script src="../../js/popper.min.js"></script>
    <script src="../../js/bootstrap.min.js"></script>



</asp:Content>

