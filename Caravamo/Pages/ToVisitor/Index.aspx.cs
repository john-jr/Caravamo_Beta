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
        Session["id"] = false;
        Session["empresa"] = false;
        Session["cadastro"] = false;
        Session["auxiliar"] = false;
        Session["auxiliar2"] = false;
            
    }


    protected void btn_pesquisa_index_Click(object sender, EventArgs e)
    {
       

    }
}