using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Convite : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session["id"] == null && Session["cliente"] == null)
        {
            Response.Redirect("../ToVisitor/Index.aspx?er=0");
        }

        DataSet ds = UserDB.ConvitesCaravana(Convert.ToInt32(Session["CaravanID"]));
        string status = "";
       

        foreach(DataRow dr in ds.Tables[0].Rows)
        {
            Literal top = new Literal();
            Literal mid = new Literal();
            Literal bottom = new Literal();

            status = "<div class='card bg-light card border border-dark'>";
            status += "<div class='card-body'>";
            status += "<div class='container'>";
            status += "<div class='row'>";
            status += "<div class='col-lg-6 col-12'>";
            status += "<div class='row'>";
            status += "<div class='col-12'>";
            status += "<p>";
            status += "<label runat='server'>"+dr["nome"].ToString()+"</label>";
            status += "</p>";
            status += "</div>";
            status += "<div class='col-12'>";
            status += "<p>";
            string aux = dr["genero"].ToString();
            if (aux.Equals("M"))
            {
                aux = "Masculino";
            }
            else if (aux.Equals("F"))
            {
                aux = "Feminino";
            }
            else
            {
                aux = "Outro";
            }
            var data = DateTime.Today;
            var nasc = Convert.ToDateTime(dr["dataNasc"]);
            var idade = data.Year - nasc.Year;
            if (nasc.Date > data.AddYears(-idade)) { idade--; }

            status += "<label runat='server'>" + idade +" anos - "+aux+"</label>";
            status += "</p>";
            status += "</div>";
            status += "</div>";
            status += "</div>";
            status += "<div class='col-lg-6 col-12'>";
            status += "<div class='row mt-2'>";
            status += "<div class=' col-lg-6 col-6'>";
            top.Text = status;
            status = "";
            Button btn_aceitar = new Button();
            btn_aceitar.Text = "Aceitar";
            btn_aceitar.ID = "A" + dr["idCli"].ToString();
            btn_aceitar.CssClass = "genric-btn info btn-block ";
            btn_aceitar.Click += new System.EventHandler(this.aceitar_click);
            status += "</div>";
            status += "<div class='col-lg-6 col-6'>";
            mid.Text = status;
            status = "";
            Button btn_recusar = new Button();
            btn_recusar.Text = "Recusar";
            btn_recusar.ID = "D" + dr["idCli"].ToString();
            btn_recusar.CssClass = "genric-btn danger btn-block";
            btn_recusar.Click += new System.EventHandler(this.recusar_click);
            status += "</div>";
            status += "</div>";
            status += "</div>";
            status += "</div>";
            status += "</div>";
            status += "</div>";
            status += "</div>";
            status += "<br />";
            bottom.Text = status;
            plh_status.Controls.Add(top);
            plh_status.Controls.Add(btn_aceitar);
            plh_status.Controls.Add(mid);
            plh_status.Controls.Add(btn_recusar);
            plh_status.Controls.Add(bottom);
        }
        if (status == "")
        {
            Literal none = new Literal();
            status = "";
            status += "    <div class='col - 12'>";
            status += "  <h5 class='text-center'>Não há novos convidados</h5>";
            status += "</div>";
            none.Text = status;
            plh_status.Controls.Add(none);
        }

        }

    private void aceitar_click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.ID;
        buttonId = Regex.Replace(buttonId, "[^0-9.]", "");
      
        if(UserDB.UpdateConviteCaravana(Convert.ToInt32(Session["CaravanID"]), Convert.ToInt32(buttonId), "Inscrito") == 0)
        {
            DataSet ds = UserDB.select_Interessados(Convert.ToInt32(Session["CaravanID"]));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                VisitorBD.SendEmailAtualizacaoCaravana(dr["email"].ToString(), dr["tituloCaravana"].ToString(), dr["nomeCliente"].ToString(), dr["convite"].ToString());
            }

            javascript.Text = "<script type=text/javascript> toastr.success('Você permitiu esta inscrição na sua caravana') </script>";
            Response.Redirect(Request.RawUrl);
        }
        else
        {
            javascript.Text = "<script type=text/javascript> toastr.error('Algo deu errado, tente novamente mais tarde') </script>";
        }
    }

    private void recusar_click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.ID;
        buttonId = Regex.Replace(buttonId, "[^0-9.]", "");
        if (UserDB.UpdateConviteCaravana(Convert.ToInt32(Session["CaravanID"]), Convert.ToInt32(buttonId), "Cancelado") == 0)
        {

            javascript.Text = "<script type=text/javascript> toastr.error('Você recusou esta inscrição na sua caravana') </script>";
            Response.Redirect(Request.RawUrl);

        }
        else
        {
            javascript.Text = "<script type=text/javascript> toastr.error('Algo deu errado, tente novamente mais tarde') </script>";
        }

      
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        int CaravanID = Convert.ToInt32(Session["CaravanID"]);
        var aux = Session["auxiliar"];
        var aux2 = Session["auxiliar2"];

        lbl_titulo.Text = Session["auxiliar"].ToString();
        lbl_DataHoraSaida.Text = Session["auxiliar2"].ToString();
        DataSet ds1 = CaravanDB.selectEmpresaResp(CaravanID);
        if (!ds1.Tables[0].Rows[0].IsNull("IdEmpresaResponsavel"))
        {
            propostas.Visible = false;
        }
        ltl_linkCaravana.Text = "http://localhost:50783/Pages/ToUser/Caravana.aspx?iud="+CaravanDB.selectInviteIdCaravan(CaravanID);
    }
}