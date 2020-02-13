using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class detalhe_caravana : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Inscrever_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#modal').modal('show');</script>", false);
    }


    protected void btn_adicionar_Click(object sender, EventArgs e)
    {

    }

    protected void btn_modal2_Click1(object sender, EventArgs e) /*botao concluir no modal de adicionar participantes*/
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#modal2').modal('show');</script>", false);
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#modal').modal('hide');</script>", false);
    }



    protected void btn_fecharModal_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#modal2').modal('hide');</script>", false);
    }
}