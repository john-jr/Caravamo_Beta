<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="EditarPerfil.aspx.cs" Inherits="Pages_ToUser_EditarPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link rel="stylesheet" href="../../css/toastr.min.css" />
    <style>
        .form-control {
            height: calc(1.5em + .75rem + 7px);
        }
              #password-strength-status{
          font-family:  "Roboto", sans-serif;
            padding: 1px 10px;
         color: #000000;
            border-radius: 4px;
         margin-top: 5px;
        }
        .weak-password{
            background-color: #FF6600;
    border: #AA4502 1px solid;
}
        .medium-password{
            background-color: #E4DB11;
    border: #BBB418 1px solid;
        }
        .strong-password {
    background-color: #12CC1A;
    border: #0FA015 1px solid;
}

    </style>
    <section class="container">
        <div class="row">
            <div class="col-lg-12">
                <div class="row">
                    <div class="col-lg-12 mt-30" style="text-align: center">
                        <h4>
                            <asp:Label runat="server" ID="lbl_userName" Text="Usuário01"></asp:Label>
                        </h4>
                    </div>
                    <div class="col-lg-12 mb-1" style="text-align: center">
                        <!-- <asp:Image runat="server" ImageUrl="~/img/blog/author.png"/>-->
                    </div>
                    <div class="col-lg-12 mb-30" style="text-align: center">
                        <!--<a href="#">
                            <p style="font-size: small">
                                Alterar foto
                            </p>
                        </a>-->
                    </div>
                </div>
            </div>
            <div class="col-lg-6">
                <div class="row">
                    <div class="col-lg-12 mt-2" style="text-align: center">
                        <h5><strong>Dados Pessoais</strong></h5>
                        <hr />
                    </div>
                    <div class="col-lg-12">
                        <div class="col-lg-4">
                            <h6>Nome:</h6>
                        </div>
                        <div class="col-lg-10">
                            <div class="input-group">
                                <asp:TextBox runat="server" ReadOnly="true" ID="txt_nomePessoa" CssClass="form-control"></asp:TextBox>
                                <div class="input-group-prepend">
                                    <asp:LinkButton ID="btn_editarNome" OnClick="btn_editarNome_Click" runat="server" CssClass="genric-btn primary ">
                             <i class="fa fa-pencil-alt"></i>
                                    </asp:LinkButton>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="col-lg-12 mt-4">
                        <div class="col-lg-2">
                            <h6>Email:</h6>
                        </div>
                        <div class="col-lg-10">
                            <div class="input-group">
                                <asp:TextBox runat="server" ID="txt_email" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                                <div class="input-group-prepend">
                                    <asp:LinkButton ID="btn_editarEmail" OnClick="btn_editarEmail_Click" runat="server" CssClass="genric-btn primary ">
                             <i class="fa fa-pencil-alt"></i>
                                    </asp:LinkButton>
                                </div>
                            </div>

                        </div>
                    </div>

                    <div class="col-lg-12 mt-4">
                        <div class="col-lg-12">
                            <div>
                                <h6>Alterar senha<asp:LinkButton runat="server" OnClientClick="return false" data-toggle="collapse" data-target="#collapseSenha" aria-expanded="false" aria-controls="#collapseSenha"><i class="fa fa-chevron-down ml-2" style="color: black !important"></i></asp:LinkButton></h6>
                            </div>
                        </div>
                        <div id="collapseSenha" class="collapse">
                            <div class="card-body">
                                <div class="row">
                                    <div class="col-lg-10">
                                        <h6>Senha antiga:</h6>
                                        <asp:TextBox runat="server" ID="txt_oldSenha" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-10 mt-4">
                                        <h6>Nova senha:</h6>
                                        <asp:TextBox runat="server" ID="txt_newSenha" CssClass="form-control" TextMode="Password" onKeyUp="checkPasswordStrength()"></asp:TextBox>
                                         <div id="password-strength-status"></div>
                                         <label for="txtSenha" class="error" generated="true"></label>
                                      

                                    </div>
                                    <div class="col-2">
                                          <button type="button" id="btn_infoSenha" class="fa fa-info mt-5 btn-info text-center" style="background-color: #ffcc00; border-color: #ffcc00; cursor: default; display: block;"></button>
                                    </div>

                                    <div class="col-lg-10  mt-3">
                                        <h6>Repita a senha:</h6>
                                        <asp:TextBox runat="server" ID="txt_newSenhaA" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-12 mt-30">
                                        <asp:Button runat="server" ID="btn_alterarSenha" Text="Alterar senha" OnClick="btn_alterarSenha_Click" CssClass="btn btn-outline-dark mr-3 mt-2" Style="float: right" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
            <div class="col-lg-6">
                <div class="row">
                    <div class="col-lg-12 mt-2" style="text-align: center">
                        <h5><strong>Histórico de caravanas</strong></h5>
                        <hr />
                    </div>
                    <div class="col-lg-12 mt-2">
                        <asp:Table runat="server">
                        </asp:Table>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <footer class="footer_part">
        <div class="container ">
            <hr />
            <div class="row ">
                <div class="col-lg-12">
                    <div class="copyright_text">
                        <p>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </footer>

       <script src="https://unpkg.com/@popperjs/core@2/dist/umd/popper.min.js"></script>
    <script src="https://unpkg.com/tippy.js@6/dist/tippy-bundle.umd.js"></script>

    <script src="../../js/jquery-3.3.1.slim.min.js"></script>
    <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/jquery-1.12.1.min.js"></script>
    <script src="../../js/toastr.js"></script>
    <script src="../../js/jquery.mask.min.js"></script>
    <script src="../../js/jquery.validate.min.js"></script>
    <script src="../../js/additional-methods.min.js"></script>
    <asp:Literal runat="server" ID="ltl_status"></asp:Literal>
    
    <script>
        tippy('#btn_infoSenha', {
               placement: 'right',
            content: 'Uma senha forte possui no mínimo 8 caracteres. Contendo letras maiúsculas,minúsculas,números e caracteres alfanuméricos.'
         
        });
    </script>
     <script>
        function checkPasswordStrength() {
var number = /([0-9])/;
var alphabets = /([a-zA-Z])/;
var special_characters = /([~,!,@,#,$,%,^,&,*,-,_,+,=,?,>,<])/;
           
if($('#<%= txt_newSenha.ClientID%>').val().length<7) {
$('#password-strength-status').removeClass();
$('#password-strength-status').addClass('weak-password');
$('#password-strength-status').html("Senha Fraca (Precisa ter no minímo 8 caracteres)");
} else {  	
if($('#<%= txt_newSenha.ClientID%>').val().match(number) && $('#<%= txt_newSenha.ClientID%>').val().match(alphabets) && $('#<%= txt_newSenha.ClientID%>').val().match(special_characters)) {            
$('#password-strength-status').removeClass();
$('#password-strength-status').addClass('strong-password');
$('#password-strength-status').html("Senha Forte");
} else {
$('#password-strength-status').removeClass();
$('#password-strength-status').addClass('medium-password');
$('#password-strength-status').html("Senha Mediana (Inclua números e caracteres alfanuméricos)");
}}}
    </script>
       <script>
           $(document).ready(function () {
               $("<%= txt_newSenha.ClientID%>").blur(function () {
                   if ($("#<%= txt_newSenha.ClientID%>").val() == "") {
                       $('#password-strength-status').removeClass();
                       $('#password-strength-status').html("");

                   };
               });
           });
           </script>

</asp:Content>

