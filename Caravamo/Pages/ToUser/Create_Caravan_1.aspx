<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="Create_Caravan_1.aspx.cs" Inherits="Pages_ToUser_Create_Caravan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="../../css/steps.css" rel="stylesheet" />
    <div class="container">
        <div class="mt-5 mb-5 text-center">
            <h2>Criar Caravana</h2>
        </div>
        <ul class="step d-flex flex-nowrap">
            <li class="step-item active">
                <a href="#!" class="">Título e Descrição</a>
            </li>
            <li class="step-item">
                <a href="Create_Caravan_2.aspx" class="">Endereços</a>
            </li>
            <li class="step-item">
                <a href="Create_Caravan_3.aspx" class="">Datas</a>
            </li>
            <li class="step-item">
                <a href="Create_Caravan_4.aspx" class="">Categoria</a>
            </li>
            <li class="step-item">
                <a href="Create_Caravan_5.aspx" class="">Confirmar</a>
            </li>
        </ul>
    </div>
    <br />
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-3 col-lg-3 col-xl-3 col-12 text-lg-right text-md-right">
                <label>Título da Caravana:</label>
            </div>
            <div class="col-md-8 col-lg-8 col-xl-8 col-12">
                <asp:TextBox runat="server" ID="txt_tituloCaravana" CssClass="form-control" onkeypress="return AllowAlphabet(event)"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3 col-lg-3 col-xl-3 text-lg-right text-md-right pt-4">
                <label>Tipo:</label>
            </div>
            <div class="col-md-8 col-lg-8 col-xl-8 col-12 pt-lg-4 pt-md-4 pt-0 ml-4 ml-lg-0 ml-md-0">
                <asp:RadioButton ID="rbtn_publica" Text="Pública" Checked="True" GroupName="tipo" runat="server" /><br />
                <asp:RadioButton ID="rbtn_privada" Text="Privada" GroupName="tipo" runat="server" /><br />
            </div>
        </div>
        <div class="row">
            <div class="col-md-3 text-lg-right text-md-right pt-3">
                <label>Descrição da Caravana:</label>
            </div>
            <div class="col-md-8 mt-lg-4">
                <asp:TextBox ID="txt_descricao" Rows="5" Columns="105" TextMode="multiline" CssClass="form-control" Style="resize: none" runat="server" />
            </div>
        </div>

    </div>
    <br />
    <hr />



    <div class="container">
        <div class="row">
            <div class="col-4 text-center">
                <asp:Literal runat="server" ID="ltl_status"></asp:Literal>
                <asp:Button runat="server" ID="btn_cancelar"  OnClick="btn_cancelar_Click" Text="Cancelar" CssClass="genric-btn danger" />
            </div>
            <div class="col-4">
            </div>

            <div class="col-4">
                <div class="ml-lg-5 ml-md-5 ml-0">
                    <asp:LinkButton runat="server" ID="btnAvancar1" OnClick="btnAvancar1_Click" class="genric-btn info ml-lg-5 ml-md-5 ml-0">
   Avançar <i class=' fa fa-arrow-right'></i>
                    </asp:LinkButton>
                </div>
            </div>
        </div>

        <br />
    </div>

    <script src="../../js/jquery-3.3.1.slim.min.js" type="text/javascript"></script>
    <script src="../../js/jquery.validate.min.js" type="text/javascript"></script>
    <script src="../../js/bootstrap.min.js"></script>


    <script type="text/javascript">
        $(document).ready(function () {
            $("#form1").validate({
                rules: {
                    <%=txt_tituloCaravana.UniqueID%>: {
                    required: true
                },
                     <%=txt_descricao.UniqueID%>: {
                         required: true
                }
                }, messages: {
                    <%=txt_tituloCaravana.UniqueID%>: {
                    required: "Você deve informar um título para a caravana."
                },
                     <%=txt_descricao.UniqueID%>: {
                    required: "Por favor, fale sobre o destino da sua caravana!."
                }
            }
            });
        });

        $("#<%= btnAvancar1.ClientID %>").click(function () {
            return $('#form1').valid();
        })


        function AllowAlphabet(e) {
            isIE = document.all ? 1 : 0
            keyEntry = !isIE ? e.which : event.keyCode;
            if (((keyEntry >= '65') && (keyEntry <= '90')) || ((keyEntry >= '97') && (keyEntry <= '122')) || (keyEntry == '46') || (keyEntry == '32') || keyEntry == '45')
                return true;
            else {
                 return false;
            }
        }

    </script>
  
    


</asp:Content>

