<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Redefinir_Senha_Secure.aspx.cs" Inherits="Tipo_cad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastre-se no Caravamo</title>
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
    <link rel="stylesheet" href="../../css/magnific-popup.css" />
    <!-- swiper CSS -->
    <link rel="stylesheet" href="../../css/slick.css" />
    <!-- style CSS -->
    <link rel="stylesheet" href="../../css/style.css" />
    <link rel="stylesheet" href="../../css/jquery-ui.min.css" />
        <link rel="stylesheet" href="../../css/toastr.min.css" />
    <style>
        .aux{
            font-size: 0.5px;
        }

        .swal-text {
            text-align: center;
        }
         #password-strength-status {
            font-family: "Roboto", sans-serif;
            padding: 1px 10px;
            color: #000000;
            border-radius: 4px;
            margin-top: 5px;
        }

        .weak-password {
            background-color: #FF6600;
            border: #AA4502 1px solid;
        }

        .medium-password {
            background-color: #E4DB11;
            border: #BBB418 1px solid;
        }

        .strong-password {
            background-color: #12CC1A;
            border: #0FA015 1px solid;
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
        <div class="container" style="padding-top: 20px;">
            <hr style="padding-top: 5px;" />
            <div class="row">
                <div class="col-md-12  text-center">
                    <h2>Nova Senha</h2>

                </div>
            </div>
           
            <div class="row ">
                <div class="form-group offset-lg-3 col-6">
                    <br />
                    <p>Senha:</p>
                    <asp:TextBox runat="server" ID="txtSenha" type="password" CssClass="form-control" placeholder="Senha" onKeyUp="checkPasswordStrength()"></asp:TextBox>
                    <div id="password-strength-status"></div>
                    <label for="txtSenha" class="error" generated="true"></label>
                </div>
                <div class="col-1">
                    <br />
                    <br />

                    <button type="button" id="btn_infoSenha" class="fa fa-info mt-3 btn-info text-center" style="background-color: #ffcc00; border-color: #ffcc00; cursor: default"></button>
                </div>



            </div>

            <div class="row mt-0">
                <div class="form-group  offset-lg-3 col-6">
                    <p>Repita a Senha:</p>
                    <asp:TextBox runat="server" ID="txtSenha2" type="password" CssClass="form-control" placeholder="Repita a Senha"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row offset-lg-4 col-4">
                <asp:LinkButton runat="server" ID="btn_redefinir" OnClick="btn_redefinir_Click" class="genric-btn primary w-100">Confirmar</asp:LinkButton>
            </div>


        </div>
    </form>


    <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/Jquery-3.4.1.min.js"></script>

    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

    <script src="https://unpkg.com/@popperjs/core@2/dist/umd/popper.min.js"></script>
    <script src="https://unpkg.com/tippy.js@6/dist/tippy-bundle.umd.js"></script>
    <script src="../../js/jquery-3.3.1.slim.min.js"></script>
    <script src="../../js/jquery-1.12.1.min.js"></script>
    <script src="../../js/jquery-ui.min.js"></script>



    <script src="../../js/jquery.mask.min.js"></script>
    <script src="../../js/jquery.validate.min.js"></script>
    <script src="../../js/additional-methods.min.js"></script>
     <script src="../../js/toastr.js"></script>
    <asp:Literal ID="ltl_status" runat="server"></asp:Literal>
       <script> 
        $(document).ready(function () {
            $("#txtSenha").blur(function () {
                if ($("#txtSenha").val() == "") {
                    $('#password-strength-status').removeClass();
                    $('#password-strength-status').html("");
                };
            });
        });
       $(document).ready(function () {
            $("#<% =form1.ClientID%>").validate({
                rules: {
                        txtSenha: {
                            required: true,
                            minlength: 8
                        },
                        txtSenha2: {
                            required: true
                    }
                }, messages: {
                             txtSenha: {
                            required: "*Campo obrigatório",
                            minlength: "Por Favor, insira uma senha mais complexa"
                        },
                        txtSenha2: {
                            required: "*Campo obrigatório"
                    }
                 }
                });
            });
    </script>


    <script>
        tippy('#btn_infoSenha', {
            placement: 'bottom',
            content: 'Uma senha forte possui no mínimo 8 caracteres. Contendo letras maiúsculas,minúsculas,números e caracteres alfanuméricos.'
        });
    </script>
    <script>
        function checkPasswordStrength() {
            var number = /([0-9])/;
            var alphabets = /([a-zA-Z])/;
            var special_characters = /([~,!,@,#,$,%,^,&,*,-,_,+,=,?,>,<])/;

            if ($('#txtSenha').val().length < 7) {
                $('#password-strength-status').removeClass();
                $('#password-strength-status').addClass('weak-password');
                $('#password-strength-status').html("Senha Fraca (Inclua no minímo 8 caracteres)");
            } else {
                if ($('#txtSenha').val().match(number) && $('#txtSenha').val().match(alphabets) && $('#txtSenha').val().match(special_characters)) {
                    $('#password-strength-status').removeClass();
                    $('#password-strength-status').addClass('strong-password');
                    $('#password-strength-status').html("Senha Forte");
                } else {
                    $('#password-strength-status').removeClass();
                    $('#password-strength-status').addClass('medium-password');
                    $('#password-strength-status').html("Senha Mediana (Inclua números e caracteres alfanuméricos)");
                }
            }
        }
    </script>



    
    <div class="aux">
    <asp:Literal ID="ltl_aux" runat="server"></asp:Literal>
    </div>
</body>
</html>
