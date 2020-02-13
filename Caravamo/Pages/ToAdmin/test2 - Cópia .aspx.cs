using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToAdmin_test2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
       // Page.ClientScript.RegisterStartupScript(this.GetType(),"toastr_message", "toastr.error('There was an error', 'Error')", true);
    }

    protected void btn_Click(object sender, EventArgs e)

    {
        ltlTeste.Text = "<script type='text/javascript'> toastr.error('Erro 2: Não foi possível inserir empresa') </script>";
        //Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>jquery</script>", false);

        //Page.ClientScript.RegisterStartupScript(this.GetType(), "toastr_message", "toastr.error('Please Enter Name', 'Error')", true);
    }

    protected void functionName(object sender, EventArgs e)
    {
        Response.Write("Hello World!!!");
    }

}
