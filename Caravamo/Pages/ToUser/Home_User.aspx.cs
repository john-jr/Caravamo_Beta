using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToUser_Home : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        DataSet ds = CaravanDB.selectCaravanCriador22(Convert.ToInt32(Session["id"]));
        string ltl_status = "";
        string auxiliar;
     
        foreach(DataRow dr in ds.Tables[0].Rows)
        {
            Literal top = new Literal();
            Literal bottom = new Literal();
            ltl_status = "<div class='col-lg-3 mb-lg-4 mb-4'>";
            ltl_status += "<div class='card'>";
            ltl_status += "<div class='card-body'>";
                ltl_status += "<div class='card-title h5'>";
               ltl_status += "<asp:Label runat='server'>"+ dr["titulo"].ToString() + "</asp:Label>";
               ltl_status += "<hr />";
                ltl_status += "</div>";
                ltl_status += "<div class='card-text'>";
                 ltl_status += "<p>";
            auxiliar = dr["estado"].ToString();
            string[] uf = auxiliar.Split(',');
            auxiliar = dr["cidade"].ToString();
            string[] cidade = auxiliar.Split(',');
            if (cidade.Count() == 1 && uf.Count() == 1)
            {
                ltl_status += "<asp:Label runat='server'><strong>De:</strong> " + cidade[0] + " - " + uf[0] + "</asp:Label>";
            }
            else if (uf.Count() == 1)
            {
                ltl_status += "<asp:Label runat='server'><strong>De:</strong> " + cidade[1] + " - " + uf[0] + "</asp:Label>";
            }
            else if (cidade.Count() == 1)
            {
                ltl_status += "<asp:Label runat='server'><strong>De:</strong> " + cidade[0] + " - " + uf[1] + "</asp:Label>";
            }
            else
            {
                ltl_status += "<asp:Label runat='server'><strong>De:</strong> " + cidade[1] + " - " + uf[1] + "</asp:Label>";
            }

            ltl_status += "</p>";
                  ltl_status += "</div>";
                  ltl_status += "<div class='card-text'>";
            ltl_status += "<p>";
            ltl_status += "<asp:Label runat='server'><strong>Para:</strong> " + cidade[0] + " - " + uf[0] + "</asp:Label>";
            ltl_status += "</p>";
                   ltl_status += "</div>";
                 ltl_status += "<div class='card-text'>";
                  ltl_status += "<br />";
                  ltl_status += "<p>";
            DateTime data = Convert.ToDateTime(dr["HoraDataSaida"].ToString());
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            int dia = data.Day;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Month));
            ltl_status += "<asp:Label runat='server'><strong>Saída:</strong> " + dia + " de " + mes + "</asp:Label>";
            ltl_status += "</p>";
                ltl_status += "</div>";
                top.Text = ltl_status;
            ltl_status = "";

            Button VerMais = new Button();
            VerMais.Text = "Ver mais";
            VerMais.ID = "I" + dr["id"].ToString();
            VerMais.CssClass = "genric-btn primary btn-more float-lg-right";
            VerMais.Click += new System.EventHandler(this.VerMais_Click);
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            bottom.Text = ltl_status;

            phl_suasCar.Controls.Add(top);
            phl_suasCar.Controls.Add(VerMais);
            phl_suasCar.Controls.Add(bottom);
        }
        if (!phl_suasCar.HasControls())
        {
            Literal none = new Literal();
            ltl_status = "";
            ltl_status += "    <div class='col - 12 mt-2'>";
            ltl_status += "  <h5 class='text-center'>Você não criou nenhuma caravana recentemente</h5>";
            ltl_status += "</div>";
            none.Text = ltl_status;
           phl_suasCar.Controls.Add(none);
        }

        ds = CaravanDB.selectCaravanOtherUsers(Convert.ToInt32(Session["id"]));
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            Literal top = new Literal();
            Literal bottom = new Literal();
            ltl_status = "<div class='col-lg-3 mb-lg-4 mb-4'>";
            ltl_status += "<div class='card'>";
            ltl_status += "<div class='card-body'>";
            ltl_status += "<div class='card-title h5'>";
            ltl_status += "<asp:Label runat='server'>" + dr["titulo"].ToString() + "</asp:Label>";
            ltl_status += "<hr />";
            ltl_status += "</div>";
            ltl_status += "<div class='card-text'>";
            ltl_status += "<p>";
            auxiliar = dr["estado"].ToString();
            string[] uf = auxiliar.Split(',');
            auxiliar = dr["cidade"].ToString();
            string[] cidade = auxiliar.Split(',');
            if (cidade.Count() == 1 && uf.Count() == 1)
            {
                ltl_status += "<asp:Label runat='server'><strong>De:</strong> " + cidade[0] + " - " + uf[0] + "</asp:Label>";
            }
            else if (uf.Count() == 1)
            {
                ltl_status += "<asp:Label runat='server'><strong>De:</strong> " + cidade[1] + " - " + uf[0] + "</asp:Label>";
            }
            else if (cidade.Count() == 1)
            {
                ltl_status += "<asp:Label runat='server'><strong>De:</strong> " + cidade[0] + " - " + uf[1] + "</asp:Label>";
            }
            else
            {
                ltl_status += "<asp:Label runat='server'><strong>De:</strong> " + cidade[1] + " - " + uf[1] + "</asp:Label>";
            }

            ltl_status += "</p>";
            ltl_status += "</div>";
            ltl_status += "<div class='card-text'>";
            ltl_status += "<p>";
            ltl_status += "<asp:Label runat='server'><strong>Para:</strong> " + cidade[0] + " - " + uf[0] + "</asp:Label>";
            ltl_status += "</p>";
            ltl_status += "</div>";
            ltl_status += "<div class='card-text'>";
            ltl_status += "<br />";
            ltl_status += "<p>";
            DateTime data = Convert.ToDateTime(dr["HoraDataSaida"].ToString());
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            int dia = data.Day;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Month));
            ltl_status += "<asp:Label runat='server'><strong>Saída:</strong> " + dia + " de " + mes + "</asp:Label>";
            ltl_status += "</p>";
            ltl_status += "</div>";
            top.Text = ltl_status;
            ltl_status = "";

            Button VerMaisOutro = new Button();
            VerMaisOutro.Text = "Ver mais";
            VerMaisOutro.ID = "O" + dr["id"].ToString();
            VerMaisOutro.CssClass = "genric-btn primary btn-more float-lg-right";
            VerMaisOutro.Click += new System.EventHandler(this.VerMaisOutro_Click);
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            bottom.Text = ltl_status;

            phl_outrasCar.Controls.Add(top);
            phl_outrasCar.Controls.Add(VerMaisOutro);
            phl_outrasCar.Controls.Add(bottom);
        }
        if (!phl_outrasCar.HasControls())
        {
            Literal none = new Literal();
            ltl_status = "";
            ltl_status += "    <div class='col - 12 mt-2'>";
            ltl_status += "  <h5 class='text-center'>Não houve novas caravanas criadas recentemente</h5>";
            ltl_status += "</div>";
            none.Text = ltl_status;
            phl_outrasCar.Controls.Add(none);
        }



    }

    private void VerMaisOutro_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.ID;
        Session["CaravanID"] = Regex.Replace(buttonId, "[^0-9.]", "");
        Response.Redirect("../ToUser/Caravana.aspx");
    }

    private void VerMais_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.ID;
        Session["CaravanID"] = Regex.Replace(buttonId, "[^0-9.]", "");
        Response.Redirect("../ToUser/Caravana_Criador.aspx");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null && Session["cliente"] == null)
        {
            Response.Redirect("../ToVisitor/Index.aspx?er=0");
        }
    }



    protected void btn_pesquisa_Click(object sender, EventArgs e)
    {
        Session["auxiliar"] = txt_pesquisa.Text;  
        Response.Redirect("../ToUser/PesquisarCaravanas.aspx");
    }
}