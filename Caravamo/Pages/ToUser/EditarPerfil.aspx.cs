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
        DataSet ds = UserDB.select_Client(Convert.ToInt32(Session["id"]));
    }

    protected void btn_editarEmail_Click(object sender, EventArgs e)
    {
        if(txt_email.ReadOnly == false)
        {
            if ()
            {
                txt_email.ReadOnly = true;
                btn_editarEmail.Text = "";
                btn_editarEmail.Text = "<i class='fa fa-pencil-alt'></i>";
            }
            else
            {

            }
        }
        else
        {
            btn_editarEmail.Text = "<i class='fa  fa-check'></i>";
            txt_email.ReadOnly = false;
        }
    }

    protected void btn_editarNome_Click(object sender, EventArgs e)
    {
        if(txt_nomePessoa.ReadOnly == false)
        {
            if(){
                txt_nomePessoa.ReadOnly = true;
                btn_editarNome.Text = "";
                btn_editarNome.Text = "<i class='fa fa-pencil-alt'></i>";
            }
            else {
                
            }

        }
        else
        {
            btn_editarNome.Text = "<i class='fa  fa-check'></i>";
            txt_nomePessoa.ReadOnly = false;
        }
    }

    protected void btn_alterarSenha_Click(object sender, EventArgs e)
    {
        
    }
}