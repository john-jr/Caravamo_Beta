<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="EditarPerfil.aspx.cs" Inherits="Pages_ToUser_EditarPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>
        .form-control{
            height: calc(1.5em + .75rem + 7px);
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
                                   <asp:LinkButton ID="btn_editarNome" OnClick="btn_editarNome_Click" runat="server" CssClass="genric-btn primary " >
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
                                   <asp:LinkButton ID="btn_editarEmail" OnClick="btn_editarEmail_Click" runat="server" CssClass="genric-btn primary " >
                             <i class="fa fa-pencil-alt"></i>
                            </asp:LinkButton>
                                    </div>
                                  </div>

                        </div>
                    </div>
                    <div class="col-lg-12 mt-4">
                        <div class="col-lg-12">
                            <div data-toggle="collapse" data-target="#collapse">
                                <h6>Alterar senha<i class="fa fa-chevron-down ml-2" style="color: black !important"></i></h6>
                            </div>
                        </div>
                        <div id="collapse" class="collapse card">
                            <div class="card-body">
                                <div class="col-lg-12">
                                    <h6>Senha antiga:</h6>
                                    <asp:TextBox runat="server" ID="txt_oldSenha" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                </div>
                                <div class="col-lg-12 mt-3">
                                    <h6>Nova senha:</h6>
                                    <asp:TextBox runat="server" ID="txt_newSenha"  CssClass="form-control" TextMode="Password"></asp:TextBox>
                                </div>
                                <div class="col-lg-12 mt-3">
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

    <script src="../../js/jquery-3.3.1.slim.min.js"></script>
    <script src="../../js/bootstrap.min.js"></script>
</asp:Content>

