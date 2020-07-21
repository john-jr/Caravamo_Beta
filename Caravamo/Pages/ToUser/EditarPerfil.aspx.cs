using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToUser_EditarPerfil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id"] == null && Session["cliente"] == null)
        {
            Response.Redirect("../ToVisitor/Index.aspx?er=0");
        }

        System.DateTime.Now.ToString("dddd");
        DataSet ds = UserDB.select_Client(Convert.ToInt32(Session["id"]));
        foreach(DataRow dr in ds.Tables[0].Rows){

            if (txt_nomePessoa.Text.Equals(dr["cli_nome"].ToString()) || !IsPostBack)
            {
                lbl_userName.Text = dr["cli_nome"].ToString();
                txt_nomePessoa.Text = dr["cli_nome"].ToString();
            }
            if (txt_email.Text.Equals(dr["cli_email"].ToString()) || !IsPostBack)
            {
                txt_email.Text = dr["cli_email"].ToString();
            }

          
        }
    }

    protected void btn_editarEmail_Click(object sender, EventArgs e)
    {
        if(txt_email.ReadOnly == false)
        {

            if (UserDB.UpdateEmail(txt_email.Text, Convert.ToInt32(Session["id"])) == 0)
            {
                ltl_status.Text = "<script type=text/javascript> toastr.success('Dados atualizados com sucesso') </script>";
                txt_email.ReadOnly = true;
                btn_editarEmail.Text = "<i class='fa fa-pencil-alt'></i>";
                Page_Load(this, EventArgs.Empty);
            }
            else
            {
                ltl_status.Text = "<script type=text/javascript> toastr.error('Algo deu errado, tente novamente mais tarde') </script>";
            }
       
        }
        else
        {
            btn_editarEmail.Text = "<i class='fa  fa-check'></i>";
            txt_email.ReadOnly = false;
            ltl_status.Text = "";
        }
    }

    protected void btn_editarNome_Click(object sender, EventArgs e)
    {
        if(txt_nomePessoa.ReadOnly == false)
        {
            if (UserDB.UpdateNome(txt_nomePessoa.Text, Convert.ToInt32(Session["id"])) == 0)
            {
                ltl_status.Text = "<script type=text/javascript> toastr.success('Dados atualizados com sucesso') </script>";
                txt_nomePessoa.ReadOnly = true;
                btn_editarNome.Text = "";
                btn_editarNome.Text = "<i class='fa fa-pencil-alt'></i>";
                Page_Load(this, EventArgs.Empty);
            }
            else
            {
                ltl_status.Text = "<script type=text/javascript> toastr.error('Algo deu errado, tente novamente mais tarde') </script>";
            }
        }
        else
        {
            btn_editarNome.Text = "<i class='fa  fa-check'></i>";
            txt_nomePessoa.ReadOnly = false;
            ltl_status.Text = "";
        }
    }

    protected void btn_alterarSenha_Click(object sender, EventArgs e)
    {
        if (UserDB.Criptografia(txt_oldSenha.Text) == UserDB.select_ClientUserPassword(Convert.ToInt32(Session["id"])))
        {
            if (txt_newSenha.Text == txt_newSenhaA.Text)
            {
                if(UserDB.UpdateSenhaCli(UserDB.Criptografia(txt_newSenha.Text), Convert.ToInt32(Session["id"])) == 0)
                {
                    ltl_status.Text = "<script type=text/javascript> toastr.success('Senha alterada com sucesso') </script>";
                    VisitorBD.SendEmailSenhaAtualizada(txt_email.Text);
                }
                else
                {
                    ltl_status.Text = "<script type=text/javascript> toastr.error('Algo deu errado, tente novamente mais tarde') </script>";
                }
            }
            else
            {
                ltl_status.Text = "<script type=text/javascript> toastr.error('As senhas digitadas não são iguais!') </script>";
            }
        }
        else
        {
            ltl_status.Text = "<script type=text/javascript> toastr.error('Senha atual inválida') </script>";
        }
    }
}