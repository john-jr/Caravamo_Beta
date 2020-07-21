using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Fazer_prop3 : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["id"] == null && Session["empresa"] == null)
        {
            Response.Redirect("../ToVisitor/Index.aspx?er=0");
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
       string aux = Session["auxiliar"].ToString();
        aux = Regex.Replace(aux, @"[\d-]", string.Empty); ;
      ltl_auxiliar.Text = "<h2>Proposta para: " + aux + "</h2>";
    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        Proposta p = (Proposta)Session["cadastro"];
      
        p.Pro_valor = Convert.ToInt32 (price.Text);
        Response.Redirect("Fazer_prop4.aspx");
    }

    protected void btnCancelar1_Click(object sender, EventArgs e)
    {

    }
}