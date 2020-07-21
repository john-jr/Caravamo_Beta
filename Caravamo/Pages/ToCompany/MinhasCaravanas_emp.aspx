<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="MinhasCaravanas_emp.aspx.cs" Inherits="Pages_ToUser_MinhasCaravanas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>
        .tabs {
            max-width: 100%;
            margin: 0 auto;
            padding: 0 20px;
        }

        #tab-button {
            display: table;
            table-layout: fixed;
            width: 100%;
            margin: 0;
            padding: 0;
            list-style: none;
        }

            #tab-button li {
                display: table-cell;
                width: 20%;
            }

                #tab-button li a {
                    display: block;
                    padding: .5em;
                    background: #eee;
                    border: 1px solid #ddd;
                    text-align: center;
                    color: #000;
                    text-decoration: none;
                }

                #tab-button li:not(:first-child) a {
                    border-left: none;
                }

                #tab-button li a:hover,
                #tab-button .is-active a {
                    border-bottom-color: transparent;
                    background: #fff;
                }



        @media screen and (min-width: 768px) {
            .tab-contents {
                padding: .5em 2em 1em;
                border: 1px solid #ddd;
            }
        }



        .tab-button-outer {
            display: none;
        }

        .tab-contents {
            margin-top: 20px;
        }

        @media screen and (min-width: 768px) {
            .tab-button-outer {
                position: relative;
                z-index: 2;
                display: block;
            }

            .tab-select-outer {
                display: none;
            }

            .tab-contents {
                position: relative;
                top: -1px;
                margin-top: 0;
            }
        }

        .card {
            margin-left: 2em;
            margin-right: 2em;
        }


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


    <div class="row" style="margin: 0">
        <div class="col-lg-12 text-center mt-5 mb-1">
            <div>
                <h3>Minhas Caravanas</h3>
                <hr style="width: 80%" />
            </div>
        </div>
    </div>


    <div class="row" style="margin: 0">


        <div class="container">
            <div class="tabs">
                <div class="tab-button-outer">
                    <ul id="tab-button">
                        <li><a href="#tab01">
                            <h5>Caravanas feitas</h5>
                        </a></li>
                        <li><a href="#tab02">
                            <h5>Caravanas à fazer</h5>
                        </a></li>
                    </ul>
                </div>
                <div class="tab-select-outer">
                    <select id="tab-select">
                        <option value="#tab01">Caravanas feitas</option>
                        <option value="#tab02">Caravanas a fazer</option>
                    </select>
                </div>

                <div id="tab01" class="tab-contents">


                    <asp:PlaceHolder ID="plh_status" runat="server"></asp:PlaceHolder>


                </div>
                <div id="tab02" class="tab-contents">
                 
                    <asp:PlaceHolder ID="plh_status2" runat="server"></asp:PlaceHolder>

                </div>
            </div>
        </div>
    </div>



    <script src="../../js/jquery-3.3.1.slim.min.js"></script>
    <script src="../../js/bootstrap.min.js"></script>

    <script>
        $(function () {
            var $tabButtonItem = $('#tab-button li'),
                $tabSelect = $('#tab-select'),
                $tabContents = $('.tab-contents'),
                activeClass = 'is-active';

            $tabButtonItem.first().addClass(activeClass);
            $tabContents.not(':first').hide();

            $tabButtonItem.find('a').on('click', function (e) {
                var target = $(this).attr('href');

                $tabButtonItem.removeClass(activeClass);
                $(this).parent().addClass(activeClass);
                $tabSelect.val(target);
                $tabContents.hide();
                $(target).show();
                e.preventDefault();
            });

            $tabSelect.on('change', function () {
                var target = $(this).val(),
                    targetSelectNum = $(this).prop('selectedIndex');

                $tabButtonItem.removeClass(activeClass);
                $tabButtonItem.eq(targetSelectNum).addClass(activeClass);
                $tabContents.hide();
                $(target).show();
            });
        });
    </script>


</asp:Content>

