using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Visualizar_proposta : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session["id"] == null && Session["cliente"] == null)
        {
            Response.Redirect("../ToVisitor/Index.aspx?er=0");
        }


        if (Session["CaravanID"].Equals(false))
        {

        }
        else
        {
           

            int CaravanID = Convert.ToInt32(Session["CaravanID"]);
            var aux = Session["auxiliar"];
            var aux2 = Session["auxiliar2"];

            lbl_titulo.Text = Session["auxiliar"].ToString();
            lbl_DataHoraSaida.Text = Session["auxiliar2"].ToString();

            DataSet ds = CaravanDB.selectPropostas(CaravanID);
            string cards = "";
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                Literal top = new Literal();
                Literal middleOne = new Literal();
                Literal middleTwo = new Literal();
                Literal bottom = new Literal();
                cards = "<div class=' bg-light card border border-dark'>";
                cards += "<div class='card-body'>";
                cards += "<div class='row'>";
                cards += "<div class='container col-lg-7 col-md-7  col-11  mt-2 '>";
                cards += "<div class='row'>";
                cards += "<div class='col-lg-4 col-md-5'><p> Empresa </p></div>";
                cards += "<div class='col-lg-6 col-md-7'><p>";
                cards += "<asp:Label runat='server'>"+dr["NomeEmpresa"].ToString()+"</asp:Label>";
                cards += "</p>";
                cards += "</div>";
                cards += "<hr/>";
                cards += "</div>";
                cards += "<hr/>";
                cards += "<div class='card-text mt-3'>";
                cards += "<div class='row'>";
                cards += "<div class='col-lg-4 col-md-5'><p>Enviada em: </p>";
                cards += "</div>";
                cards += "<div class='col-lg-6 col-md-7'>";
                var dataEnvio = Convert.ToDateTime(dr["DataEnvio"]);
                cards += "<p><asp:Label runat='server'>"+dataEnvio.ToShortDateString()+ "</asp:Label></p>";
                cards += "</div>";
                cards += "</div>";
                cards += "</div>";
                cards += "<hr/>";
                cards += "<div class='card-text mt-3'>";
                cards += "<div class='row'>";
                cards += "<div class='col-lg-4 col-md-5'>";
                cards += "<p>";
                cards += "Veículo:";
                cards += "</p>";
                cards += "</div>";
                cards += "<div class='col-lg-6 col-md-7'>";
                var tipo = dr["TipoVeiculo"].ToString();
                if (tipo == "M")
                {
                    tipo = "Micro - Ônibus";
                }
                else if (tipo == "O")
                {
                    tipo = "Ônibus";
                }
                else if (tipo == "V")
                {
                    tipo = "Van";
                }

                cards += "<p><asp:Label runat='server'>"+ tipo +" "+ dr["Modelo"].ToString() + "</asp:Label> </p>";
                cards += "<p><asp:Label runat='server'>"+dr["qntAssentos"].ToString()+ " Assentos</asp:Label></p>";
                    
                cards += "</div>";
                cards += "</div>";
                cards += "</div>";
                cards += "<hr/>";
                cards += "<div class='row'>";
                cards += "<div class='col-lg-4 col-md-5'>";
                cards += "<p>Motorista: </p>";
                cards += "</div>";
                cards += "<div class='col-lg-6 col-md-7'>";
                cards += "<p>";
                cards += "<asp:Label runat='server'>"+dr["nomeMotorista"].ToString() +"</asp:Label>";
                cards += "</p>";
                cards += "</div>";
                cards += "<hr/>";
                cards += "</div>";
                cards += "<hr/>";
                cards += "<div class='card-text mt-3'>";
                cards += "<div class='row'>";
                cards += "<div class='col-lg-4 col-md-5'>";
                cards += "<p>Valor: </p>";
                cards += "</div>";
                cards += "<div class='col-lg-6 col-md-7'>";
                cards += "<p>";
                cards += "<asp:Label runat='server'> R$"+dr["valor"].ToString() +"</asp:Label>";
                cards += "</p>";
                cards += "</div>";
                cards += "</div>";
                cards += "</div>";
                cards += "</div>";
                cards += "<div class='linha-vertical d-none d-md-block d-md-none'></div>";
                cards += "<hr />";
                cards += "<div class='col-lg-4 col-md-4 mt-4'>";
                cards += "<div class='container'>";
                top.Text = cards;
                cards = "";

                Button btn_aceitar = new Button();
                btn_aceitar.Text = "Aceitar";
                btn_aceitar.ID = "A" + dr["idProposta"].ToString();
                btn_aceitar.CssClass = "genric-btn info btn-block";
                btn_aceitar.Click += new System.EventHandler(this.btnAceitar_Click);


                cards += "</div>";
                cards += "<br/>";
                cards += "<div class='container'>";

                middleOne.Text = cards;
                cards = "";

                Button btn_contraPropsota = new Button();
                btn_contraPropsota.Text = "Contraproposta";
                btn_contraPropsota.ID = "C" + dr["idProposta"].ToString();
                btn_contraPropsota.CssClass = "genric-btn primary btn-block ";
                btn_contraPropsota.Visible = false;
                btn_contraPropsota.Click += new System.EventHandler(this.btnContra_Click);

                cards += "</div>";
                cards += "<br/>";
                cards += "<div class='container'>";
                middleTwo.Text = cards;
                cards = "";

                Button btn_recusar = new Button();
                btn_recusar.Text = "Recusar";
                btn_recusar.ID = "R" + dr["idProposta"].ToString();
                btn_recusar.CssClass = "genric-btn danger btn-block";
                btn_recusar.Click += new System.EventHandler(this.btnRecusar_Click);

               
                cards += "</div>";
                cards += "</div>";
                cards += "</div>";
                cards += "</div>";
                cards += "</div>";
                cards += "<br/>";
                bottom.Text = cards;
                cards = "";


                phl_propostas.Controls.Add(top);
                phl_propostas.Controls.Add(btn_aceitar);
                phl_propostas.Controls.Add(middleOne);
                phl_propostas.Controls.Add(btn_contraPropsota);
                phl_propostas.Controls.Add(middleTwo);
                phl_propostas.Controls.Add(btn_recusar);
                phl_propostas.Controls.Add(bottom);

            }

        }
    }


        protected void Page_Load(object sender, EventArgs e)
    {
       
    }


    protected void btnContra_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#Modalcontra').modal('show');</script>", false);


    }

    protected void btnAceitar_Click(object sender, EventArgs e)
    {


        Button button = (Button)sender;
        string buttonId = button.ID;
        buttonId = Regex.Replace(buttonId, "[^0-9.]", "");

        if (CompanyDB.UpdateProposta("Aceito", Convert.ToInt32(buttonId)) == 0)
        {
            DataSet ds = UserDB.select_Interessados(Convert.ToInt32(Session["CaravanID"]));
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                VisitorBD.SendEmailAtualizacaoCaravana2(dr["email"].ToString(), dr["tituloCaravana"].ToString(), dr["nomeCliente"].ToString(), dr["convite"].ToString());
            }
            ltl_status.Text = "<script type='text/javascript'> swal('Sucesso!', 'Você aceitou a proposta', 'success')";
            ltl_status.Text += ".then((value) => {window.location.replace('Caravana_Criador.aspx')}); </script> ";

        }
        else
        {

        }
    }

    protected void btnRecusar_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.ID;
        buttonId = Regex.Replace(buttonId, "[^0-9.]", "");

        if (CompanyDB.UpdateProposta("Negado", Convert.ToInt32(buttonId)) == 0)
        {
            ltl_status.Text = "";
            ltl_status.Text = "<script type=text/javascript> toastr.error('Você recusou uma proposta') </script>";
        }
        else
        {

        }
      

    }
}