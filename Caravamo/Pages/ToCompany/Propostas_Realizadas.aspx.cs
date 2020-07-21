using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToCompany_Propostas_Realizadas : System.Web.UI.Page
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
        DataSet ds = CompanyDB.SelectPropostasFeitas(Convert.ToInt32(Session["id"]));
        string ltl_status = "";
        string auxiliar = "";
        foreach(DataRow dr in ds.Tables[0].Rows)
        {
            Literal top = new Literal();
            Literal bottom = new Literal();

            ltl_status = "<div class=' col-lg-4 col-md-6 col-sm-6 col-12  mb-lg-4 mb-4'>";
            ltl_status += "<div class='card'>";
            ltl_status += "<div class='card-body'>";
            ltl_status += "<div class='card-title h5 text-center'>";
            ltl_status += "<asp:Label runat='server'>"+dr["titulo"].ToString()+"</asp:Label>";
            ltl_status += "<hr />";
            ltl_status += "</div>";
            ltl_status += "<div class='card-text'>";
            ltl_status += "<p> Estado de Saída - Destino:  </p>";

            ltl_status += "<p>";
            auxiliar = dr["uf"].ToString();
            string[] uf = auxiliar.Split(',');


            if (uf.Count() == 1) {
                ltl_status += "<asp:Label runat='server'>" + uf[0] +" → "+ uf[0] +"</asp:Label>";
            }
            else
            {
                ltl_status += "<asp:Label runat='server'>" + uf[0] + " → " + uf[1] + "</asp:Label>";
            }
            ltl_status += "</p>";
            ltl_status += "</div>";
            ltl_status += "  <div class='card-text mt-3'>";
            ltl_status += "<p> Cidade de Saída - Destino:  </p>";
            ltl_status += "<p>";
            auxiliar = dr["cidade"].ToString();
            string[] cidade = auxiliar.Split(',');
            if (cidade.Count() == 1)
            {
                ltl_status += "<asp:Label runat='server'>" + cidade[0] + " → " + cidade[0] + "</asp:Label>";
            }
            else
            {
                ltl_status += "<asp:Label runat='server'>" + cidade[0] + " → " + cidade[1] + "</asp:Label>";
            }
            ltl_status += "</p>";
            ltl_status += "</div>";
            ltl_status += "<div class='card-text mt-1 text-center'>";
            ltl_status += "<p> Datas de Saída - Retorno </p>";
            ltl_status += "<p>";
            DateTime data = Convert.ToDateTime(dr["dataHoraSaida"].ToString());
            DateTime data2 = Convert.ToDateTime(dr["dataHoraRetorno"].ToString());
            ltl_status += " <asp:Label runat='server' >" + data.ToString("dd/MM/yyyy") + " - "+ data2.ToString("dd/MM/yyyy") + "</asp:Label>";
            ltl_status += "</p>";
            ltl_status += "</div>";
           
            ltl_status += "<div class='container'>";
            top.Text = ltl_status;
            ltl_status = "";
            Button btn_MaisInfo = new Button();
            btn_MaisInfo.Text = "Mais Informações";
            btn_MaisInfo.ID = "E" + dr["id"].ToString();
            btn_MaisInfo.CssClass = "genric-btn info w-100";
            btn_MaisInfo.Click += new System.EventHandler(this.card_Click);


            ltl_status += "<div class='row mt-2'>";
            ltl_status += "<div class='col-4 mt-2 text-right'>";
            ltl_status += "<h4>Status: </h4>";
            ltl_status += "</div>";
            ltl_status += "<div class='col-8'>";
            auxiliar = dr["StatusProposta"].ToString();
            if (auxiliar.Equals("Aguardando"))
            {
                ltl_status += "<label class='genric-btn primary w-100'>Aguardando</label>";

}
            else if (auxiliar.Equals("Aceito"))
            {
                ltl_status += "<label class='genric-btn primary w-100' style='background-color:lawngreen!important'>Aceito</label>";
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
            ltl_status += "</div>";
            ltl_status += "</div>";
            bottom.Text = ltl_status;
            plh_propostas.Controls.Add(top);
            plh_propostas.Controls.Add(btn_MaisInfo);
            plh_propostas.Controls.Add(bottom);
        }
        if (!plh_propostas.HasControls())
        {
            Literal none = new Literal();
            ltl_status = "";
            ltl_status += "    <div class='col - 12'>";
            ltl_status += "  <h5 class='text-center'>Você ainda não propôs uma oferta de serviço</h5>";
            ltl_status += "</div>";
            none.Text = ltl_status;
            plh_propostas.Controls.Add(none);
        }


    }



        protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void a_Click(object sender, EventArgs e)
    {

    }

    protected void card_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.ID;
        buttonId = Regex.Replace(buttonId, "[^0-9.]", "");
        DataSet ds = CompanyDB.SelectThisProposta(Convert.ToInt32(buttonId));
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            Session["CaravanID"] = dr["car_id"].ToString();
            lblValor.Text = dr["valor"].ToString();
            lbl_Placa.Text = dr["Placa"].ToString().ToUpper();
            lbl_Marca.Text = dr["Marca"].ToString();
            lbl_caravana.Text = dr["titulo"].ToString();
            lbl_nome.Text = dr["NomeMotorista"].ToString();
            var data = DateTime.Today;
            var nasc = Convert.ToDateTime(dr["DataNascimento"]);
            var idade = data.Year - nasc.Year;
            lbl_idade.Text = idade + " Anos";
            lbl_Ano.Text = dr["ano"].ToString();
        }
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
       
    }

    protected void Unnamed_Click(object sender, EventArgs e)
    {
        Session["auxiliar3"] = true;
        Session["auxiliar5"] = Request.UrlReferrer.ToString();
       

        Response.Redirect("../ToUser/Caravana.aspx");
    }
}