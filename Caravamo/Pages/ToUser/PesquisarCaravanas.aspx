<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="PesquisarCaravanas.aspx.cs" Inherits="Pages_ToUser_PesquisarCaravanas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>
        .search_your_country {
            padding: 10px 10px 0 10px;
            margin-top: 10px;
            border-radius: 5px;
        }

        #btn_filtrar {
            background-color: black;
            color: white;
        }

            #btn_filtrar:hover {
                border: 1px solid white;
            }


        #datepicker {
            border-width: 0px;
            border: none;
        }

        #resultados {
            padding-top: 8px;
        }

        hr {
            border: 0;
            border-top: 1px solid #e3e6f0;
        }

        #filtros {
            border-radius: 5px;
            padding: 10px;
        }


        label {
            display: block;
            text-align: center;
        }

        .filter-col {
            padding-left: 10px;
            padding-right: 10px;
        }

        .nice-select {
            background-color: #e9ecef !important;
            min-width: 150px;
            width: 100%;
            font-size: 15px;
        }

        .option {
            width: 100% !important;
            text-align: center !important;
        }

        .bnt_1:hover {
            background-color: transparent;
            color: black !important;
        }

        .tile {
            background: #fff;
            border-radius: 5px;
            box-shadow: 0px 2px 3px -1px rgba(151, 171, 187, 0.7);
            transform-style: preserve-3d;
            margin: 10px 5px;
            display: inline;
        }


        .dates {
            border: 1px solid #ebeff2;
            border-radius: 5px;
            padding: 10px 0px;
            margin: 10px 20px;
            font-size: 16px;
            columns: #000000;
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
    </style>

    <section class="search_your_country">
        <div class="p-1 bg-light rounded rounded-pill shadow-sm mb-4">
            <div class="input-group">
                <div class="input-group-prepend">
                    <asp:LinkButton runat="server" BorderColor="#f8f9fa" BorderStyle="none" ID="btn_pesquisa" OnClick="btn_pesquisa_Click" BorderWidth="0px" Style="background-color: #f8f9fa; padding: 8px">
                        <i class="fa fa-search" style="color: black"></i>
                    </asp:LinkButton>
                </div>
                <asp:TextBox type="search" placeholder="Pesquise por destinos, saídas ou eventos..." aria-describedby="button-addon2"
                    CssClass="form-control border-0 bg-light" ID="txt_Pesquisa" runat="server"></asp:TextBox>
            </div>
        </div>
    </section>

    <hr />

    <section>
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-3 col-12">
                    <header class="card-header" data-toggle="collapse" data-target="#filtros" style="border-radius: 5px;">
                        <h6 class="title">Filtros <i class="fa fa-fw fa-caret-down" style="text-align: left;"></i></h6>
                    </header>

                    <div class="card collapse in" id="filtros">
                        <article class="card-group-item ">
                            <div class="filter-content" style="border-top: 0 solid transparent;">
                                <div class="card-body">
                                    <label for="datepicker">Organizar Por:</label>
                                    <asp:DropDownList runat="server" ID="DropDownList4" CssClass="mb-2">
                                        <%--<asp:ListItem Text="Estado" Selected="True" Value=""></asp:ListItem>--%>
                                        <asp:ListItem Value="Recent">Mais Recentes</asp:ListItem>
                                         <asp:ListItem Value="Old">Mais Antigas</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </article>
                      
                        
                        <!-- card-group-item.// -->
                        <article class="card-group-item">
                            <hr>
                            <div class="filter-content">
                                <div class="card-body">

                                    <%--<button type="submit" id="btn_filtrar" class="btn_1" style="width: 100%;">Filtrar</button>--%>
                                    <asp:Button type="submit" runat="server" ID="btn_filtrar" CssClass="btn_1" Style="width: 100%" Text="Filtrar" OnClick="btn_filtrar_Click" />

                                </div>
                                <!-- card-body.// -->
                            </div>
                        </article>
                        <!-- card-group-item.// -->

                    </div>
                </div>

                <div class="col-12 col-lg-9">
                    <div class="col-12">
                        <asp:Label runat="server" ID="ltl_resultados" CssClass="h5">3 Resultados Encontrados</asp:Label>
                    </div>

                    <asp:PlaceHolder ID="phl_caravans" runat="server"></asp:PlaceHolder>

                     

                    

                    
                </div>

            </div>
        </div>
         

                    

                    
           
      
  
        <!--<li>
                <label for="categoria">Categoria:</label>
                <select class="mr-sm-2" id="categoria">
                    <option value="" disabled hidden selected>Selecione...
                    </option>
                    <option value="1">Futebol</option>
                    <option value="2">Show</option>
                    <option value="3">Turismo</option>
                    <option value="4">Educacional</option>
                    <option value="5">Corporativo</option>
                    <option value="6">Religioso</option>
                    <option value="7">Esportivo</option>
                    <option value="8">Cultural</option>
                </select>
            </li>-->

    </section>

    <footer class="footer_part">
        <div class="container ">

            <hr>
            <%--<div class="row ">
                <div class="col-lg-12  ">
                    <div class="copyright_text">
                        <p>
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                            Este site tem como propósito apresentar um trabalho acadêmico. Todas suas
                            informações aqui distribuídas podem ou não serem de cunho verídico. Não há nenhum
                            vínculo com autor ou empresa real.</a>
                           
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        </p>
                    </div>
                </div>
            </div>--%>
        </div>

    </footer>

    <!--::footer_part end::-->

    <!-- jquery plugins here-->
    <!-- jquery -->
    <%--<script src="../../js/jquery-1.12.1.min.js"></script>--%>
    <script src="../../js/jquery-3.3.1.slim.min.js"></script>
    <!-- popper js -->
    <script src="../../js/popper.min.js"></script>
    <!-- bootstrap js -->
    <script src="../../js/bootstrap.min.js"></script>
    <!-- easing js -->
    <script src="../../js/jquery.magnific-popup.js"></script>

    <!-- particles js -->
    <script src="../../js/owl.carousel.min.js"></script>
    <script src="../../js/jquery.nice-select.min.js"></script>
    <!-- slick js -->
    <script src="../../js/slick.min.js"></script>
    <script src="../../js/jquery.counterup.min.js"></script>
    <script src="../../js/waypoints.min.js"></script>
    <script src="../../js/contact.js"></script>
    <script src="../../js/jquery.ajaxchimp.min.js"></script>
    <script src="../../js/jquery.form.js"></script>
    <script src="../../js/jquery.validate.min.js"></script>
    <script src="../../js/mail-script.js"></script>
    <script src="../../js/jquery-ui.min.js"></script>


    <!-- custom js -->
    <script src="../../js/custom.js"></script>
    <script src="../../js/moment.js"></script>
    <script src="../../js/bootstrap.min.js"></script>
    <script src="../../js/bootstrap-slider.min.js"></script>
    <script src="../../js/jquery-ui.min.js"></script>
    <script src="../../js/datepicker-pt-BR.js"></script>

    <script>
        var isChanged = false;
        $(function () {
            $('#ddlyear').focusin(function () {
                if (!isChanged) {
                    // this removes the first item which is your placeholder if it is never changed
                    $(this).find('option:first').remove();
                }
            });
            $('#ddlyear').change(function () {
                // this marks the selection to have changed
                isChanged = true;
            });
            $('#ddlyear').focusout(function () {
                if (!isChanged) {
                    // if the control loses focus and there is no change in selection, return the first item
                    $(this).prepend('<option selected="selected" value="0">Experience</option>');
                }
            });
        });
    </script>

    <script>
        moment().format('DD/MM/YYYY');
        document.getElementById('datepicker').value = moment().format('DD/MM/YYYY');
        $(function () {
            $("#datepicker").datepicker({
                autoclose: true,
                orientation: "right"
            });

        });

        $("#preco").bootstrapSlider({
            min: 25,
            max: 1000,
            value: 25,
            tooltip: 'show',
            tooltip_position: 'top'

        });
    </script>

</asp:Content>

