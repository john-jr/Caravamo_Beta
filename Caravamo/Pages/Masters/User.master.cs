using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Masters_User : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_criarCaravana_Click(object sender, EventArgs e)
    {
        Response.Redirect("Create_Caravan_1.aspx");
    }

  
}
