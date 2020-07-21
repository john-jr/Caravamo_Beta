<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Masters/User.master" AutoEventWireup="true" CodeFile="Home_User.aspx.cs" Inherits="Pages_ToUser_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>
        .link-color {
            color: black;
        }

        .btn-more {
            font-size: medium;
        }

        .row {
            margin-left: 0;
            margin-right: 0;
        }
    </style>

    <section>
        <div class="container-fluid">
            <div class="row mt-4">
                <h3 class="col-lg-12 text-center">Pesquise por uma caravana...</h3>
                <div class="col-lg-12">
                    <div class="col-lg-8 input-group offset-lg-2">


                        <asp:LinkButton runat="server" BorderColor="#f8f9fa" ID="btn_pesquisa" OnClick="btn_pesquisa_Click" BorderStyle="none" BorderWidth="0px" Style="background-color: white; padding: 8px; padding-top: 10px !important;">
                            <i class="fa fa-search" style="color: black"></i>
                        </asp:LinkButton>
                        <asp:TextBox type="search" runat="server" onkeydown="javascript:enterEvent(event);" ID="txt_pesquisa" CssClass="form-control border-2 bg-light mt-1"></asp:TextBox>
                    </div>
                </div>
                <br />
                <br />
                <div class="col-lg-12 text-center mt-lg-1 mb-lg-3">
                    <p style="font-size: 18px"><a href="Create_Caravan_1.aspx" class="text-center link-color">...ou crie a sua!</a></p>
                </div>
            </div>
        </div>
    </section>
    <br />
    <section>
        <div class="row">
            <div class="col-lg-11 offset-lg-1 mb-lg-3">
                <h3>Minhas últimas caravanas criadas</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-1"></div>
        <asp:PlaceHolder runat="server" ID="phl_suasCar"></asp:PlaceHolder>
            



        </div>

    </section>
    <br />
    <section>
        <div class="row">
            <div class="col-lg-11 offset-lg-1 mt-lg-2 mb-lg-3">
                <h3>Outras caravanas criadas recentemente</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-1"></div>
            
           <asp:PlaceHolder runat="server" ID="phl_outrasCar"></asp:PlaceHolder>
            

        </div>
    </section>
    <br />


    <script>
        function enterEvent(e) {
            if (e.keyCode == 13) {
                $("input[id=btn_pesquisa]").click();
            }
        }
    </script>

</asp:Content>


