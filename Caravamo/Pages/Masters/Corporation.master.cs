using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Masters_Corporation : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_verRequisições_Click(object sender, EventArgs e)
    {
        Response.Redirect("Requisicoes.aspx");
    }

    protected void btn_verProspostasRealizadas_Click(object sender, EventArgs e)
    {
        Response.Redirect("Propostas_Realizadas.aspx");
    }

    protected void btn_CriarCaravanaEmpresa_Click(object sender, EventArgs e)
    {
        Response.Redirect("../ToCompany/Create_Caravan_emp_1.aspx");
    }
}
