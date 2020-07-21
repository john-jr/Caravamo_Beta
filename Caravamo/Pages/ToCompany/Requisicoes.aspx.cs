using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Requisicoes : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["id"] == null && Session["empresa"] == null)
        {
            Response.Redirect("../ToVisitor/Index.aspx?er=0");
        }
    }


    protected void Page_Init(object sender, EventArgs e)
    {
        DataSet ds2;
        DataSet cds;

        string card_data = "";
      
        ds2 = CaravanDB.selectCaravan3();
        int id = 0;
        foreach(DataRow das in ds2.Tables[0].Rows){
            id = Convert.ToInt32 (CaravanDB.selectCaravanCountProposta(das["id"].ToString()));
            if(id == 0)
            {
                cds = CaravanDB.selectCaravan2(Convert.ToInt32(das["id"].ToString()));
                foreach (DataRow da in cds.Tables[0].Rows)
                {

                    Literal top = new Literal();
                    Literal bottom = new Literal();
                    Literal middle = new Literal();

                    card_data += "<div class='col-md-4 col-12 mt-3'>";
                    card_data += "<div class='card'>";
                    card_data += "<div class='card-header  text-center pb-1 '>";
                    card_data += "<h3 class='text-center'>" + da["titulo"].ToString() + "</h3>";
                    card_data += "</div>";
                    card_data += "<div class='row'>";
                    card_data += "<div class='col-12 rx-2'>";
                    card_data += "<img src='"+ da["foto"].ToString() + "' class='w-100 border border-light rounded'>";
                    card_data += "</div>";
                    card_data += "<div class='col-md-12  pt-2'>";
                    card_data += "<div class='card-block btn-more fontmedium'>";
                    card_data += "<div class=' text-center'>";
                    card_data += "<div class='mb-2'>";
                    card_data += "<strong>Tipo de Caravana:</strong>";
                    int pri = Convert.ToInt32(da["privacidade"].ToString());
                    string auxiliar = "";
                    if (pri == 0)
                    {
                        auxiliar = "Caravana Pública";
                    }
                    else
                    {
                        auxiliar = "Caravana Privada";
                    }
                    card_data += "<asp:Literal runat='server'>" + auxiliar + "</asp:Literal>";
                    card_data += "</div>";
                    card_data += "<div>";
                    card_data += "<strong>Data de Saída: </strong>";
                    card_data += "</div>";
                    card_data += "<div class='mb-2'>";
                    var dataSaida = Convert.ToDateTime(da["dataHoraSaida"]);
                    card_data += "<asp:Literal runat='server'>" + dataSaida.ToShortDateString() + "</asp:Literal>";
                    card_data += "</div>";
                    card_data += "<div>";
                    card_data += "<strong>Data de Chegada: </strong>";
                    card_data += "</div>";
                    card_data += "<div class='mb-2'>";
                    var dataChegada = Convert.ToDateTime(da["dataHoraChegada"]);
                    card_data += "<asp:Literal runat='server'>" + dataChegada.ToShortDateString() + "</asp:Literal>";
                    card_data += "</div>";
                    card_data += "<div>";
                    card_data += "<strong>Endereço de Saída: </strong>"; ;
                    card_data += "</div>";
                    card_data += "<div class='mb-2'>";
                    auxiliar = da["uf"].ToString();
                    string[] cidade = auxiliar.Split(',');
                    auxiliar = da["cidade"].ToString();
                    string[] estado = auxiliar.Split(',');
                    auxiliar = da["rua"].ToString();
                    string[] rua = auxiliar.Split(',');
                    auxiliar = da["bairro"].ToString();
                    string[] bairro = auxiliar.Split(',');

                    card_data += "<asp:Literal runat='server'>" + cidade[0] + " , " + estado[0] + "<br />" + rua[0] + "<br />" + bairro[0] + "</asp:Literal>";
                    card_data += "</div>";

                    card_data += "<div>";
                    card_data += "<strong>Endereço de Destino: </strong>";
                    card_data += "</div>";
                    card_data += "<div class='mb-2'>";
                    card_data += "<asp:Literal runat='server'>" + cidade[1] + " , " + estado[1] + "<br />" + rua[1] + "<br />" + bairro[1] + "</asp:Literal>";
                    card_data += "</div>";
                    card_data += "</div>";
                    card_data += "<div class='col-12 mb-1 mt-5 mt-auto'>";
                    card_data += "<hr />";
                    card_data += "<div class='row'>";
                    card_data += "<div class='col-md-6 col-12 text-center'>";
                    top.Text = card_data;
                    card_data = "";

                    Button Mais_Info = new Button();
                    Mais_Info.Text = "Mais Informações";
                    Mais_Info.ID = "I" + da["id"].ToString();
                    Mais_Info.CssClass = "genric-btn info w-100";
                    Mais_Info.Click += new System.EventHandler(this.MaisInfo_Click);


                    card_data += "</div>";
                    card_data += "<div class='col-md-6 col-12  text-md-right'>";
                    middle.Text = card_data;
                    card_data = "";


                    Button Proposta = new Button();
                    Proposta.Text = "Fazer Proposta";
                    Proposta.ID = da["titulo"].ToString() + da["id"].ToString();
                    Proposta.CssClass = "genric-btn primary w-100";
                    Proposta.Click += new System.EventHandler(this.IrProposta_Click);


                    card_data += "</div>";
                    card_data += "</div>";
                    card_data += "</div>";
                    card_data += "</div>";
                    card_data += "</div>";
                    card_data += "</div>";
                    card_data += "</div>";
                    card_data += "</div>";
                    bottom.Text = card_data;
                    card_data = "";

                    plh_status.Controls.Add(top);
                    plh_status.Controls.Add(Mais_Info);
                    plh_status.Controls.Add(middle);
                    plh_status.Controls.Add(Proposta);
                    plh_status.Controls.Add(bottom);
                }
            }else if(id != 0)
            {
            //    DataSet ds = CaravanDB.selectCaravanaSemConfirmacao();
            //    foreach (DataRow dr in ds.Tables[0].Rows)
            //    {
            //        cds = CaravanDB.selectCaravan2(Convert.ToInt32(dr["id"].ToString()));
            //        foreach (DataRow da in cds.Tables[0].Rows)
            //        {

            //            Literal top = new Literal();
            //            Literal bottom = new Literal();
            //            Literal middle = new Literal();

            //            card_data += "<div class='col-md-4 col-12 mt-3'>";
            //            card_data += "<div class='card'>";
            //            card_data += "<div class='card-header  text-center pb-1 '>";
            //            card_data += "<h3 class='text-center'>" + da["titulo"].ToString() + "</h3>";
            //            card_data += "</div>";
            //            card_data += "<div class='row'>";
            //            card_data += "<div class='col-12 rx-2'>";
            //            card_data += "<img src='../../img/index_images/noimg.png' class='w-100 border border-light rounded'>";
            //            card_data += "</div>";
            //            card_data += "<div class='col-md-12  pt-2'>";
            //            card_data += "<div class='card-block btn-more fontmedium'>";
            //            card_data += "<div class=' text-center'>";
            //            card_data += "<div class='mb-2'>";
            //            card_data += "<strong>Tipo de Caravana:</strong>";
            //            int pri = Convert.ToInt32(da["privacidade"].ToString());
            //            string auxiliar = "";
            //            if (pri == 0)
            //            {
            //                auxiliar = " Caravana Pública";
            //            }
            //            else
            //            {
            //                auxiliar = " Caravana Privada";
            //            }
            //            card_data += "<asp:Literal runat='server'>" + auxiliar + "</asp:Literal>";
            //            card_data += "</div>";
            //            card_data += "<div>";
            //            card_data += "<strong>Data de Saída: </strong>";
            //            card_data += "</div>";
            //            card_data += "<div class='mb-2'>";
            //            var dataSaida = Convert.ToDateTime(da["dataHoraSaida"]);
            //            card_data += "<asp:Literal runat='server'>" + dataSaida.ToShortDateString() + "</asp:Literal>";
            //            card_data += "</div>";
            //            card_data += "<div>";
            //            card_data += "<strong>Data de Chegada: </strong>";
            //            card_data += "</div>";
            //            card_data += "<div class='mb-2'>";
            //            var dataChegada = Convert.ToDateTime(da["dataHoraChegada"]);
            //            card_data += "<asp:Literal runat='server'>" + dataChegada.ToShortDateString() + "</asp:Literal>";
            //            card_data += "</div>";
            //            card_data += "<div>";
            //            card_data += "<strong>Endereço de Saída: </strong>"; ;
            //            card_data += "</div>";
            //            card_data += "<div class='mb-2'>";
            //            auxiliar = da["uf"].ToString();
            //            string[] cidade = auxiliar.Split(',');
            //            auxiliar = da["cidade"].ToString();
            //            string[] estado = auxiliar.Split(',');
            //            auxiliar = da["rua"].ToString();
            //            string[] rua = auxiliar.Split(',');
            //            auxiliar = da["bairro"].ToString();
            //            string[] bairro = auxiliar.Split(',');

            //            card_data += "<asp:Literal runat='server'>" + cidade[0] + "," + estado[0] + "<br />" + rua[0] + "<br />" + bairro[0] + "</asp:Literal>";
            //            card_data += "</div>";

            //            card_data += "<div>";
            //            card_data += "<strong>Endereço de Destino: </strong>";
            //            card_data += "</div>";
            //            card_data += "<div class='mb-2'>";
            //            card_data += "<asp:Literal runat='server'>" + cidade[1] + "," + estado[1] + "<br />" + rua[1] + "<br />" + bairro[1] + "</asp:Literal>";
            //            card_data += "</div>";
            //            card_data += "</div>";
            //            card_data += "<div class='col-12 mb-1 mt-5 mt-auto'>";
            //            card_data += "<hr />";
            //            card_data += "<div class='row'>";
            //            card_data += "<div class='col-md-6 col-12 text-center'>";
            //            top.Text = card_data;
            //            card_data = "";

            //            Button Mais_Info = new Button();
            //            Mais_Info.Text = "Mais Informações";
            //            Mais_Info.ID = "I" + da["id"].ToString();
            //            Mais_Info.CssClass = "genric-btn info w-100";
            //            Mais_Info.Click += new System.EventHandler(this.MaisInfo_Click);


            //            card_data += "</div>";
            //            card_data += "<div class='col-md-6 col-12  text-md-right'>";
            //            middle.Text = card_data;
            //            card_data = "";


            //            Button Proposta = new Button();
            //            Proposta.Text = "Fazer Proposta";
            //            Proposta.ID = da["titulo"].ToString() + da["id"].ToString();
            //            Proposta.CssClass = "genric-btn primary w-100";
            //            Proposta.Click += new System.EventHandler(this.IrProposta_Click);


            //            card_data += "</div>";
            //            card_data += "</div>";
            //            card_data += "</div>";
            //            card_data += "</div>";
            //            card_data += "</div>";
            //            card_data += "</div>";
            //            card_data += "</div>";
            //            card_data += "</div>";
            //            bottom.Text = card_data;
            //            card_data = "";

            //            plh_status.Controls.Add(top);
            //            plh_status.Controls.Add(Mais_Info);
            //            plh_status.Controls.Add(middle);
            //            plh_status.Controls.Add(Proposta);
            //            plh_status.Controls.Add(bottom);
            //        }
            //    }

           }
        }
        if (!plh_status.HasControls())
        {
            Literal none = new Literal();
            card_data = "";
            card_data += "    <div class='col - 12'>";
            card_data += "  <h5 class='text-center'>Não há requisições de viagem</h5>";
            card_data += "</div>";
            none.Text = card_data;
            plh_status.Controls.Add(none);
        }

       



     
      

      
    }

   void MaisInfo_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.ID;
        string id = Regex.Replace(buttonId, "[^0-9.]", "");
        Session["CaravanID"] = id;
        Session["auxiliar5"] = Request.UrlReferrer.ToString();
        Session["auxiliar3"] = true;

        Response.Redirect("../ToUser/Caravana.aspx");
    }

    void IrProposta_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.ID;
        Session["auxiliar"] = buttonId;
        Response.Redirect("Fazer_prop.aspx");
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}