<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cad_cli.aspx.cs" Inherits="Cad_cli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro Viajante</title>

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
    <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/jquery-1.12.1.min.js"></script>
    <script src="../../js/toastr.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

    <style type="text/css">
        @media (min-width: 576px) and (max-width: 767.98px) {
            #rblSexo label {
                font-size: 16px;
                margin-right: 5px;
            }
        }

        @media (min-width: 768px) {
            #rblSexo label {
                font-size: 16px;
                margin-right: 10px;
            }

            #rblSexo input {
                width: 15px;
                height: 15px;
            }
        }

        label.error{
            color: #F00;
        }
    </style>


</head>
<body>
    <div class="main_menu home_menu">
        <div class="container">
            <div class="l-box-content text-center">
                <a href="index.html">
                    <img src="../../img/logo.png" style="width: 30%;" /></a>
            </div>

        </div>

    </div>
    <form id="form1" runat="server">
        <div class="container">
            <hr />

            <div class="row" style="justify-content: center;">
                <div class="col-7">
                    <div class="container">
                        <br />
                        <h1 class="text-center">Cadastre-se como viajante</h1>
                    </div>

                    <div class="form-group">
                        <p>Nome:</p>
                        <asp:TextBox runat="server" ID="txtNome" CssClass="form-control" placeholder="Nome Completo"></asp:TextBox>
                    </div>
                    <div class="form-group ">
                        <p>Email:</p>
                        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" placeholder="E-mail"></asp:TextBox>
                    </div>
                    <div class="row">
                        <div class="col-md-5">
                            <p>CPF:</p>
                            <asp:TextBox runat="server" ID="txtCPF" CssClass="form-control" placeholder="CPF"></asp:TextBox>
                        </div>
                        <div class="col-md-7">
                            <p>Data de Nascimento:</p>
                            <asp:TextBox runat="server" ID="datapiker" type="date" CssClass="form-control"></asp:TextBox>
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
                    <!--Sexo Radiobutton-->

                    <p>Sexo: </p>
                    <div class="container">
                        <asp:RadioButtonList runat="server" ID="rblSexo" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Masculino " Selected="True" Value="M"> </asp:ListItem>
                            <asp:ListItem Text=" Feminino " Value="F">Feminino </asp:ListItem>
                            <asp:ListItem Text=" Outro " Value="O">Outro</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>

                    <!--Botão-->
                    <br />
                    <div class="row">

                        <div class="col-12">
                            <asp:Literal runat="server" ID="ltl_status"></asp:Literal>
                            <asp:Button runat="server" ID="btnCadastrar" CssClass="genric-btn info " Text="Cadastrar-se" Style="width: 100%" OnClick="btnCadastrar_Click" />

                        </div>
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
                            Este site tem como propósito apresentar um trabalho acadêmico. Todas suas
                            informações aqui distribuídas podem ou não serem de cunho verídico. Não há nenhum
                            vínculo com autor ou empresa real.<a />

                        </p>
                    </div>
                </div>

            </div>
        </div>
    </footer>


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
    <script src="../../js/additional-methods.min.js"></script>
    <script>
        $(document).ready(function () {
            $('#<%= txtCPF.ClientID%>').mask("999.999.999-99");


        });

        $(document).ready(function () {
            $("#form1").validate({
                rules: {
                    txtNome: {
                    required: true
                },
                     txtEmail: {
                    required: true,
                    email: true
                },
                     txtCPF: {
                         required: true,
                         cpfBR: true
                },
                    datapiker: {
                    required: true,
                    date: true
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
                     txtEmail: {
                required: "*Campo obrigatório",
                email: "Por favor, insira um email válido"
            },
                     txtCPF: {
                         required: "*Campo obrigatório",
                         cpfBR: "Por favor, insira um CPF válido"
            },
                    datapiker: {
                required: "*Campo obrigatório",
                date: "Por favor, insira uma data válida"
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
