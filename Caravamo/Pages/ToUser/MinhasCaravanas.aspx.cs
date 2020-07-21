using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToUser_MinhasCaravanas : System.Web.UI.Page
{

    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session["id"] == null && Session["cliente"] == null)
        {
            Response.Redirect("../ToVisitor/Index.aspx?er=0");
        }

        DataSet ds = CaravanDB.selectCaravanCriador2(Convert.ToInt32(Session["id"]));
        string ltl_status = "";

        foreach(DataRow dr in ds.Tables[0].Rows)
        {
            Literal top = new Literal();
            Literal bottom = new Literal();
            ltl_status = "<div class='card mt-30'>";
            ltl_status += "<div class='card-header text-center  pt-2 pb-1'>";
            ltl_status += "<h4>";
            ltl_status += dr["titulo"].ToString();
            ltl_status += "</h4>";
            ltl_status += "</div>";
            ltl_status += "<div class='row'>";
            ltl_status += "<div class='col-md-4'>";
            ltl_status += "<img src='"+ dr["foto"].ToString() + "' Class='pt-md-4 pl-md-5'>";
            ltl_status += "</div>";
            ltl_status += "<div class='col-md-8 px-3 pt-3'>";
            ltl_status += "<div class='card-block px-3'>";
            ltl_status += "<div class='dates'>";
            ltl_status += "<div class='start'>";
            ltl_status += "<strong>Data de saída:</strong>";
            var dataSaida = Convert.ToDateTime(dr["HoraDataSaida"]);
            ltl_status += "<asp:Literal runat='server'>" + dataSaida.ToShortDateString() + "</asp:Literal>";
            ltl_status += "<span></span>";
            ltl_status += "</div>";
            ltl_status += "<div class='ends'>";
            ltl_status += "<strong>Data de Chegada:</strong>";
            var dataChegada = Convert.ToDateTime(dr["HoraDataChegada"]);
            ltl_status += "<asp:Literal runat='server'>" + dataChegada.ToShortDateString() + "</asp:Literal>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "<div class='dates'>";
            ltl_status += "<div class='start'>";
            ltl_status += "<strong>Endereço de Origem:</strong>";
            string auxiliar = dr["estado"].ToString();
            string[] estado = auxiliar.Split(',');
            auxiliar = dr["cidade"].ToString();
            string[] cidade = auxiliar.Split(',');
            auxiliar = dr["bairro"].ToString();
            string[] bairro = auxiliar.Split(',');
            auxiliar = dr["rua"].ToString();
            string[] rua = auxiliar.Split(',');

            ltl_status += "<asp:Literal runat='server'>"+estado[0]+" - "+cidade[0]+"<br>" + bairro[0] + " - " +rua[0] + "</asp:Literal>";
         
            ltl_status += "<span></span>";
            ltl_status += "</div>";
            ltl_status += "<div class='ends'>";
            ltl_status += "<strong>Endereço de Destino:</strong>";
            ltl_status += "<asp:Literal runat='server'>" + estado[1] + " - " + cidade[1] + "<br>" + bairro[1] + " - " + rua[1] + " </asp:Literal>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "<div class='col-lg-12 mb-1'>";
            ltl_status += "<div style='font-size: 1.3em'>";
            top.Text = ltl_status;
            ltl_status = "";

            Button Mais_Info = new Button();
            Mais_Info.Text = "Mais Informações";
            Mais_Info.ID = "I" + dr["id"].ToString();
            Mais_Info.CssClass = "genric-btn primary mt-1 mb-2 offset-lg-7 col-lg-4 col-12";
            Mais_Info.Click += new System.EventHandler(this.MaisInfo_Click);

            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            bottom.Text = ltl_status;
            ltl_status = "";

            plh_status.Controls.Add(top);
            plh_status.Controls.Add(Mais_Info);
            plh_status.Controls.Add(bottom);
        }
        if (!plh_status.HasControls())
        {
            Literal none = new Literal();
            ltl_status = "";
            ltl_status += "    <div class='col - 12 mt-2'>";
            ltl_status += "  <h5 class='text-center'>Você não criou nenhuma caravana</h5>";
           ltl_status += "</div>";
            none.Text = ltl_status;
            plh_status.Controls.Add(none);
        }

         ds = CaravanDB.selectCaravanInscrito(Convert.ToInt32(Session["id"]));
        string aux = ds.Tables[0].Rows[0]["id"].ToString();

        if (!aux.Equals(""))
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Literal top = new Literal();
                Literal bottom = new Literal();
                ltl_status = "<div class='card mt-30'>";
                ltl_status += "<div class='card-header text-center  pt-2 pb-1'>";
                ltl_status += "<h4>";
                ltl_status += dr["titulo"].ToString();
                ltl_status += "</h4>";
                ltl_status += "</div>";
                ltl_status += "<div class='row'>";
                ltl_status += "<div class='col-md-4'>";
                ltl_status += "<img src='"+dr["foto"].ToString()+"' Class='pt-md-4 pl-md-5'>";
                ltl_status += "</div>";
                ltl_status += "<div class='col-md-8 px-3 pt-3'>";
                ltl_status += "<div class='card-block px-3'>";
                ltl_status += "<div class='dates'>";
                ltl_status += "<div class='start'>";
                ltl_status += "<strong>Data de saída:</strong>";
                var dataSaida = Convert.ToDateTime(dr["HoraDataSaida"]);
                ltl_status += "<asp:Literal runat='server'>" + dataSaida.ToShortDateString() + "</asp:Literal>";
                ltl_status += "<span></span>";
                ltl_status += "</div>";
                ltl_status += "<div class='ends'>";
                ltl_status += "<strong>Data de Chegada:</strong>";
                var dataChegada = Convert.ToDateTime(dr["HoraDataChegada"]);
                ltl_status += "<asp:Literal runat='server'>" + dataChegada.ToShortDateString() + "</asp:Literal>";
                ltl_status += "</div>";
                ltl_status += "</div>";
                ltl_status += "<div class='dates'>";
                ltl_status += "<div class='start'>";
                ltl_status += "<strong>Endereço de Origem:</strong>";
                string auxiliar = dr["estado"].ToString();
                string[] estado = auxiliar.Split(',');
                auxiliar = dr["cidade"].ToString();
                string[] cidade = auxiliar.Split(',');
                auxiliar = dr["bairro"].ToString();
                string[] bairro = auxiliar.Split(',');
                auxiliar = dr["rua"].ToString();
                string[] rua = auxiliar.Split(',');

                ltl_status += "<asp:Literal runat='server'>" + estado[0] + " - " + cidade[0] + "<br>" + bairro[0] + " - " + rua[0] + "</asp:Literal>";

                ltl_status += "<span></span>";
                ltl_status += "</div>";
                ltl_status += "<div class='ends'>";
                ltl_status += "<strong>Endereço de Destino:</strong>";
                ltl_status += "<asp:Literal runat='server'>" + estado[1] + " - " + cidade[1] + "<br>" + bairro[1] + " - " + rua[1] + " </asp:Literal>";
                ltl_status += "</div>";
                ltl_status += "</div>";
                ltl_status += "<div class='col-lg-12 mb-1'>";
                ltl_status += "<div style='font-size: 1.3em'>";
                top.Text = ltl_status;
                ltl_status = "";

                Button Mais_Info = new Button();
                Mais_Info.Text = "Mais Informações";
                Mais_Info.ID = "I" + dr["id"].ToString();
                Mais_Info.CssClass = "genric-btn primary mt-1 mb-2 offset-lg-7 col-lg-4 col-12";
                Mais_Info.Click += new System.EventHandler(this.MaisInfo2_Click);

                ltl_status += "</div>";
                ltl_status += "</div>";
                ltl_status += "</div>";
                ltl_status += "</div>";
                ltl_status += "</div>";
                ltl_status += "</div>";
                bottom.Text = ltl_status;
                ltl_status = "";

                plh_status2.Controls.Add(top);
                plh_status2.Controls.Add(Mais_Info);
                plh_status2.Controls.Add(bottom);
            }
        }
        if (!plh_status2.HasControls())
        {
            Literal none = new Literal();
            ltl_status = "";
            ltl_status += "    <div class='col - 12 mt-2'>";
            ltl_status += "  <h5 class='text-center'>Você não se inscreveu em nenhuma caravana</h5>";
            ltl_status += "</div>";
            none.Text = ltl_status;
            plh_status2.Controls.Add(none);
        }





    }

    private void MaisInfo_Click(object sender, EventArgs e)
    {
        try
        {
            Button button = (Button)sender;
            string buttonId = button.ID;
            buttonId = Regex.Replace(buttonId, "[^0-9.]", "");
           Session["CaravanID"] = buttonId;
            Response.Redirect("Caravana_Criador.aspx");
        }
        catch
        {

        }
    }

    private void MaisInfo2_Click(object sender, EventArgs e)
    {
        try
        {
            Button button = (Button)sender;
            string buttonId = button.ID;
            buttonId = Regex.Replace(buttonId, "[^0-9.]", "");
            Session["CaravanID"] = buttonId;
            Response.Redirect("Caravana.aspx");
        }
        catch
        {

        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        //corno0.DataSource = CaravanDB.selectCaravanCriador2(Convert.ToInt32(Session["id"]));
        //corno0.DataBind();
    }

    protected void corno0_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        //if(e.CommandName == "amad")
        //{
        //  Response.Write  ("<script> alert('Copied the text: ') </script>");
        //}
    }
}