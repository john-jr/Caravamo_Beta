using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToUser_PesquisarCaravanas : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["cliente"].Equals(false))
        {
            MasterPageFile = "~/Pages/Masters/Visitor.master";
        }
      
       

    }


    protected void Page_Init(object sender, EventArgs e)
    {
        phl_caravans.Controls.Clear();
        string Pesquisa = Session["auxiliar"].ToString();
        txt_Pesquisa.Text = Pesquisa;
        DataSet ds;
        if (Session["auxiliar2"].ToString().Equals("Recent"))
        {
             ds = CaravanDB.selectCaravanSearch(Pesquisa, Convert.ToInt32(Session["id"]));
        }
        else
        {
            ds = CaravanDB.selectCaravanSearch2(Pesquisa, Convert.ToInt32(Session["id"]));

        }

        string status = "";
        int count = 0;

        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            count++;
            Literal top = new Literal();
            Literal bottom = new Literal();
            status = "<div class='container py-3'>";
            status += "<div class='card'>";
            status += "<div class='row '>";     
            status += "<div class='col-md-4'>";  
            status += "<img src='" + dr["foto"].ToString() + "' class='w-100 h-100'>";
            status += "</div>";
            status += "<div class='col-md-8 px-3'>";
            status += "<div class='card-block px-3'>";
            status += "<h4 class='text-center mt-2'>";
            status += "<asp:Label runat='server' CssClass='card-title text-center' Style='padding-top: 5px'>" + dr["titulo"].ToString() + "</asp:Label></h4>";
            status += "<div class='dates'>";
            status += "<div class='start'>";
            status += "<strong>Data de saída:</strong>";
            DateTime data = Convert.ToDateTime(dr["DataHoraSaida"].ToString());
            status += "<asp:Literal runat='server'>" + data.ToString("dd/MM/yyyy") + "</asp:Literal>";
            status += "</div>";
            status += "<div class='ends'>";
            status += "<strong>Data de Chegada:</strong>";
            data = Convert.ToDateTime(dr["DataHoraChegada"].ToString());
            status += "<asp:Literal runat='server'>" + data.ToString("dd/MM/yyyy") + "</asp:Literal>";
            status += "</div>";
            status += "</div>";
            status += "<div class='dates'>";
            status += "<div class='start'>";
            string auxiliar = dr["cidade"].ToString();
            string[] cidades = auxiliar.Split(',');
            auxiliar = dr["estado"].ToString();
            string[] estados = auxiliar.Split(',');
            status += "<strong>Endereço de Origem:</strong>";
            status += "<asp:Literal runat='server'>" + cidades[0] + ", " + estados[0] + "</asp:Literal>";
            status += "<span></span>";
            status += "</div>";
            status += "<div class='ends'>";
            status += "<strong>Endereço de Destino:</strong>";

            if (cidades.Count() == 1 && estados.Count() == 1)
            {
                status += "<asp:Literal runat='server'>" + cidades[0] + ", " + estados[0] + "</asp:Literal>";
            }
            else if (cidades.Count() > 1 && estados.Count() == 1)
            {
                status += "<asp:Literal runat='server'>" + cidades[1] + ", " + estados[0] + "</asp:Literal>";
            }
            else if (cidades.Count() == 1 && estados.Count() > 1)
            {
                status += "<asp:Literal runat='server'>" + cidades[0] + ", " + estados[1] + "</asp:Literal>";
            }
            else
            {
                status += "<asp:Literal runat='server'>" + cidades[1] + ", " + estados[1] + "</asp:Literal>";
            }

            status += "</div>";
            status += "</div>";
            status += "<div class='col-lg-12 mb-3'>";
            status += "<div style='font-size: 1.3em'>";
            top.Text = status;
            status = "";

            Button btn_MaisInfo = new Button();
            btn_MaisInfo.Text = "Mais Informações";
            btn_MaisInfo.ID = "E" + dr["id"].ToString();
            btn_MaisInfo.CssClass = "genric-btn primary mt-2 mb-2 offset-lg-7 col-lg-4 col-12";
            btn_MaisInfo.Click += new System.EventHandler(this.card_Click);

            status += "</div>";
            status += "</div>";
            status += "</div>";
            status += "</div>";
            status += "</div>";
            status += "</div>";
            status += "</div>";
           
            bottom.Text = status;

            phl_caravans.Controls.Add(top);
            phl_caravans.Controls.Add(btn_MaisInfo);
            phl_caravans.Controls.Add(bottom);

        }
        if (count == 0)
        {
            ltl_resultados.Text = "Nenhum Resultado Encontrado";
        }
        else if (count == 1)
        {
            ltl_resultados.Text = count + " Resultado Encontrado";
        }
        else
        {
            ltl_resultados.Text = count + " Resultados Encontrados";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void card_Click(object sender, EventArgs e)
    {
        if (Session["cliente"].Equals(false))
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#loginModal').modal('show');</script>", false);
        }
        else
        {
            Button button = (Button)sender;
            string buttonId = button.ID;
            buttonId = Regex.Replace(buttonId, "[^0-9.]", "");
            Session["CaravanID"] = buttonId;
            Response.Redirect("Caravana.aspx");
        }
       
    }

    protected void btn_pesquisa_Click(object sender, EventArgs e)
    {
        Session["auxiliar"] = txt_Pesquisa.Text;
        Page_Init(this, EventArgs.Empty);
    }

    protected void btn_filtrar_Click(object sender, EventArgs e)
    {
        Session["auxiliar2"] = DropDownList4.SelectedItem.Value;
        Page_Init(this, EventArgs.Empty);
    }
}