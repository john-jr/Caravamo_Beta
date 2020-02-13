using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Visitor : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_logar_Click(object sender, EventArgs e)
    {
        Usuario usu = new Usuario();

        usu.Usu_email = userEmail.Text;
        usu.Usu_senha = UserDB.Criptografia(userSenha.Text.ToString());
        int usu_id = UserDB.selectUser(usu);
       
        if (usu_id != 0)
        {
          
            if (CompanyDB.selectEmpresa(Convert.ToString(usu_id)) == 1)
            {
                Session["cliente"] = false;
                Session["id"] = CompanyDB.selectEmpresa2(Convert.ToString(usu_id));
                Session["empresa"] = true;
                Response.Redirect("../ToCompany/Home_emp.aspx");
            }
            else if (UserDB.selectUser3(Convert.ToString(usu_id)) == 1)
            {
                Session["cliente"] = true;
                Session["id"] = UserDB.selectUser4(Convert.ToString(usu_id));
                Session["empresa"] = false;
                Response.Redirect("../ToUser/Home_User.aspx");
            }
            else
            {
            
               Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#loginModal').modal('show');</script>", false);
               
            }
        }
        else
        {
           
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#loginModal').modal('show');</script>", false);
        
        }
    }

}

