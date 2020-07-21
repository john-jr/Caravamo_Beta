using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home_emp : System.Web.UI.Page
{
    static Boolean firstload = true;
    static String name;

    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["id"] == null && Session["empresa"] == null)
        {
            Response.Redirect("../ToVisitor/Index.aspx?er=0");
        }


    }

    protected void Page_Init(object sender, EventArgs e)
    {

        DataSet props = new DataSet();
        props = CompanyDB.SelectPropostasFeitas2(Convert.ToInt32(Session["id"]));
        string ltl_status = "";
        string auxiliar = "";
        foreach (DataRow dr in props.Tables[0].Rows)
        {
            Literal card = new Literal();
            ltl_status = "<div class=' col-lg-4 col-md-6 col-sm-6 col-12  mb-lg-4 mb-4'>";
            ltl_status += "<div class='card'>";
            ltl_status += "<div class='card-body'>";
            ltl_status += "<div class='card-title h5 text-center'>";
            ltl_status += "<asp:Label runat='server'>" + dr["titulo"].ToString() + "</asp:Label>";
            ltl_status += "<hr />";
            ltl_status += "</div>";
            auxiliar = dr["uf"].ToString();
            string[] uf = auxiliar.Split(',');
            auxiliar = dr["cidade"].ToString();
            string[] cidade = auxiliar.Split(',');

            ltl_status += "<div class='card-text'>";
            ltl_status += "<p>";
            ltl_status += "<asp:Label runat='server'><strong>Para:</strong> " + cidade[0] + " - " + uf[0] + "</asp:Label>";
            ltl_status += "</p>";
            ltl_status += "</div>";
            ltl_status += "<div class='card-text'>";
            ltl_status += "<p>";
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
            ltl_status += "<div class='card-text mt-2'>";
            ltl_status += "<p>";
            DateTime data = Convert.ToDateTime(dr["DataHoraSaida"].ToString());
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            int dia = data.Day;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Month));
            ltl_status += "<asp:Label runat='server'><strong>Saída:</strong> " + dia + " de " + mes + "</asp:Label>";
            ltl_status += "</p>";
            ltl_status += "</div>";

            ltl_status += "<div class='card-text mt-3 text-center'>";
            ltl_status += "<h4>";
            ltl_status += "<asp:Label runat='server'>Status</asp:Label>";
            ltl_status += "</h4>";
            ltl_status += "</div>";
            ltl_status += "<div class='container'>";
            auxiliar = dr["StatusProposta"].ToString();
            if (auxiliar.Equals("Aguardando"))
            {
                ltl_status += "<label class='genric-btn primary btn-more form-control'>Aguardando</label>";

            }
            else if (auxiliar.Equals("Aceito"))
            {
                ltl_status += "<label class='genric-btn btn-more form-control' style='background-color:lawngreen!important'>Aceito</label>";
            }
            else if (auxiliar.Equals("Negado"))
            {
                ltl_status += "<label class='genric-btn danger w-100'>Recusado</label>";
            }
            else if (auxiliar.Equals("Contraproposta"))
            {

            }
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            card.Text = ltl_status;
            phl_ultimasprops.Controls.Add(card);
        }
        if (ltl_status == "")
        {
            Literal none = new Literal();
            ltl_status = "";
            ltl_status += "    <div class='col - 12'>";
            ltl_status += "  <h5 class='text-center'>Sem propostas realizadas</h5>";
            ltl_status += "</div>";
            none.Text = ltl_status;
            phl_ultimasprops.Controls.Add(none);
        }

        ltl_status = "";
        props = CaravanDB.selectCaravanCriadorbyEmpresa3(Convert.ToInt32(Session["id"]));
        foreach (DataRow dr in props.Tables[0].Rows)
        {
            Literal top = new Literal();
            Literal bottom = new Literal();

            ltl_status = "<div class='col-lg-4 col-sm-6 mb-lg-2 mb-4'>";
            ltl_status += "<div class='card'>";
            ltl_status += "<div class='card-body'>";
            ltl_status += "<div class='card-title text-center h5'>";
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
            ltl_status += "<p>";
            ltl_status += "<br />";
            DateTime data = Convert.ToDateTime(dr["dataHoraSaida"].ToString());
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            int dia = data.Day;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Month));
            ltl_status += "<asp:Label runat='server'><strong>Saída:</strong> " + dia + " de " + mes + "</asp:Label>";
            ltl_status += "</p>";
            ltl_status += "</div>";
            ltl_status += "<br />";
            ltl_status += "<div class='container'>";
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
            bottom.Text = ltl_status;

            phl_proxViagens.Controls.Add(top);
            phl_proxViagens.Controls.Add(Mais_Info);
            phl_proxViagens.Controls.Add(bottom);
        }
        if (ltl_status == "")
        {
            Literal none = new Literal();
            ltl_status = "";
            ltl_status += "    <div class='col - 12'>";
            ltl_status += "  <h5 class='text-center'>Sem Viagens próximas</h5>";
            ltl_status += "</div>";
            none.Text = ltl_status;
            phl_proxViagens.Controls.Add(none);
        }
        ltl_status = "";

        DataSet aux = new DataSet();
        props = CaravanDB.selectCaravan22();
        int id = 0;
        foreach (DataRow das in props.Tables[0].Rows)
        {
            id = Convert.ToInt32(CaravanDB.selectCaravanCountProposta(das["id"].ToString()));
            if (id == 0)
            {
                aux = CaravanDB.selectCaravan2(Convert.ToInt32(das["id"].ToString()));
                foreach (DataRow da in aux.Tables[0].Rows)
                {
                    Literal top = new Literal();
                    Literal bottom = new Literal();

                    ltl_status = "<div class='col-lg-4 col-sm-6 lg-2 mb-4'>";
                    ltl_status += "<div class='card'>";
                    ltl_status += "<div class='card-body'>";
                    ltl_status += "<div class='card-title h5'>";
                    ltl_status += "<asp:Label runat='server'>" + da["titulo"].ToString() + "</asp:Label>";
                    ltl_status += "<hr />";
                    ltl_status += "</div>";
                    ltl_status += "<div class='card-text'>";
                    ltl_status += "<p>";
                    auxiliar = da["uf"].ToString();
                    string[] uf = auxiliar.Split(',');
                    auxiliar = da["cidade"].ToString();
                    string[] cidade = auxiliar.Split(',');
                    ltl_status += "<asp:Label runat='server'><strong>Para:</strong> " + cidade[0] + " - " + uf[0] + "</asp:Label>";
                    ltl_status += "</p>";
                    ltl_status += "</div>";
                    ltl_status += "<div class='card-text'>";
                    ltl_status += "<p>";
                    DateTime data = Convert.ToDateTime(da["dataHoraSaida"].ToString());
                    CultureInfo culture = new CultureInfo("pt-BR");
                    DateTimeFormatInfo dtfi = culture.DateTimeFormat;
                    int dia = data.Day;
                    string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(data.Month));
                    ltl_status += "<asp:Label runat='server'><strong>Saída:</strong> " + dia + " de " + mes + "</asp:Label>";
                    ltl_status += "</p>";
                    ltl_status += "</div>";
                    ltl_status += "<br />";
                    ltl_status += "<div class='container'>";
                    top.Text = ltl_status;
                    ltl_status = "";

                    Button Mais_Info2 = new Button();
                    Mais_Info2.Text = "Mais Informações";
                    Mais_Info2.ID = "R" + da["id"].ToString();
                    Mais_Info2.CssClass = "genric-btn primary btn-more form-control";
                    Mais_Info2.Click += new System.EventHandler(this.MaisInfo2_Click);


                    ltl_status += "</div>";
                    ltl_status += "</div>";
                    ltl_status += "</div>";
                    ltl_status += "</div>";
                    bottom.Text = ltl_status;
                    

                    phl_requisicoes.Controls.Add(top);
                    phl_requisicoes.Controls.Add(Mais_Info2);
                    phl_requisicoes.Controls.Add(bottom);

                }
                if (ltl_status == "")
                {
                    Literal none = new Literal();
                    ltl_status = "";
                    ltl_status += "    <div class='col - 12'>";
                    ltl_status += "  <h5 class='text-center'>Sem novas requisições de viagem</h5>";
                    ltl_status += "</div>";
                    none.Text = ltl_status;
                    phl_requisicoes.Controls.Add(none);
                }
            }
        }
    }

    private void MaisInfo2_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.ID;
        Session["CaravanID"] = Regex.Replace(buttonId, "[^0-9.]", "");
        Response.Redirect("../ToUser/Caravana.aspx");
    }

    private void MaisInfo_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    protected void Page_Load(object sender, EventArgs e)
    {


        firstload = false;
        int aux = (int)Session["id"];
        name = (CompanyDB.selectEmpresa3(aux));


        lbl_nomeEmp.Text = name;
    }
}