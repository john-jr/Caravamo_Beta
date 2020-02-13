using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Fazer_prop2 : System.Web.UI.Page
{

    protected void Page_Init(object sender, EventArgs e)
    {
        DataSet ds = DriverDB.selectDriver(Convert.ToInt32(Session["id"]));
        string ltl_status = "";
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            Literal top = new Literal();
            Literal bottom = new Literal();

            ltl_status += "  <div class='container col-xl-3 col-lg-4 col-md-6 col-sm-12 mb-4'>";
            top.Text = ltl_status;
            ltl_status = "";
            LinkButton motorista = new LinkButton(); ;
            string auxN = dr["mot_nome"].ToString();
            var names = auxN.Split(' ');
            motorista.Text = "<div class='container'><div class='card bg-light border-dark auxiliar'><div class='card-body'><img src = '../../img/Motorista.png' /> </div > <div class='card-footer text-center'> <p><h4>" + names[0] + "<h4> </p> </div>  </div> </div>";
           motorista.Click += new System.EventHandler(this.motoristaEsse_Click);
            motorista.ID = "V" + dr["mot_id"].ToString();
            ltl_status += "</div>";
            bottom.Text = ltl_status;
            ltl_status = "";

            phl_mot.Controls.Add(top);
           phl_mot.Controls.Add(motorista);
            phl_mot.Controls.Add(bottom);

        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        string aux = Session["auxiliar"].ToString();
        aux = Regex.Replace(aux, @"[\d-]", string.Empty); ;
        ltl_auxiliar.Text = "<h2>Proposta para: " + aux + "</h2>";
    }


    void motoristaEsse_Click(object sender, EventArgs e)
    {
        LinkButton button = (LinkButton)sender;
        string buttonId = button.ID;


        foreach (Control control in phl_mot.Controls)
        {

            if (control is LinkButton)
            {
                if (((LinkButton)control).ID == buttonId)
                {
                    ((LinkButton)control).CssClass = "selected";
                }
                else
                {
                    ((LinkButton)control).CssClass = "";
                }


            }
        }
        buttonId = Regex.Replace(buttonId, "[^0-9.]", "");
        lbl_id.Text = buttonId;
    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        Proposta p = (Proposta)Session["cadastro"];
        p.Mot_id = Convert.ToInt32 (lbl_id.Text);
        Response.Redirect("Fazer_prop3.aspx");
    }

    protected void btnRetornar1_Click(object sender, EventArgs e)
    {

    }
}