﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToCompany_Propostas_Realizadas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void a_Click(object sender, EventArgs e)
    {

    }

    protected void card_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#myModal').modal('show');</script>", false);
       
    }
}