<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="Caravana_Criador.aspx.cs" Inherits="Pages_ToUser_Caravana_Criador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>
        .linkHover:hover {
            color: black;
        }

        .bs-example {
            margin: 20px;
        }

        .rotate {
            -webkit-transform: rotate(90deg); /* Chrome, Safari, Opera */
            -moz-transform: rotate(90deg); /* Firefox */
            -ms-transform: rotate(90deg); /* IE 9 */
            transform: rotate(90deg); /* Standard syntax */
        }
    </style>

    <div class="container col-11 ">

        <section class="container mb-30">
            <div class="row">
                <div class="col-lg-12 mt-30" style="text-align: center">
                    <asp:Label runat="server" CssClass="h2">Título da Caravana</asp:Label>
                </div>
                <div class="col-lg-12 mt-1" style="text-align: center">
                    <asp:Label runat="server" CssClass="h6">12/04/2020</asp:Label>
                </div>
            </div>
        </section>

        <section>
            <nav class="nav nav-tabs mb-30">
                <a href="#" class="nav-item nav-link active">
                    <i class="fa fa-file-alt mr-1"></i>Visualização Geral
                </a>
                <a href="Visualizar_proposta.aspx" class="nav-item nav-link" style="color: #495057 !important">
                    <i class="fa fa-dollar-sign mr-1"></i>Propostas recebidas
                </a>
                <a href="Convite.aspx" class="nav-item nav-link" style="color: #495057 !important">
                    <i class="fa fa-envelope mr-1"></i>Convites
                </a>
                <a href="#" class="nav-item nav-link" style="color: #495057 !important">
                    <i class="fa mr-1"></i>Editar informações
                </a>
            </nav>
        </section>

        <div class="row">
            <div class="container col-lg-3">
                <div class="col-lg-12 col-12">
                    <asp:Image runat="server" src="../../img/Estádio-Anfield-Road.jpg" />
                </div>
                <div class="col-lg-12 mt-30">
                    <div class="text-black-50">
                        <h3>Descrição</h3>
                        <asp:Label runat="server" ID="lblTxt">Lorem ipsum dolor sit amet consectetur adipiscing elit aliquam neque, 
                            parturient at erat eget ante nam nec finibus, praesent a metus hendrerit rhoncus ornare taciti porttitor.
                            Enim libero massa finibus diam taciti cursus class primis,</asp:Label>
                    </div>
                </div>
                <div class="row col-lg-12 offset-lg-0 offset-1 mt-30">
                    <div class="col-4">
                        <a href="#">
                            <img src="../../img/Facebook.png" style="max-width: 40px; height: auto;" /></a>
                    </div>
                    <div class="col-4">
                        <a href="#">
                            <img src="../../img/Twitter.png" style="max-width: 40px; height: auto;" /></a>
                    </div>
                    <div class="col-4">
                        <a href="#">
                            <img src="../../img/Share.png" style="max-width: 40px; height: auto;" /></a>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12 col-12 mt-30">
                        <div style="text-align: center">
                            <a href="#">
                                <p class="linkHover">Denunciar</p>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="container col-lg-6 mt-lg-0 mt-30">
                <div class="row">
                    <div class="col-lg-3 col-4" style="margin-right: -60px">
                        <p>Criado por: </p>
                    </div>
                    <div class="col-lg-1 col-4">
                        <p>
                            <asp:Label runat="server" ID="lblCriador">Usuario02</asp:Label>
                        </p>
                    </div>
                </div>
                <hr />
                <div class=" col-lg-12">
                    <div class="row">
                        <div class="col-lg-1 col-1" style="padding-left: 25px">
                            <img src="../../img/calendar-6.png" style="max-width: 20px; height: auto;" />
                        </div>
                        <div class="col-lg-10 col-2">
                            <h4>Datas</h4>
                        </div>
                    </div>
                    <div class="row">
                        <div class="offset-lg-1 col-lg-4">
                            <div class="row">
                                <div class="col-lg-5 col-2">
                                    <p>Saída:</p>
                                </div>
                                <div class="col-lg-6 col-4">
                                    <p>
                                        <asp:Label runat="server" ID="Label1">03/04/2019</asp:Label>
                                    </p>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-5 col-3">
                                    <p>Retorno:</p>
                                </div>
                                <div class="col-lg-6 col-4">
                                    <p>
                                        <asp:Label runat="server" ID="Label2">03/04/2019</asp:Label>
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-7">
                            <div class="row">
                                <div class="col-lg-8 offset-lg-1 col-7">
                                    <p>Horário de saída previsto:</p>
                                </div>
                                <div class="col-lg-1 col-1">
                                    <p>
                                        <asp:Label runat="server" ID="Label4">8h30</asp:Label>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <hr />
                <div class="col-lg-12">
                    <h4>Origem</h4>
                    <div class="offset-lg-1">
                        <p>
                            <asp:Label runat="server" ID="Label3">Guaratinguetá - SP </asp:Label>
                        </p>
                    </div>
                    <div>
                        <div class="row">
                            <div class="col-lg-1 col-1" style="padding-left: 25px">
                                <img src="../../img/placeholder-2.png" style="max-width: 20px; height: auto;" />
                            </div>
                            <div class="col-lg-10 col-10">
                                <p>
                                    <asp:Label runat="server" ID="Label5">Av. Juscelino Kubtscheck de Oliveira, 351 - Campo do Galvão</asp:Label>
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-2 col-3 offset-lg-1">
                            <a href="#">
                                <p>Paradas</p>
                            </a>
                        </div>
                        <div class="col-lg-1 col-1">
                            <a href="#">
                                <img src="../../img/menu_down.png" style="max-width: 20px; height: auto;" />
                            </a>
                        </div>
                    </div>
                </div>
                <hr />
                <div class="col-lg-12">
                    <h4>Destino</h4>
                    <div class="offset-lg-1">
                        <p>
                            <asp:Label runat="server" ID="Label6">São Paulo - SP </asp:Label>
                        </p>
                    </div>
                    <div>
                        <div class="row">
                            <div class="col-lg-1 col-1" style="padding-left: 25px">
                                <img src="../../img/placeholder-2.png" style="max-width: 20px; height: auto;" />
                            </div>
                            <div class="col-lg-10 col-10">
                                <p>
                                    <asp:Label runat="server" ID="Label7">Autódromo de Interlagos</asp:Label>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
                <hr />

                <div class="col-lg-12">
                    <h4>Informações da Empresa</h4>
                    <%--<div class="offset-1">
                        <p>Empresa responsavel: GR Tur </p>
                    </div>--%>
                    <div class="row">
                        <div class="col-lg-4 offset-lg-1 col-6">
                            <p>Empresa responsável:</p>
                        </div>
                        <div class="col-lg-4 col-4">
                            <p>
                                <asp:Label runat="server" ID="Label8">GR Tur</asp:Label>
                            </p>
                        </div>
                    </div>
                </div>
                <hr />

                <div class="col-lg-12">
                    <h4>Detalhes do(s) Veículo(s)</h4>
                    <div class="row offset-lg-1">
                        <div class="col-lg-6">
                            <div class="row">
                                <div class="col-6 col-lg-10">
                                    <p>Quantidade de Lugares:</p>
                                </div>
                                <div class="col-2 col-lg-1">
                                    <p>
                                        <asp:Label runat="server" ID="Label9">16</asp:Label>
                                    </p>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-6 col-lg-8">
                                    <p>Ar condicionado:</p>
                                </div>
                                <div class="col-2">
                                    <p>
                                        <asp:Label runat="server" ID="Label10">Sim</asp:Label>
                                    </p>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-6 col-lg-5">
                                    <p>Wi-fi:</p>
                                </div>
                                <div class="col-2">
                                    <p>
                                        <asp:Label runat="server" ID="Label11">Sim</asp:Label>
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6 mt-10 mt-lg-0">
                            <asp:Image runat="server" src="../../img/van.png" Style="max-width: 150px; height: auto;" />
                        </div>
                    </div>
                </div>
                <hr class="d-block d-sm-none" />
            </div>
            <div class="container col-lg-3">
                <div class="col-lg-12">
                    <h4>Vagas</h4>
                </div>
                <div class="row col-lg-12">
                    <div class="col-lg-6 col-4">
                        <p>Total:</p>
                    </div>
                    <div class="col-4">
                        <p>
                            <asp:Label runat="server" ID="Label12">16</asp:Label>
                        </p>
                    </div>
                </div>
                <div class="row col-lg-12">
                    <div class="col-lg-6 col-4">
                        <p>Disponível:</p>
                    </div>
                    <div class="col-1">
                        <p>
                            <asp:Label runat="server" ID="Label13">10</asp:Label>
                        </p>
                    </div>
                </div>
                <div class="row col-lg-12">
                    <div class="col-lg-6 col-4">
                        <p>Interessados:</p>
                    </div>
                    <div class="col-2">
                        <p>
                            <asp:Label runat="server" ID="Label14">10</asp:Label>
                        </p>
                    </div>
                </div>
                <div class="row col-lg-12">
                    <div class="col-lg-6 col-4">
                        <p>Inscritos:</p>
                    </div>
                    <div class="col-1">
                        <p>
                            <asp:Label runat="server" ID="Label15">8</asp:Label>
                        </p>
                    </div>
                </div>
                <hr class="d-block d-sm-none" />
                <div class="row col-lg-12 mt-30">
                    <div class="col-lg-5">
                        <h4>Preço</h4>
                    </div>
                </div>
                <div class="row col-lg-8 offset-lg-2 mt-lg-10" style="text-align: center">
                    <div class="col-lg-12 mt-lg-10" style="text-align: center">
                        <p>
                            R$
                            <asp:Label runat="server" ID="Label17" CssClass="h5">80,00</asp:Label>
                        </p>
                        <p style="margin-top: -10px">(por pessoa)</p>
                    </div>
                </div>
                <div class="row mt-30">
                    <div class="col-lg-12 mt-lg-30">
                        <div class="col-lg-10 offset-lg-1">
                            <asp:Button runat="server" ID="btn_Inscrever" Text="Inscrever alguém" data-toggle="modal" data-target="#modal" CssClass="btn btn-outline-secondary btn-block" OnClick="btn_Inscrever_Click" />
                            <%--<button data-toggle="modal" data-target="#myModal" class="btn btn-outline-secondary btn-block">Inscrever Alguém</button>--%>
                        </div>
                    </div>
                </div>
                <div class="col-lg-12 mt-30 mb-5" style="text-align: center">
                    <a href="#">
                        <h4 class="linkHover"><a href="#" class="fa fa-comment-dots mr-1" style="color: black"></a>CHAT</h4>
                    </a>
                </div>
                <div class="col-lg-12 mt-30" style="text-align: center">
                    <a href="#">
                        <p class="linkHover">Cancelar Inscrição</p>
                    </a>
                </div>
            </div>
        </div>
    </div>

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

    <div class="modal fade" id="modal">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <!-- Modal Header -->
                <div class="modal-header mt-2 ml-2">
                    <h3>Inscrever participantes</h3>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>
                <!-- Modal body -->
                <div class="container col-12 mt-2">
                    <div class="row">
                        <div class="bs-example" style="width: 100% !important">
                            <div id="accordion">
                                <div class="card">
                                    <div class="card-header">
                                        <h4 class="card-title">Insira as informações do participante</h4>
                                    </div>
                                    <div class="card-body">
                                        <div class="row">
                                            <div class="col-lg-12">
                                                <h5>Nome completo:</h5>
                                            </div>
                                            <div class="col-lg-12 mb-2">
                                                <asp:TextBox runat="server" placeholder="Nome do participante" required="required" CssClass="form-control" ValidationGroup="Validar" ID="txt_nomePart"></asp:TextBox>
                                            </div>
                                            <div class="col-lg-3 mt-2">
                                                <h5>CPF:</h5>
                                                <asp:TextBox runat="server" placeholder="000.000.000-00" required="required" CssClass="form-control" ValidationGroup="Validar" ID="txt_cpfPart"></asp:TextBox>
                                            </div>
                                            <div class="col-lg-4 offset-lg-2 mt-2">
                                                <h5>Data de Nascimento:</h5>
                                                <asp:TextBox runat="server" required="required" TextMode="Date" CssClass="form form-control" ValidationGroup="Validar" ID="txt_dataNascPart"></asp:TextBox>
                                                <%--ValidationGroup="Validar"--%>
                                            </div>
                                            <div class="col-lg-12 mt-5 mt-lg-0">
                                                <asp:Button runat="server" Text="Adicionar" CssClass="btn btn-outline-secondary mr-3" Style="float: right" ID="btn_adicionar" OnClick="btn_adicionar_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-12">
                            <%--<div class="card">
                                    <div class="card-body">
                                        <div class="row">
                                            <div class="col-lg-12">
                                                <h5>Nome completo:</h5>
                                            </div>
                                        </div>
                                    </div>
                                </div>--%>
                        </div>
                    </div>
                    <!-- Modal footer -->
                    <div class="modal-footer mt-3">
                        <div class="container text-center">
                            <div class="row">
                                <div class="col-lg-12 mt-5 mt-lg-0">
                                    <asp:Button runat="server" Text="Concluir" CssClass="btn btn-outline-dark mr-3" Style="float: right" ID="btn_modal2" OnClick="btn_modal2_Click1" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src="../../js/jquery-3.3.1.min.js"></script>
    <script src="../../js/bootstrap.min.js"></script>
    <script>
        $(document).ready(function () {
            // Add minus icon for collapse element which is open by default
            $(".collapse.in").each(function () {
                $(this).siblings(".panel-heading").find(".fa").addClass("rotate");
            });

            // Toggle plus minus icon on show hide of collapse element
            $(".collapse").on('show.bs.collapse', function () {
                $(this).parent().find(".fa").addClass("rotate");
            }).on('hide.bs.collapse', function () {
                $(this).parent().find(".fa").removeClass("rotate");
            });
        });
    </script>
</asp:Content>

