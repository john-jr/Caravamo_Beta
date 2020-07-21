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
        string id = HttpContext.Current.Request.Url.AbsoluteUri;
        id = id.Substring(id.IndexOf("=") + 1);
        if (id.Equals("0"))
        {
            ltl_statusM.Text = "<script type=text/javascript> toastr.error('Acesso Negado') </script>";
        }
        else if (!id.Equals(HttpContext.Current.Request.Url.AbsoluteUri))
        {
            if (VisitorBD.UpdateCheckEmail(id) == true)
            {
                ltl_statusM.Text = "<script type=text/javascript> toastr.success('Ok! Você confirmou sua conta') </script>";
            }
            else
            {
                ltl_statusM.Text = "<script type=text/javascript> toastr.error('Algo deu errado,tente novamente mais tarde') </script>";
            }
        }
    }



    protected void btn_logar_Click(object sender, EventArgs e)
    {
        Usuario usu = new Usuario();

        usu.Usu_email = userEmail.Text;
        usu.Usu_senha = UserDB.Criptografia(userSenha.Text.ToString());
        int usu_id = UserDB.selectUser(usu);
       



        if (usu_id != 0)
        {
            if (UserDB.selectHashConf(usu_id).ToString().Equals("Confirmado"))
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
                    if (Session["CaravanID"] == null || Session["CaravanID"].Equals(false))
                    {
                        Response.Redirect("../ToUser/Home_User.aspx");
                    }
                    else
                    {
                        int CaravanID = Convert.ToInt32(Session["CaravanID"]);
                        Response.Redirect("http://localhost:50783/Pages/ToUser/Caravana.aspx?iud=" + CaravanDB.selectInviteIdCaravan(CaravanID));
                    }
                }
                else
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#loginModal').modal('show');</script>", false);
                    ltl_statusM.Text = "<script type=text/javascript> toastr.error('Ocorreu algum erro, tente novamente mais tarde') </script>";
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#loginModal').modal('show');</script>", false);
                ltl_statusM.Text = "<script type=text/javascript> toastr.error('Por Favor, confirme o e-mail para acessar a conta') </script>";

               


            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#loginModal').modal('show');</script>", false);
            ltl_statusM.Text = "<script type=text/javascript> toastr.error('E-mail e/ou Senha incorretos') </script>";
         
        }

    }
}

