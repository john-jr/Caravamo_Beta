<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Add_Driver_2.aspx.cs" Inherits="Pages_ToCompany_Add_Driver_2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="../../css/steps.css" rel="stylesheet" />
    <div class="container">
        <div class="mt-5 mb-3 text-center">
            <h2>Novo Motorista</h2>
        </div>
        <ul class="step d-flex flex-nowrap mb-3">
            <li class="step-item ">
                <a href="Add_Driver_1.aspx" class="">Informações do Motorista</a>
            </li>
            <li class="step-item active">
                <a href="#" class="">Documentos do Motorista</a>
            </li>
            <li class="step-item">
                <a href="Add_Driver_3.aspx" class="">Confirmar</a>
            </li>


        </ul>
    </div>
    <br />
    <div class="container">
        <div class="row">
            <div class="col-12 text-center">
                <h3>Insira os documentos do motorista</h3>
            </div>


            <div class="col-3">
            </div>

            <div class="col-md-1 text-lg-right text-md-right ml-2 ml-lg-0 ml-md-0 mt-4">

                <label>CPF:</label>
            </div>
            <div class="col-md-4 col-12 text-center mt-lg-4 mt-md-4">

                <asp:TextBox runat="server" ID="txt_cpf" CssClass="form-control" placeholder="Digite o número do CPF"></asp:TextBox>
            </div>
            <div class="col-4">
            </div>




            <div class="col-3">
            </div>

            <div class="col-md-1 text-lg-right text-md-right ml-2 ml-lg-0 ml-md-0 mt-4">

                <label>CNH:</label>
            </div>
            <div class="col-md-4 col-12 text-center mt-lg-4 mt-md-4">

                <asp:TextBox runat="server" ID="txt_cnh" CssClass="form-control" placeholder="Digite o número da CNH"></asp:TextBox>
            </div>
            <div class="col-4">
            </div>





            <div class="col-3">
            </div>

            <div class="col-md-2 text-lg-right text-md-right text-center mb-1 mt-4">

                <!--   <label class="mt-1">Foto de Perfil</label> -->
            </div>

            <div class="col-md-2 col-12 text-center">


                <!--     <asp:LinkButton runat="server" ID="LinkButton1" class="genric-btn info mt-lg-4">
   Imagem &nbsp <i class=' fa fa-image'></i>
                </asp:LinkButton>-->
            </div>
            <div class="col-5">
            </div>

        </div>
    </div>
    <hr />


    <div class="container">
        <div class="row ">
            <div class="col-4 text-center">
                <asp:LinkButton runat="server" ID="btn_Retornar" OnClick="btn_Retornar_Click" class="genric-btn danger ml-lg-5 ml-md-5 ml-0 mb-2">
  <i class=' fa fa-arrow-left'></i>  Retornar
                </asp:LinkButton>
            </div>
            <div class="col-4">
            </div>

            <div class="col-4">

                <asp:LinkButton runat="server" ID="btnAvancar1" OnClick="btnAvancar1_Click" class="genric-btn info ml-lg-5 ml-md-5 ml-0 mb-2">
   Avançar <i class=' fa fa-arrow-right'></i>
                </asp:LinkButton>

            </div>
        </div>
    </div>
    <script src="../../js/bootstrap.min.js"></script>

    <script src="../../js/jquery-3.3.1.slim.min.js"></script>
    <script src="../../js/jquery-ui.min.js"></script>
    <script src="../../js/jquery.mask.min.js"></script>
    <script src="../../js/jquery.validate.min.js"></script>
    <script src="../../js/additional-methods.min.js"></script>
    <script>
        $(document).ready(function () {
            $('#<%= txt_cpf.ClientID%>').mask("999.999.999-99");
            $('#<%= txt_cnh.ClientID%>').mask("99999999999");

        });

        $(document).ready(function () {
            $("#form1").validate({
                rules: {
                    <%=txt_cpf.UniqueID%>: {
                    required: true,
                    cpfBR: true
                 },
                     <%=txt_cnh.UniqueID%>: {
                         required: true,
                         cnhBR: true
                 }
                }, messages: {
                    <%=txt_cpf.UniqueID%>: {
                required: "Você deve informar o CPF do motorista.",
                cpfBR: "Por favor, insira um CPF válido"
             },
                     <%=txt_cnh.UniqueID%>: {
                         required: "Você deve informar a CNH do motorista.",
                         cnhBR: "Por favor, insira um número de CNH válido"
             }
            }
            });
        });

        $("#<%= btnAvancar1.ClientID %>").click(function () {
            return $('#form1').valid();
        })


    </script>

</asp:Content>

