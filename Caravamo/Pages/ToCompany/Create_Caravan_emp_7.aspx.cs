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
      
    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        Proposta p = (Proposta)Session["cadastro2"];
      
        p.Pro_valor = Convert.ToInt32 (price.Text);
        Response.Redirect("Create_Caravan_emp_8.aspx");
    }

    protected void btnCancelar1_Click(object sender, EventArgs e)
    {

    }
}