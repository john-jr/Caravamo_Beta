<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cad_emp.aspx.cs" Inherits="Cad_emp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro Empresa</title>
    <link href="../../css/bootstrap.min.css" rel="stylesheet" />

    <link rel="stylesheet" href="../../css/bootstrap.min.css" />
    <!-- animate CSS -->
    <link rel="stylesheet" href="../../css/animate.css" />
    <!-- owl carousel CSS -->
    <link rel="stylesheet" href="../../css/owl.carousel.min.css" />
    <!-- font awesome CSS -->
    <link rel="stylesheet" href="../../css/all.css" />
    <!-- flaticon CSS -->
    <link rel="stylesheet" href="../../css/flaticon.css" />
    <link rel="stylesheet" href="../../css/themify-icons.css" />
    <link rel="stylesheet" href="../../css/nice-select.css" />
    <!-- font awesome CSS -->
    <link href="../../css/toastr.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="../../css/magnific-popup.css" />
    <!-- swiper CSS -->
    <link rel="stylesheet" href="../../css/slick.css" />
    <!-- style CSS -->
    <link rel="stylesheet" href="../../css/style.css" />
    <link rel="stylesheet" href="../../css/jquery-ui.min.css" />
    <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/jquery-1.12.1.min.js"></script>
    <script src="../../js/toastr.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

    <style>
        label.error {
            color: #F00;
        }
    </style>

</head>
<body>
    <div class="main_menu home_menu">
        <div class="container">
            <div class="l-box-content text-center">
                <a href="Index.aspx">
                    <img src="../../img/logo.png" style="width: 30%;" /></a>
            </div>

        </div>

    </div>
    <form id="form1" runat="server">
        <div class="container">
            <hr />

            <div class="row" style="justify-content: center;">
                <div class="col-md-6 col-12">
                    <div class="container ">
                        <br />
                        <h1 class="text-center">Cadastre-se como Empresa</h1>
                    </div>

                    <div class="form-group">
                        <p>Nome da empresa:</p>
                        <asp:TextBox runat="server" ID="txtNome" CssClass="form-control" placeholder="Nome da Empresa"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <p>Razão Social:</p>
                        <asp:TextBox runat="server" ID="txtRazao" CssClass="form-control" placeholder="Razão Social"></asp:TextBox>
                    </div>
                    <div class="form-group ">
                        <p>Email:</p>
                        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" type="email" placeholder="E-mail"></asp:TextBox>
                    </div>

                    <div class="row">
                        <div class="col-md-7">
                            <p>CNPJ:</p>
                            <asp:TextBox runat="server" ID="txtcnpj" CssClass="form-control" placeholder="CNPJ"></asp:TextBox>
                        </div>
                        <div class="col-md-8 mt-3">
                            <p>Numero de Registro de Fretamento da Artesp:</p>
                            <asp:TextBox runat="server" ID="txtArtesp" CssClass="form-control" placeholder="Número de Registro da Artesp"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group ">
                        <br />
                        <p>Senha:</p>
                        <asp:TextBox runat="server" ID="txtSenha" type="password" CssClass="form-control" placeholder="Senha"></asp:TextBox>
                    </div>
                    <div class="form-group ">
                        <p>Repita a Senha:</p>
                        <asp:TextBox runat="server" ID="txtSenha2" type="password" CssClass="form-control" placeholder="Repita a Senha"></asp:TextBox>
                    </div>



                    <br />
                    <div class="form-group">


                        <asp:Literal runat="server" ID="ltl_status"></asp:Literal>
                        <asp:Button runat="server" ID="btnCadastrar" CssClass="btn genric-btn info w-100" Text="Cadastrar-se" OnClick="btnCadastrar_Click" />





                    </div>
                </div>
            </div>
        </div>

    </form>
    <footer class="footer_part">
        <div class="container ">

            <hr />
            <div class="row ">
                <div class="col-lg-12  ">
                    <div class="copyright_text">
                        <p>
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                            Este site tem como propósito apresentar um trabalho acadêmico. Todas suas
                            informações aqui distribuídas podem ou não serem de cunho verídico. Não há nenhum
                            vínculo com autor ou empresa real.<a />
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        </p>
                    </div>
                </div>

            </div>


        </div>
    </footer>
    <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/jquery-3.3.1.slim.min.js"></script>



    <script src="../../js/jquery.mask.min.js"></script>
    <script src="../../js/jquery.validate.min.js"></script>
    <script src="../../js/additional-methods.min.js"></script>

    <script>
        $(document).ready(function () {
            $('#<%= txtcnpj.ClientID%>').mask('00.000.000/0000-00');
            $('#<%= txtArtesp.ClientID%>').mask("S0-0000");

        });

        $(document).ready(function () {
            $("#form1").validate({
                rules: {
                    txtNome: {
                    required: true
                },
                     txtRazao: {
                    required: true
                },
                     txtEmail: {
                    required: true,
                    email: true
                },
                    txtcnpj: {
                        required: true,
                        cnpjBR: true
                },
                    txtArtesp: {
                    required: true
                },
                    txtSenha: {
                    required: true
                },
                    txtSenha2: {
                    required: true
                }
                }, messages: {
                    txtNome: {
                        required: "*Campo obrigatório"
                    },
                    txtRazao: {
                        required: "*Campo obrigatório"
                    },
                    txtEmail: {
                        required: "*Campo obrigatório",
                        email: "Por favor, insira um email válido"
                    },
                    txtcnpj: {
                        required: "*Campo obrigatório",
                        cnpjBR: "Por favor, insira um CNPJ válido"
                    },
                    txtArtesp: {
                        required: "*Campo obrigatório"
                    },
                    txtSenha: {
                        required: "*Campo obrigatório"
                    },
                    txtSenha2: {
                        required: "*Campo obrigatório"
                    }
            }
            });
        });

    </script>
</body>

</html>
