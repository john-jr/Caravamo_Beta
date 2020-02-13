<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Edit_Profile.aspx.cs" Inherits="Pages_ToCompany_Edit_Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <link rel="icon" href="../../img/favicon.png" />
    <link rel="stylesheet" href="../../css/bootstrap.min.css" />
    <link rel="stylesheet" href="../../css/animate.css" />
    <link rel="stylesheet" href="../../css/owl.carousel.min.css" />
    <link rel="stylesheet" href="../../css/all.css" />
    <link rel="stylesheet" href="../../css/flaticon.css" />
    <link rel="stylesheet" href="../../css/themify-icons.css" />
    <link rel="stylesheet" href="../../css/nice-select.css" />
    <link rel="stylesheet" href="../../css/magnific-popup.css" />
    <link rel="stylesheet" href="../../css/slick.css" />
    <link rel="stylesheet" href="../../css/style.css" />

     

  
    <style>


        .project-tab {
            padding: 10%;
            margin-top: -8%;
        }

            .project-tab #tabs {
                background: #007b5e;
                color: #eee;
            }

                .project-tab #tabs h6.section-title {
                    color: #eee;
                }

                .project-tab #tabs .nav-tabs .nav-item.show .nav-link, .nav-tabs .nav-link.active {
                    color: #0062cc;
                    background-color: transparent;
                    border-color: transparent transparent #f3f3f3;
                    border-bottom: 3px solid !important;
                    font-size: 16px;
                    font-weight: bold;
                }

            .project-tab .nav-link {
                border: 1px solid transparent;
                border-top-left-radius: .25rem;
                border-top-right-radius: .25rem;
                color: #38a4ff;
                font-size: 16px;
                font-weight: 600;
            }

                .project-tab .nav-link:hover {
                }

            .project-tab thead {
                background: #f3f3f3;
                color: #333;
            }

            .project-tab a {
                text-decoration: none;
                color: #333;
                font-weight: 600;
            }
    </style>
     <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/jquery-1.12.1.min.js"></script>
    <script src="../../js/toastr.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>


    <section class="container-fluid">
        <div class="col-lg-12">
            <div class="row">
              <!--  <div class="col-lg-2 offset-lg-3 mt-30" style="text-align: center">
                    <asp:Image runat="server" ImageUrl="~/img/index_images/noimg.png" />
                 <a href="#">
                        <p style="font-size: small">
                            Alterar foto
                        </p>
                    </a>
                </div>-->
                <div class="col-lg-12 mt-15" style="text-align: center">
                    <div class="col-lg-12 mt-lg-5">
                        <h3>
                              <asp:Literal ID="ltl_status" runat="server">l</asp:Literal>
                            <asp:Label runat="server" ID="lbl_nomeFantasia" Text="Empresa de Transportes ME"></asp:Label>
                        </h3>
                    </div>
                    <div class="col-lg-12">
                        <h4>
                            <asp:Label runat="server" ID="lbl_razaoSocial" Text="GuaraTur"></asp:Label>
                        </h4>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id="tabs" class="project-tab">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <nav>
                        <div class="nav nav-tabs nav-fill" id="nav-tab" role="tablist">
                            <a class="nav-item nav-link active" id="nav-home-tab" data-toggle="tab" href="#nav-home" role="tab" aria-controls="nav-home" aria-selected="false">Sua Conta</a>
                            <a class="nav-item nav-link" id="nav-profile-tab" data-toggle="tab" href="#nav-profile" role="tab" aria-controls="nav-profile" aria-selected="false">Alterar Senha</a>
                            <a class="nav-item nav-link disabled d-none d-sm-block" id="nav-contact-tab" data-toggle="tab" href="#nav-contact" role="tab" aria-controls="nav-contact" aria-selected="false">Notificações</a>
                        </div>
                    </nav>
                    <div class="tab-content" id="nav-tabContent">
                        <div class="tab-pane fade show active" id="nav-home" role="tabpanel" aria-labelledby="nav-home-tab">
                            <div class="row">
                                <div class="col-md-3">
                                </div>
                                <div class="col-md-6">
                                    <br />


                                    <label class="mb-1">Razão Social</label>
                                    <div class="input-group">
                                        <br />
                                        <asp:TextBox ID="txt_RazaoSocial" runat="server" Enabled="false" CssClass="form-control" Style="height: calc(1.5em + .75rem + 5px)"> </asp:TextBox>
                                        <div class="input-group-prepend">
                                            &nbsp
                            <asp:LinkButton ID="btn_editarRazaoSocial" runat="server" OnClick="btn_editarRazaoSocial_Click" CssClass="genric-btn primary ">
                             <i class="fa fa-pencil-alt"></i>
                            </asp:LinkButton>
                                        </div>

                                    </div>
                                </div>
                                <div class="col-md-3">
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-3">
                                </div>
                                <div class="col-md-6">
                                    <br />







                                    <label class="mb-1">Nome Fantasia</label>
                                    <div class="input-group">
                                        <br />
                                        <br />
                                        <asp:TextBox ID="txt_nomeFantasia" runat="server" Enabled="false" CssClass="form-control" Style="height: calc(1.5em + .75rem + 5px)"> </asp:TextBox>
                                        <div class="input-group-prepend">
                                            &nbsp
                            <asp:LinkButton ID="btn_editarNomeFantasia" runat="server" CssClass="genric-btn primary " OnClick="btn_editarNomeFantasia_Click">
                             <i class="fa fa-pencil-alt"></i>
                            </asp:LinkButton>
                                        </div>

                                    </div>
                                </div>
                                <div class="col-md-3">
                                </div>
                            </div>


                            <div class="row">
                                <div class="col-md-3">
                                </div>
                                <div class="col-md-6 mt-4">
                                    <br />







                                    <label class="mb-1">E-mail</label>
                                    <div class="input-group">
                                        <br />
                                        <br />
                                        <asp:TextBox ID="txt_email" runat="server" Enabled="false" CssClass="form-control" Style="height: calc(1.5em + .75rem + 5px)"> </asp:TextBox>
                                        <div class="input-group-prepend">
                                            &nbsp
                            <asp:LinkButton ID="btn_EditarEmail" OnClick="btn_EditarEmail_Click" runat="server" CssClass="genric-btn primary ">
                             <i class="fa fa-pencil-alt"></i>
                            </asp:LinkButton>
                                        </div>

                                    </div>
                                </div>
                                <div class="col-md-3">
                                </div>
                            </div>



                        </div>
                        <div class="tab-pane fade" id="nav-profile" role="tabpanel" aria-labelledby="nav-profile-tab">
                            <div class="row">
                                <div class="col-md-3">
                                </div>
                                <div class="col-md-6">
                                    <br />







                                    <label class="mb-1">Senha Anterior</label>
                                    <div class="input-group">
                                        <br />
                                        <asp:TextBox ID="txt_oldSenha" runat="server" TextMode="Password" CssClass="form-control" Style="height: calc(1.5em + .75rem + 5px)"> </asp:TextBox>


                                    </div>
                                </div>
                                <div class="col-md-3">
                                </div>
                            </div>


                            <div class="row">
                                <div class="col-md-3">
                                </div>
                                <div class="col-md-6">
                                    <br />







                                    <label class="mb-1">Nova Senha</label>
                                    <div class="input-group">
                                        <br />
                                        <asp:TextBox ID="txt_newSenha" runat="server" TextMode="Password" CssClass="form-control" Style="height: calc(1.5em + .75rem + 5px)"> </asp:TextBox>


                                    </div>
                                </div>
                                <div class="col-md-3">
                                </div>
                            </div>



                            <div class="row">
                                <div class="col-md-3">
                                </div>
                                <div class="col-md-6">
                                    <br />







                                    <label class="mb-1">Confirmar Senha</label>
                                    <div class="input-group">
                                        <br />
                                        <asp:TextBox ID="txt_newSenhaC" runat="server" TextMode="Password" CssClass="form-control" Style="height: calc(1.5em + .75rem + 5px)"> </asp:TextBox>


                                    </div>
                                </div>
                                <div class="col-md-3">
                                </div>
                            </div>



                            <div class="row">
                                <div class="col-md-3">
                                </div>
                                <div class="col-md-6 text-center">
                                    <br />









                                    <br />
                                    <asp:Button ID="btn_alterarSenha" runat="server" OnClick="btn_alterarSenha_Click" CssClass="genric-btn info w-50" Text="Alterar Senha" />


                                </div>
                                <div class="col-md-3">
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    

    <script src="../../js/jquery-3.3.1.slim.min.js"></script>
    <script src="../../js/bootstrap.min.js"></script>

            <script src="../../js/jquery-3.3.1.slim.min.js"></script>
    <script src="../../js/jquery-ui.min.js"></script>
    <!-- particles js -->
    <script src="../../js/owl.carousel.min.js"></script>
    <script src="../../js/jquery.nice-select.min.js"></script>
    <!-- custom js -->
    <script src="../../js/custom.js"></script>


    <script src="../../js/moment.js"></script>

    <script src="../../js/jquery.mask.min.js"></script>
    <script src="../../js/jquery.validate.min.js"></script>

</asp:Content>

