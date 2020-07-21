<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="Create_Caravan_2.aspx.cs" Inherits="Pages_ToUser_Create_Caravan_2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="../../css/steps.css" rel="stylesheet" />
        <script src="../../js/bootstrap.min.js"></script>
     <script src="../../js/jquery-1.12.1.min.js"></script>
     <script src="../../js/toastr.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
   
    <div class="container">
          
        <div class="mt-5 mb-5 text-center">
            <h2>Criar Caravana</h2>
        </div>
        <ul class="step d-flex flex-nowrap">
            <li class="step-item">
                <a href="Create_Caravan_1.aspx" class="">Título e Descrição</a>
            </li>
            <li class="step-item active">
                <a href="#!" class="">Endereços</a>
            </li>
            <li class="step-item">
                <a  class="">Datas</a>
            </li>
            <li class="step-item">
                <a  class="">Categoria</a>
            </li>
            <li class="step-item">
                <a class="">Confirmar</a>
            </li>

        </ul>
    </div>
    <br />
    <br />
    <div class="container">
           <asp:Literal runat="server" ID="ltl_status"></asp:Literal>
        <div class="row">
            <div class="col-12">
                <h3>Origem</h3>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-1 text-lg-right text-md-right">
                <label>CEP:</label>
            </div>
            <div class="col-md-5">
                <asp:TextBox runat="server" ID="txt_cepOrigem" OnTextChanged="txt_cepOrigem_TextChanged" AutoPostBack="true" CssClass="form-control mb-2 mb-lg-0 mb-md-0 mb-xl-0"></asp:TextBox>
            </div>
          
        </div>
        <br class="d-none d-sm-block" />
        <div class="row">
            <div class="col-md-1 text-lg-right text-md-right">
                <label>Estado:</label>
            </div>
            <div class="col-md-3">

                <asp:DropDownList runat="server" ID="ddl_estadoOrigem" OnSelectedIndexChanged="ddl_estadoOrigem_SelectedIndexChanged" AutoPostBack="True"  CssClass="form-control mb-2 mb-lg-0 mb-md-0 mb-xl-0">     
                </asp:DropDownList>
            </div>
            <div class="col-md-1 text-lg-right text-md-right">
                <label>Cidade:</label>
            </div>
            <div class="col-md-3">

                <asp:DropDownList runat="server" ID="ddl_cidadeOrigem" CssClass="form-control mb-2 mb-lg-0 mb-md-0 mb-xl-0">
                    <asp:ListItem Value="01" Selected="True">Guaratinguetá</asp:ListItem>
                    <asp:ListItem Value="02">Lorena</asp:ListItem>
                    <asp:ListItem Value="03">Aparecida</asp:ListItem>
                    <asp:ListItem Value="04">São José dos campos</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <br class="d-none d-sm-block" />
        <div class="row">
            <div class="col-md-1 text-lg-right text-md-right">
                <label>Bairro:</label>
            </div>
            <div class="col-md-7">
                <asp:TextBox runat="server" ID="txt_bairroOrigem" CssClass="form-control mb-2 mb-lg-0 mb-md-0 mb-xl-0"></asp:TextBox>
            </div>
        </div>
        <br class="d-none d-sm-block" />
        <div class="row">
            <div class="col-md-1 text-lg-right text-md-right">
                <label>Rua:</label>
            </div>
            <div class="col-md-7">
                <asp:TextBox runat="server" ID="txt_ruaOrigem" CssClass="form-control mb-2 mb-lg-0 mb-md-0 mb-xl-0"></asp:TextBox>
            </div>
            <div class="col-md-1 text-lg-right text-md-right">
                <label>Nº:</label>
            </div>
            <div class="col-md-1">
                <asp:TextBox runat="server" ID="txt_numeroOrigem" CssClass="form-control mb-2 mb-lg-0 mb-md-0 mb-xl-0"></asp:TextBox>
            </div>

        </div>



    </div>
    <br />
    <br />
    <div class="container">
        <div class="row">
            <div class="col-12">
                <h3>Destino</h3>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-1 col-lg-1 text-lg-right text-md-right">
                <label>CEP:</label>
            </div>
            <div class="col-md-5 col-lg-5">
                <asp:TextBox runat="server" ID="txt_cepDestino" OnTextChanged="txt_cepDestino_TextChanged" AutoPostBack="true" CssClass="form-control mb-2 mb-lg-0 mb-md-0 mb-xl-0"></asp:TextBox>
            </div>
        </div>
        <br class="d-none d-sm-block" />
        <div class="row">
            <div class="col-md-1 col-lg-1 text-lg-right text-md-right">
                <label>Estado:</label>
            </div>
            <div class="col-md-3 col-lg-3">

                <asp:DropDownList runat="server" ID="ddl_estadoDestino" OnSelectedIndexChanged="ddl_estadoDestino_SelectedIndexChanged" AutoPostBack="True"  CssClass="form-control mb-2 mb-lg-0 mb-md-0 mb-xl-0">
                   
                </asp:DropDownList>
            </div>
            <div class="col-md-1 text-lg-right text-md-right">
                <label>Cidade:</label>
            </div>
            <div class="col-md-3">

                <asp:DropDownList runat="server" ID="ddl_cidadeDestino" CssClass="form-control mb-2 mb-lg-0 mb-md-0 mb-xl-0">
                    <asp:ListItem Value="01" Selected="True">Guaratinguetá</asp:ListItem>
                    <asp:ListItem Value="02">Lorena</asp:ListItem>
                    <asp:ListItem Value="03">Aparecida</asp:ListItem>
                    <asp:ListItem Value="04">São José dos campos</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <br class="d-none d-sm-block" />
        <div class="row">
            <div class="col-md-1 text-lg-right text-md-right">
                <label>Bairro:</label>
            </div>
            <div class="col-md-7">
                <asp:TextBox runat="server" ID="txt_bairroDestino" CssClass="form-control mb-2 mb-lg-0 mb-md-0 mb-xl-0"></asp:TextBox>
            </div>
        </div>
        <br class="d-none d-sm-block" />
        <div class="row">
            <div class="col-md-1 text-lg-right text-md-right">
                <label>Rua:</label>
            </div>
            <div class="col-md-7">
                <asp:TextBox runat="server" ID="txt_ruaDestino" CssClass="form-control mb-2 mb-lg-0 mb-md-0 mb-xl-0"></asp:TextBox>
            </div>
            <div class="col-md-1 text-lg-right text-md-right">
                <label>Nº:</label>
            </div>
            <div class="col-md-1">
                <asp:TextBox runat="server" ID="txt_numeroDestino" CssClass="form-control mb-2 mb-lg-0 mb-md-0 mb-xl-0"></asp:TextBox>
            </div>

        </div>


        <br />


    </div>
    <br />
    <hr />
    <div class="container">
      
        <div class="row ">
            <div class="col-4 text-center">
                <asp:LinkButton runat="server" ID="btnRetornar1" OnClick="btnRetornar1_Click" Cssclass="genric-btn danger ml-lg-5 ml-md-5 ml-0 mb-2">
  <i class=' fa fa-arrow-left'></i>  Retornar
                </asp:LinkButton>
            </div>
            <div class="col-4">
            </div>

            <div class="col-4">
               
                <asp:LinkButton runat="server" ID="btnAvancar1" OnClick="btnAvancar1_Click" Cssclass="genric-btn info ml-lg-5 ml-md-5 ml-0 mb-2">
   Avançar <i class=' fa fa-arrow-right'></i>
                </asp:LinkButton>

            </div>
        </div>
    </div>
     
    <script src="../../js/jquery-3.3.1.slim.min.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui.min.js"></script>
    <!-- particles js -->
    <script src="../../js/owl.carousel.min.js"></script>
    <script src="../../js/jquery.nice-select.min.js"></script>
    <!-- custom js -->
    <script src="../../js/custom.js"></script>


    <script src="../../js/moment.js"></script>

    <script src="../../js/jquery.mask.min.js"></script>
    <script src="../../js/jquery.validate.min.js"></script>
    <script>
        $(document).ready(function() {
            $('#<%= txt_cepDestino.ClientID%>').mask("99999-999");
            $('#<%= txt_cepOrigem.ClientID%>').mask("99999-999");
        });

        $(document).ready(function () {
            $("#form1").validate({
                rules: {
                    <%=txt_cepOrigem.UniqueID%>: {
                    required: true
                },
                    <%=txt_bairroOrigem.UniqueID%>: {
                    required: true
                },
                    <%=txt_ruaOrigem.UniqueID%>: {
                    required: true
                },
                    <%=txt_numeroOrigem.UniqueID%>: {
                    required: true,
                    number: true
                },
                    <%=txt_cepDestino.UniqueID%>: {
                    required: true
                },
                    <%=txt_bairroDestino.UniqueID%>: {
                    required: true
                },
                    <%=txt_ruaDestino.UniqueID%>: {
                    required: true
                },
                    <%=txt_numeroDestino.UniqueID%>: {
                    required: true,
                    number: true
                }
                }, messages: {
                       <%=txt_cepOrigem.UniqueID%>: {
                       required: "Você deve informar um CEP de origem."
            },
                    <%=txt_bairroOrigem.UniqueID%>: {
                        required: "Você deve informar um bairro de origem."
            },
                    <%=txt_ruaOrigem.UniqueID%>: {
                        required: "Você deve informar uma rua de origem."
            },
                    <%=txt_numeroOrigem.UniqueID%>: {
                        required: "Obrigatório",
                        number: "Digite um número!"
            },
                 <%=txt_cepDestino.UniqueID%>: {
                required: "Você deve informar um CEP de destino."
            },
                    <%=txt_bairroDestino.UniqueID%>: {
                required: "Você deve informar um bairro de destino."
            },
                    <%=txt_ruaDestino.UniqueID%>: {
                required: "Você deve informar uma rua de destino."
            },
                    <%=txt_numeroDestino.UniqueID%>: {
                        required: "Obrigatório",
                        number: "Digite um número!"
            }      
            }
            });
        });

        $("#<%= btnAvancar1.ClientID %>").click(function () {
            return $('#form1').valid();
        })
    </script>
  


</asp:Content>

