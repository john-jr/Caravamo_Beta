<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Visitor.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Pages_ToVisitor_Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <style>
        .search_form,
        .search_your_country {
            border-radius: 5px;
        }

       .pesquisar{
            margin-top: -10px;
        }


        .tile {
            width: 100%;
            background: #fff;
            border-radius: 5px;
            box-shadow: 0px 2px 3px -1px rgba(151, 171, 187, 0.7);
            float: left;
            transform-style: preserve-3d;
            margin: 10px 5px;

        }


        .dates {
            border: 1px solid #ebeff2;
            border-radius: 5px;
            padding: 20px 0px;
            margin: 10px 20px;
            font-size: 16px;
            
          
            font-weight: 600;
            overflow: auto;
        }

        .dates div {
            float: left;
            width: 50%;
            text-align: center;
            position: relative;
        }

        .dates strong,
        .stats strong {
            display: block;
            color: #adb8c2;
            font-size: 11px;
            font-weight: 700;
        }

        .dates span {
            width: 1px;
            height: 40px;
            position: absolute;
            right: 0;
            top: 0;
            background: #ebeff2;
        }

        .stats {
            border-top: 1px solid #ebeff2;
            background: #f7f8fa;
            overflow: auto;
            padding: 15px 0;
            font-size: 16px;
            color: #59687f;
            font-weight: 600;
            border-radius: 0 0 5px 5px;
        }

        .stats div {
            border-right: 1px solid #ebeff2;
            width: 33.33333%;
            float: left;
            text-align: center
        }

        .stats div:nth-of-type(3) {
            border: none;
        }

        div.footer {
            text-align: right;
            position: relative;
            margin: 20px 5px;
        }

        div.footer a.Cbtn {
            padding: 10px 25px;
            background-color: #DADADA;
            color: #666;
            margin: 10px 2px;
            text-transform: uppercase;
            font-weight: bold;
            text-decoration: none;
            border-radius: 3px;
        }

        div.footer a.Cbtn-primary {
            background-color: #5AADF2;
            color: #FFF;
        }

        div.footer a.Cbtn-primary:hover {
            background-color: #7dbef5;
        }

        div.footer a.Cbtn-danger {
            background-color: #fc5a5a;
            color: #FFF;
        }

        div.footer a.Cbtn-danger:hover {
            background-color: #fd7676;
        }

        .header1 {
            border-bottom: 1px solid #ebeff2;
            padding: 19px 0;
            text-align: center;
            color: #59687f;
            font-size: 600px;
            font-size: 19px;
            position: relative;
        }
    </style>


     <section class="banner_part">

        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-12 text-center">
                    <div class="banner_text">
                        <div class="banner_text_iner">
                            <h5><img src="../../img/logoB.png" style="width: 50%;"></h5>
                            <h1>Uma nova maneira de viajar</h1>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- banner part start-->

    <!-- banner part start-->
    <section class="search_your_country">
        <div class="container-fluid">
            <div class="row align-items-center">
                <div class="col-lg-12">
                    <div class="search_form">
                       
                            <div class="form-row">
                                <div class="col-lg-12">
                                    <div class="search_form_iner">
                                        <div class="col-12">
                                            <div class="p-2 bg-light rounded rounded-pill shadow-sm mb-4">
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <button id="button-addon2" type="submit"
                                                            class="btn btn-link text-warning"><i
                                                                class="fa fa-search"></i></button>
                                                    </div>
                                                    <asp:TextBox runat="server"  type="search"  aria-describedby="button-addon2" placeholder="Pesquise por destinos,saídas ou eventos..." CssClass="form-control border-0 bg-light"></asp:TextBox>


              
                                                    
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-12">
                                    <asp:Button runat="server" ID="btn_pesquisa_index" CssClass="genric-btn btn_1 search_btn circle pesquisar"  OnClick="btn_pesquisa_index_Click" Text="Pesquisar" />
                                  
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

    </section>
    <!-- banner part start-->

    <!-- feature_part start-->
    <h1 class="text-center">Caravanas Recentes</h1>

    <section class="tour_package section_padding">

        <div class="container-fluid">

            <div class="row align-items-center">

                <div class="col-lg-12 col-sm-12">
                    <div class="tour_package_cotent owl-carousel">
                        <div class="tile">
                            <div class="wrapper">
                                <div class="header">
                                    <h3 class="text-center">CCXP 2019</h3>
                                </div>

                                <div class="banner-img">
                                    <img src="../../img/index_images/ccxp19.jpg" alt="Image 1">
                                </div>

                                <div class="dates">
                                    <div class="start">
                                        <strong>Data de saída:</strong> 22/09/2019
                                        <span></span>
                                    </div>
                                    <div class="ends">
                                        <strong>Data de Chegada:</strong> 22/09/2019
                                    </div>
                                </div>

                                <div class="dates">
                                    <div class="start">
                                        <strong>Endereço de Origem:</strong>São Paulo - SP
                                        <span></span>
                                    </div>
                                    <div class="ends">
                                        <strong>Endereço de Destino:</strong> São Caetano - SP
                                    </div>
                                </div>



                                <div class="footer1">
                                    <div class="tour_content_rating btnJoin">
                                        <a href="#" class="genric-btn primary" data-toggle="modal"
                                        data-target="#loginModal">Mais informações</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tile">
                            <div class="wrapper">
                                <div class="header">
                                    <h3 class="text-center">Corinthians vs Flamengo</h3>
                                </div>

                                <div class="banner-img">
                                    <img src="../../img/index_images/corintihansVSflamengo.jpg" alt="Image 1">
                                </div>

                                <div class="dates">
                                    <div class="start">
                                        <strong>Data de saída:</strong> 22/09/2019
                                        <span></span>
                                    </div>
                                    <div class="ends">
                                        <strong>Data de Chegada:</strong> 22/09/2019
                                    </div>
                                </div>

                                <div class="dates">
                                    <div class="start">
                                        <strong>Endereço de Origem:</strong>São Paulo - SP
                                        <span></span>
                                    </div>
                                    <div class="ends">
                                        <strong>Endereço de Destino:</strong> São Caetano - SP
                                    </div>
                                </div>



                                <div class="footer1">
                                    <div class="tour_content_rating btnJoin">
                                        <a href="#" class="genric-btn primary "  data-toggle="modal"
                                        data-target="#loginModal">Mais informações</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="tile">
                            <div class="wrapper">
                                <div class="header">
                                    <h3 class="text-center">São José dos Campos</h3>
                                </div>

                                <div class="banner-img">
                                    <img src="../../img/index_images/noimg.png" alt="Image 1">
                                </div>

                                <div class="dates">
                                    <div class="start">
                                        <strong>Data de saída:</strong> 22/09/2019
                                        <span></span>
                                    </div>
                                    <div class="ends">
                                        <strong>Data de Chegada:</strong> 22/09/2019
                                    </div>
                                </div>

                                <div class="dates">
                                    <div class="start">
                                        <strong>Endereço de Origem:</strong>São Paulo - SP
                                        <span></span>
                                    </div>
                                    <div class="ends">
                                        <strong>Endereço de Destino:</strong> São Caetano - SP
                                    </div>
                                </div>



                                <div class="footer1">
                                    <div class="tour_content_rating btnJoin">
                                        <a href="#" class="genric-btn primary "  data-toggle="modal"
                                        data-target="#loginModal">Mais informações</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>
    <!-- upcoming_event part start-->
    <section>


        <div class="section_title text-center">
            <h2>Sobre o Caravamo </h2>
        </div>
           
        <div class="container-fluid">
        <div class="row">
                <div class="col-12 col-lg-6">
                    <p >
                        O Caravamo surgiu como um projeto de conclusão de curso da Fatec Guaratinguetá, ele tem como
                        objetivo facilitar a vida daqueles que desejam fazer algum tipo de viagem de ônibus ou van
                        enquanto fornece um espaço para as empresas desse ramo divulgarem seus serviços de maneira que
                        ambas as partes aproveitem das funcionalidades do sistema: O usuário pode criar salas de viagens
                        - Caravanas - e escolher a melhor empresa que atende suas necessidades dentre as que se
                        propuseram realizar a viagem. No outro lado,a empresa irá receber requisições das caravanas que
                        não possuem motorista e poderão atribuir sua proposta escolhendo o motorista que irá fazer a
                        viagem, o veículo, e o preço total do serviço, esse que será dividido por todos da caravana para
                        o pagamento da viagem. Ao terminar, você ainda poderá avaliar a sua experiência com os recursos oferecidos pela empresa, o que nos ajuda a definir um rank das empresas com melhores serviços da região!
                    </p>

                </div>
                <div class=" col-lg-6 col-12">
                        <img src="../../img/index_images/bus1.jpg" alt="Image 1" style="border-radius: 10px;
                        border: 3px solid #ffcc00;">
                </div>
            </div>
            <div class="row">
               
                <div class="col-m-12 col-lg-12">
                    <br>
                    <p style="text-align: justify;">
                       Temos como princípios a fidelidade, satisfação e conforto de nossos clientes na utilização do site. Nossa filosofia é que toda viagem feita no sistema deve ser aproveitada e beneficiosa para ambas as partes: nossos usuários satisfeitos com o preço e a empresa escolhida ,e nossas empresas satisfeitas com o preço proposto para os usuários e com os próprios recursos disponíveis para elas no site.
                    
                    </p>

                </div>
            </div>
        </div>
       
    </section>
   

  


    <!-- use sasu part end-->
    <section class="popular_place">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-lg-5">
                    <div class="section_tittle text-center">
                        <br>
                        <h2>Como usar<span> o site</span> </h2>
                    </div>
                </div>
            </div>
            <div class="row justify-content-center">
                <div class="col-lg-4 col-sm-6">
                    <div class="single_popular_place">
                        <img src="../../img/index_images/Crie_sua_conta.png" alt="">
                        <h4>1 - Crie uma conta</h4>
                        <p>Crie uma conta no sistema,não se esqueça de colocar uma foto bem legal!</p>
                        <br>

                    </div>
                </div>
                <div class="col-lg-4 col-sm-6">
                    <div class="single_popular_place">
                        <img src="../../img/index_images/Procuresuacaravana.png" alt="">
                        <h4>2 - Pesquise uma Caravana</h4>
                        <p>Pesquise por um evento, um destino ou uma cidade de saída.</p>
                        <br>

                    </div>
                </div>
                <div class="col-lg-4 col-sm-6">
                    <div class="single_popular_place">
                        <img src="../../img/index_images/Se_inscreva.png" alt="">
                        <h4>3 - Se inscreva!</h4>
                        <p>Junte-se a uma caravana e divida o preço da viagem com outras pessoas!</p>
                        <br>
                      

                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- use sasu part end-->



    <!-- blog part start-->

    <!-- blog part end-->

    <!--::footer_part start::-->
    <footer class="footer_part">
        <div class="container ">

            <hr>
            <div class="row ">
                <div class="col-lg-12  ">
                    <div class="copyright_text">
                        <P>
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                            Este site tem como propósito apresentar um trabalho acadêmico. Todas suas
                            informações aqui distribuídas podem ou não serem de cunho verídico. Não há nenhum
                            vínculo com autor ou empresa real.</a>
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        </P>
                    </div>
                </div>

            </div>
        </div>

    </footer>
    
    <script src="../../js/jquery-1.12.1.min.js"></script>
    <script src="../../js/popper.min.js"></script>
    <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/jquery.magnific-popup.js"></script>
    <script src="../../js/owl.carousel.min.js"></script>
    <script src="../../js/jquery.nice-select.min.js"></script>
    <script src="../../js/slick.min.js"></script>
    <script src="../../js/jquery.counterup.min.js"></script>
    <script src="../../js/waypoints.min.js"></script>
    <script src="../../js/contact.js"></script>
    <script src="../../js/jquery.ajaxchimp.min.js"></script>
    <script src="../../js/jquery.form.js"></script>
    <script src="../../js/jquery.validate.min.js"></script>
    <script src="../../js/mail-script.js"></script>
    <script src="../../js/custom.js"></script>




</asp:Content>

