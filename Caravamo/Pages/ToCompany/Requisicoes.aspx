<%@ Page Title="" Language="C#" MasterPageFile="../../Pages/Masters/Corporation.master" AutoEventWireup="true" CodeFile="Requisicoes.aspx.cs" Inherits="Requisicoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
       <script src="../../js/bootstrap.min.js"></script>
     <script src="../../js/jquery-1.12.1.min.js"></script>
     <script src="../../js/toastr.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>
        .fontmedium {
            font-size: medium;
        }
    </style>
    <div class="row" style="margin: 0">

        <div class="col-md-12 text-center mt-5">

            <h2>Lista de Requisições</h2>
        </div>
    </div>


  
    <div class="row" style="margin: 0">
        <asp:PlaceHolder ID="plh_status" runat="server"></asp:PlaceHolder>
    </div>


  
</asp:Content>

