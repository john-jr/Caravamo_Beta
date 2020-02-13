<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Add_Driver_3.aspx.cs" Inherits="Pages_ToCompany_Add_Driver_3" %>

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
            <h2>Novo Motorista</h2>
        </div>
        <ul class="step d-flex flex-nowrap">
            <li class="step-item ">
                <a href="Add_Driver_1.aspx" class="">Informações do Motorista</a>
            </li>
            <li class="step-item ">
                <a href="Add_Driver_2.aspx" class="">Documentos do Motorista</a>
            </li>
            <li class="step-item active">
                <a href="#!" class="">Confirmar</a>
            </li>


        </ul>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-12 text-center">
                <br />
                <h3>Por favor, confirme as informações</h3>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-2">
            </div>
            <div class="col-md-4 text-center d-none d-sm-block">
                <i class="fas fa-user fa-7x"></i>

            </div>
            <div class="col-md-4 text-center d-none d-sm-block">
                <i class="fas fa-file-alt fa-7x"></i>

            </div>

        </div>

        <br />


        <div class="row">

            <div class="col-md-2">
            </div>

            <div class="col-md-4">

                <div class="row ml-3 ml-lg-0 ml-md-0 mb-5 mb-lg-0 mb-md-0">
                    <div class="col-1">
                        <i class="fas fa-user d-block d-sm-none fa-2x"></i>
                    </div>
                    <div class="col-md-12 col-11 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="lbl_NomeDoMotorista" Text="Nome do Motorista: "></asp:Label>
                    </div>
                    <br class="d-none d-sm-block"/>
                    <br class="d-none d-sm-block"/>
                    <div class="col-md-12 col-11 offset-1 offset-lg-0 offset-md-0 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="lbl_nasc" Text="Data de Nascimento: "></asp:Label>
                    </div>
                    <br class="d-none d-sm-block"/>
                    <br class="d-none d-sm-block"/>
                    <div class="col-md-12 offset-1 offset-lg-0 offset-md-0 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="lbl_genero" Text="Gênero: "></asp:Label>
                    </div>
                    <br class="d-none d-sm-block"/>
                    <br class="d-none d-sm-block"/>
                    <div class="col-md-12 offset-1 offset-lg-0 offset-md-0 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="lbl_email" Text="E-mail: "></asp:Label>
                    </div>


                </div>
            </div>
            <div style="border-left: 1px solid lightgrey; margin: 0 7.5px;"></div>
            <div class="col-md-4">
                <div class="row ml-3 ml-lg-0 ml-md-0">
                    <div class="col-1">
                        <i class="fas fa-file-alt d-block d-sm-none fa-2x"></i>
                    </div>
                    <div class="col-md-12 col-11 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="lbl_cnh" Text="CNH: "></asp:Label>
                    </div>
                    <br class="d-none d-sm-block"/>
                    <br class="d-none d-sm-block"/>
                    <div class="col-md-12 col-11 offset-1 offset-lg-0 offset-md-0 mb-2 mb-lg-0 mb-md-0">
                        <asp:Label runat="server" ID="lbl_cpf" Text="CPF: "></asp:Label>
                    </div>
                    <br class="d-none d-sm-block"/>
                    <br class="d-none d-sm-block"/>
                    <div class="col-md-12 col-11 offset-1 offset-lg-0 offset-md-0">
                  <!--      <asp:Label runat="server" ID="lbl_foto" Text="Foto de Perfil: "></asp:Label>-->
                    </div>




                </div>
            </div>

        </div>


    </div>


    <hr />
    
    <div class="container">
        <div class="row ">
            <div class="col-4 text-center">
                <asp:LinkButton runat="server" ID="btn_retornar" OnClick="btn_retornar_Click" class="genric-btn danger">
  <i class=' fa fa-arrow-left'></i>  Retornar
                </asp:LinkButton>
            </div>
            <div class="col-4">
            </div>

            <div class="col-4">
                <div class="ml-lg-5 ml-md-5 ml-0">
                    <asp:Literal runat="server" ID="ltl_status"></asp:Literal>
                    <asp:LinkButton runat="server" ID="btn_confirmar" OnClick="btn_confirmar_Click" class="genric-btn info ml-lg-5 ml-md-5 ml-0">
   Confirmar
                    </asp:LinkButton>
                </div>
            </div>
        </div>

        <br />
    </div>

</asp:Content>

