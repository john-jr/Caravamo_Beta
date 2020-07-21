using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToVisitor_Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["cliente"] = false;
        Session["id"] = 0;
        Session["empresa"] = false;
        Session["cadastro"] = false;
        Session["auxiliar"] = false;
        Session["auxiliar2"] = false;
        Session["auxiliar3"] = false;
        Session["auxiliar4"] = false;
        Session["auxiliar5"] = false;
        Session["CaravanID"] = false;

    }


    protected void btn_pesquisa_index_Click(object sender, EventArgs e)
    {
        Session["auxiliar"] = txt_pesquisa.Text;
        Response.Redirect("../ToUser/PesquisarCaravanas.aspx");

    }
}