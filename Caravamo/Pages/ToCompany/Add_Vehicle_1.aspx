<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Add_Vehicle_1.aspx.cs" Inherits="Pages_ToCompany_Add_Vehicle_1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="../../css/steps.css" rel="stylesheet" />
    <style>
        #tipo td {
            padding-left: 30px;
        }
    </style>

    <div class="container">
        <div class="mt-5 mb-5 text-center">
            <h2>Adicionar veículo</h2>
        </div>
        <ul class="step d-flex flex-nowrap">
            <li class="step-item active">
                <a href="#!" class="">Informações do Veículo</a>
            </li>
            <li class="step-item">
                <a href="#" class="">Assentos e Acessórios</a>
            </li>
            <%--<li class="step-item ">
                <a href="Add_Vehicle_3.aspx" class="">Fotos do Veículo</a>
            </li>--%>
            <li class="step-item">
                <a href="#" class="">Confirmar</a>
            </li>

        </ul>
    </div>
    <br />
    <br />
    <div class="container">
        <div class="row">
            <div class="col-12 text-center">
                <h3>Insira as informações do veículo</h3>
                <br />
            </div>
            <div class="col-md-2">
            </div>

            <div class="col-2 text-right">
                <label for="txt_data">Marca:</label>
            </div>
            <div class="col-md-4">
                <asp:TextBox runat="server" ID="txt_marca" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-4">
            </div>




            <div class="col-md-2">
            </div>

            <div class="col-2 text-right">
                <br>
                <label for="txt_data">Modelo:</label>
            </div>
            <div class="col-md-4">
                <asp:TextBox runat="server" ID="txt_modelo" CssClass="form-control mt-lg-4 mt-md-4 mt-0"></asp:TextBox>
            </div>
            <div class="col-md-4">
            </div>



            <div class="col-md-2">
            </div>

            <div class="col-2 text-right">
                <br>
                <label for="txt_data">Tipo:</label>
            </div>
            <div class="col-md-4" id="tipo">
                <br>
                <asp:RadioButtonList runat="server" ID="rbl_tipoVeiculo" RepeatDirection="Horizontal">
                    <asp:ListItem Value="V" Selected="True">Van</asp:ListItem>
                    <asp:ListItem Value="M">Micro-ônibus</asp:ListItem>
                    <asp:ListItem Value="O">Ônibus</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div class="col-md-4">
            </div>



            <div class="col-md-3">
            </div>

            <div class="col-1 text-right">
                <br>
                <label for="txt_data">Ano:</label>
            </div>
            <div class="col-md-2">
                <asp:DropDownList runat="server" ID="ddl_ano" CssClass="form-control mt-lg-4 mt-md-4 mt-0">
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
                    <asp:ListItem Value="19">2019</asp:ListItem>
                    <asp:ListItem Value="20" Selected="True">2020</asp:ListItem>

                </asp:DropDownList>
            </div>
            <div class="col-md-6">
            </div>


            <div class="col-md-3">
            </div>

            <div class="col-1 text-right">
                <br>
                <label for="txt_data">Placa:</label>
            </div>
            <div class="col-md-2">
                <asp:TextBox runat="server" ID="txt_placa" CssClass="form-control mt-lg-4 mt-md-4 mt-0"></asp:TextBox>
            </div>
            <div class="col-md-6">
            </div>


            <div class="col-md-3">
            </div>

              <div class="col-1 text-right">
                <br>
                <label for="txt_data">Foto do Veículo:</label>
            </div>
            <div class="col-md-2">
                <br />
                
              <asp:FileUpload runat="server" ID="fu_foto"  CssClass="mt-2"/>
            </div>
            <div class="col-md-6">
            </div>


            <div class="col-md-3">
            </div>


            <div class="col-md-6">


                <hr />
            </div>
            <div class="col-md-3">
            </div>



            <div class="col-md-2">
            </div>

            <div class="col-2 text-right">
                <br>
                <label for="txt_data">CRLV:</label>
            </div>
            <div class="col-md-4">
                <asp:TextBox runat="server" ID="txt_crlv" CssClass="form-control mt-lg-4 mt-md-4 mt-0"></asp:TextBox>
            </div>
            <div class="col-md-4">
            </div>



        </div>

    </div>







    <hr />
    <div class="container">
        <div class="row ">
            <div class="col-4 text-center">
                <asp:LinkButton runat="server" ID="btn_retornar" OnClick="btn_retornar_Click" class="genric-btn danger ml-lg-5 ml-md-5 ml-0 mb-2">
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
    <script>
        $(document).ready(function () {
            $('#<%= txt_placa.ClientID%>').mask("AAA-AAAA");
        });

        $(document).ready(function () {
            $("#form1").validate({
                rules: {
                    <%=txt_marca.UniqueID%>: {
                    required: true
                },
                     <%=txt_modelo.UniqueID%>: {
                    required: true
                },
                    <%=txt_placa.UniqueID%>: {
                    required: true
                },
                    <%=txt_crlv.UniqueID%>: {
                    required: true
                },
                   <%=fu_foto.UniqueID%>:{
                    required: true,
                   extension:'png|jpg'
                },
                }, messages: {
                    <%=txt_marca.UniqueID%>: {
                    required: "Você deve informar a marca do veículo."
                },
              <%=fu_foto.UniqueID%>:{
                required: "Você deve inserir uma imagem do veículo.",
               extension: "Formato de imagem inválido (Apenas .png são aceitos)"
            },
                     <%=txt_modelo.UniqueID%>: {
                    required: "Você deve informar o modelo do veículo."
                },
                     <%=txt_placa.UniqueID%>: {
                    required: "Você deve informar a placa do veículo."
                },
                     <%=txt_crlv.UniqueID%>: {
                required: "Você deve informar o número do crlv.",
            }
            }
            });
        });

        $("#<%= btnAvancar1.ClientID %>").click(function () {
            return $('#form1').valid();
        })


    </script>




</asp:Content>

