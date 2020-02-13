<%@ Page Title="" Language="C#" MasterPageFile="../../Pages/Masters/User.master" AutoEventWireup="true" CodeFile="detalhe_caravana.aspx.cs" Inherits="detalhe_caravana" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container col-11 ">
        <div class="Container text-center mb-3">
            <h1>Titulo da Caravana</h1>
            <br />
            <h4>03/04/2019</h4>
        </div>
        <div class="row ">
            <div class="container col-lg-3">
                <div class="col-lg-12">
                    <img src="../../img/Estádio-Anfield-Road.jpg" />
                </div>
                <div class="col-lg-12 mt-30">
                    <div class="text-black-50">
                        <h3>Descrição</h3>
                        <asp:Label runat="server" ID="lblTxt">Lorem ipsum dolor sit amet consectetur adipiscing elit aliquam neque, 
                            parturient at erat eget ante nam nec finibus, praesent a metus hendrerit rhoncus ornare taciti porttitor.
                            Enim libero massa finibus diam taciti cursus class primis,</asp:Label>

                    </div>

                </div>
                <div class="row col-lg-12 mt-30">
                    <div class="col-4">
                        <a href="#">
                            <img src="../../img/Facebook.png" style="max-width: 40px; height: auto;" /></a>
                    </div>
                    <div class="col-4">
                        <a href="#">
                            <img src="../..//Twitter.png" style="max-width: 40px; height: auto;" /></a>
                    </div>
                    <div class="col-4">
                        <a href="#">
                            <img src="../../img/Share.png" style="max-width: 40px; height: auto;" /></a>
                    </div>
                </div>

            </div>
            <div class="container col-lg-6">
                <div class="col-lg-12">
                    <asp:Label runat="server" ID="lblCriador">Criado por: Usuario02</asp:Label>
                </div>
                <hr />
                <div class=" col-lg-12">
                    <img src="../../img/calendar-6.png" style="max-width: 20px; height: auto;" /><h4>Datas</h4>
                    <div class="row ">
                        <div class="offset-1 col-lg-4">
                            <p>Saída:   03/04/2019 </p>
                            <p>Retorno: 03/04/2019</p>

                        </div>
                        <div class="col-lg-7">
                            <p>Horario de saída previsto:   8h30</p>
                        </div>
                    </div>
                </div>
                <hr />
                <div class="col-lg-12">
                    <h4>Origem</h4>
                    <div class="offset-1">
                        <p>Guaratinguetá - SP </p>

                        <img src="../../img/placeholder-2.png" style="max-width: 20px; height: auto;" /><p>Av. Juscelino Kubtscheck de Oliveira, 351 - Campo do Galvão</p>

                        <a href="#">
                            <p>Paradas</p>
                            <img src="../../img/menu_down.png" style="max-width: 20px; height: auto;" /></a>
                    </div>

                </div>
                <hr />
                <div class="col-lg-12">
                    <h4>Destino</h4>
                    <div class="offset-1">
                        <p>Guaratinguetá - SP </p>

                        <img src="../../img/placeholder-2.png" style="max-width: 20px; height: auto;" /><p>Av. Juscelino Kubtscheck de Oliveira, 351 - Campo do Galvão</p>


                    </div>

                </div>
                <hr />

                <div class="col-lg-12">
                    <h4>Informações da Empresa</h4>
                    <div class="offset-1">
                        <p>Empresa responsavel: GR Tur </p>


                    </div>

                </div>
                <hr />

                <div class="col-lg-12">
                    <h4>Detalhes do(s) Veículo(s)</h4>
                    <div class="row offset-1">
                        <div class="col-lg-6">
                            <p>Quantidade de Lugares:16</p>
                            <p>Ar condicionado: Sim</p>
                            <p>Wifi: Sim</p>
                        </div>
                        <div class="col-lg-6">
                            <img src="../../img/Estádio-Anfield-Road.jpg" style="max-width: 150px; height: auto;" /></div>

                    </div>

                </div>

            </div>
            <div class="container col-lg-3">
                <div class="col-lg-12">
                    <h4>Vagas</h4>
                </div>
                <div class="row col-lg-12">
                    <div class="col lg-6">
                        <p>Disponivel/Total</p>
                    </div>
                    <div class="col lg-6">
                        <p>10/16</p>
                    </div>
                </div>
                <div class="row col-lg-12 ">
                    <div class="col-lg-6">
                        <p>Interessados</p>
                    </div>
                    <div class="col-lg-6 float-right">
                        <p >16</p>
                    </div>

                </div>
                <div class="col-lg-12">
                    <p>Inscritos</p>
                </div>

            </div>
        </div>
    </div>

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


</asp:Content>

