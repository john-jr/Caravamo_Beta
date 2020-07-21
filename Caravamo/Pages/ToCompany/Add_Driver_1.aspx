<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Add_Driver_1.aspx.cs" Inherits="Pages_ToCompany_Add_Driver" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="../../css/steps.css" rel="stylesheet" />


    <div class="container">
        <div class="mt-5 mb-3 text-center">
            <h2>Novo Motorista</h2>
        </div>
        <ul class="step d-flex flex-nowrap mb-3">
            <li class="step-item active">
                <a href="#" class="">Informações do Motorista</a>
            </li>
            <li class="step-item">
                <a href="Add_Driver_2.aspx" class="">Documentos do Motorista</a>
            </li>
            <li class="step-item">
                <a href="Add_Driver_3.aspx" class="">Confirmar</a>
            </li>
        </ul>

    </div>
    <br />

    <div class="container">
        <div class="row">
            <div class="col-12 col-md-12 col-lg-12 text-center">
                <h3>Insira as informações do motorista</h3>
            </div>

            <div class="col-3">
            </div>

            <div class="col-md-6 col-lg-6 col-12 text-center">
                <br />
                <label>Nome Completo </label>
                <asp:TextBox ID="txt_NomeMotorista" runat="server" CssClass="form-control" placeholder="Digite o nome"></asp:TextBox>
            </div>
            <div class="col-3">
            </div>

            <div class="col-3">
            </div>

            <div class="col-md-2 col-lg-2 col-12 text-center mt-4">

                <label>Data de Nascimento:</label>
            </div>
            <div class="col-md-4 col-12 text-center">
                <asp:TextBox runat="server" ID="txt_datanasc" TextMode="Date" CssClass="form-control mt-lg-4 mt-md-4"></asp:TextBox>
            </div>
            <div class="col-3">
            </div>



            <div class="col-3">
            </div>


            <div class="col-md-2 text-lg-right text-md-right offset-2 offset-lg-0 offset-md-0 mt-4">

                <label>Sexo:</label>
            </div>

            <div class="col-md-4 col-6 offset-5 offset-lg-0 offset-md-0 mt-lg-4 mt-md-4" id="sexo">
                <asp:RadioButtonList runat="server" ID="rbl_sexo" RepeatDirection="Vertical">
                    <asp:ListItem Value="M" Selected="True">Masculino</asp:ListItem>
                    <asp:ListItem Value="F">Feminino</asp:ListItem>
                    <asp:ListItem Value="O">Outro</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div class="col-3">
            </div>



            <div class="col-3">
            </div>
            <div class="col-md-6 col-12 text-center">
                <br />
                <label>E-mail </label>
                <asp:TextBox ID="txt_email" runat="server" CssClass="form-control" type="email" placeholder="exemplo@email.com"></asp:TextBox>
            </div>
            <div class="col-3">
            </div>
              <div class="col-3">
            </div>

              <div class="col-md-6 col-12 text-center">
                <br />
                <label>Foto do Motorista </label>
                  <br />
                  <br />
                  <asp:FileUpload runat="server" ID="fu_foto" />
              <%--  <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" type="email" placeholder="exemplo@email.com"></asp:TextBox>--%>
            </div>
           


        </div>
    </div>

    <hr />
    <div class="container">
        <div class="row">
            <div class="col-4 text-center">
                <asp:Button runat="server" ID="btn_cancelar" Text="Cancelar" OnClick="btn_cancelar_Click" CssClass="genric-btn danger" />
            </div>
            <div class="col-4">
            </div>

            <div class="col-4">
                <div class="ml-lg-5 ml-md-5 ml-0">
                    <asp:LinkButton runat="server" ID="btnAvancar1" OnClick="btnAvancar1_Click" class="genric-btn info ml-lg-5 ml-md-5 ml-0" type="submit">
   Avançar <i class=' fa fa-arrow-right d-none d-md-inline'></i>
                    </asp:LinkButton>
                </div>
            </div>
        </div>

        <br />
    </div>

    <script src="../../js/jquery-3.3.1.slim.min.js" type="text/javascript"></script>
    <script src="../../js/jquery.validate.min.js" type="text/javascript"></script>
    <script src="../../js/additional-methods.min.js" type="text/javascript"></script>
    <script src="../../js/bootstrap.min.js"></script>


    <script type="text/javascript">
        $(document).ready(function () {
            $("#form1").validate({
                rules: {
                    <%=txt_NomeMotorista.UniqueID%>: {
                    required: true
                },
                     <%=txt_datanasc.UniqueID%>: {
                    required: true,
                    date: true
                },
                     <%=txt_email.UniqueID%>: {
                    required: true,
                    email: true
                },
                <%=fu_foto.UniqueID%>:{
                    required: true,
                   extension:'png|jpg'
                },

                }, messages: {
                    <%=txt_NomeMotorista.UniqueID%>: {
                    required: "Você deve informar um nome."
            },
            <%=fu_foto.UniqueID%>:{
                required: "Você deve inserir uma imagem do motorista.",
               extension: "Formato de imagem inválido (Apenas .png são aceitos)"
            },

                     <%=txt_datanasc.UniqueID%>: {
                    required: "Você deve informar uma data de nascimento."
            },
                     <%=txt_email.UniqueID%>: {
                required: "Você deve informar um endereço de email.",
                email: "Por favor, digite um endereço de email válido."
            }
            }
            });
        });

        $("#<%= btnAvancar1.ClientID %>").click(function () {
            return $('#form1').valid();
        })
    </script>

</asp:Content>

