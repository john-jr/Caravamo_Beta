using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToCompany_Edit_Profile : System.Web.UI.Page
{
   static StringBuilder sb = new StringBuilder();

    protected void Page_Load(object sender, EventArgs e)
    {
   
            DataSet ds = CompanyDB.selectEmpresa4(Convert.ToInt32(Session["id"]));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lbl_nomeFantasia.Text = dr["emp_nome"].ToString();
                lbl_razaoSocial.Text = dr["emp_razaosocial"].ToString();

                txt_RazaoSocial.Text = dr["emp_razaosocial"].ToString();
                txt_nomeFantasia.Text = dr["emp_nome"].ToString();

                txt_email.Text = dr["usu_email"].ToString();

           
        }

        
    }

    protected void btn_editarNomeFantasia_Click(object sender, EventArgs e)
    {
        if(txt_nomeFantasia.ReadOnly == false)
        {
            if (CompanyDB.UpdateNomeFantasia(txt_nomeFantasia.Text, Convert.ToInt32(Session["id"])) == 0)
            {
                ltl_status.Text = "<script type=text/javascript> toastr.success('Dados atualizados com sucesso') </script>";
                txt_nomeFantasia.ReadOnly = true;
                btn_editarNomeFantasia.Text = "";
                btn_editarNomeFantasia.Text =  "<i class='fa fa-pencil-alt'></i>";
            }
            else
            {
                ltl_status.Text = "<script type=text/javascript> toastr.error('Algo deu errado, tente novamente mais tarde') </script>";
            }
          
        }
        else
        {
            btn_editarNomeFantasia.Text = "<i class='fa  fa-check'></i>";
            txt_nomeFantasia.ReadOnly = false;
        }
    }

    protected void btn_editarRazaoSocial_Click(object sender, EventArgs e)
    {
        if(txt_RazaoSocial.ReadOnly == false)
        {
            if(CompanyDB.UpdateRazaoSocial(txt_RazaoSocial.Text,Convert.ToInt32(Session["id"]) ) == 0)
            {
                ltl_status.Text = "<script type=text/javascript> toastr.success('Dados atualizados com sucesso') </script>";
                txt_RazaoSocial.ReadOnly = true;
                btn_editarRazaoSocial.Text = "";
                btn_editarRazaoSocial.Text = "<i class='fa fa-pencil-alt'></i>";
            }
            else
            {
                ltl_status.Text = "<script type=text/javascript> toastr.error('Algo deu errado, tente novamente mais tarde') </script>";
            }
        }
        else
        {
            btn_editarRazaoSocial.Text = "<i class='fa  fa-check'></i>";
            txt_RazaoSocial.ReadOnly = false;
        }
    }

    protected void btn_EditarEmail_Click(object sender, EventArgs e)
    {
        if(txt_email.ReadOnly == false)
        {
            if(CompanyDB.UpdateEmail(txt_email.Text,Convert.ToInt32(Session["id"])) == 0)
            {
                ltl_status.Text = "<script type=text/javascript> toastr.success('Dados atualizados com sucesso') </script>";
                txt_email.ReadOnly = true;
                btn_EditarEmail.Text = "";
                btn_EditarEmail.Text = "<i class='fa fa-pencil-alt'></i>";
            }
            else
            {
                ltl_status.Text = "<script type=text/javascript> toastr.error('Algo deu errado, tente novamente mais tarde') </script>";
            }

        }
        else
        {
            btn_EditarEmail.Text = "<i class='fa  fa-check'></i>";
            txt_email.ReadOnly = false;
        }
    }

    protected void btn_alterarSenha_Click(object sender, EventArgs e)
    {
        if(UserDB.Criptografia(txt_oldSenha.Text) == UserDB.select_CompanyUserPassword(Convert.ToInt32(Session["id"])))
        {
            if(txt_newSenha.Text == txt_newSenhaC.Text)
            {
                if(CompanyDB.UpdateSenha(UserDB.Criptografia(txt_newSenha.Text),Convert.ToInt32(Session["id"])) == 0)
                {
                    ltl_status.Text = "<script type=text/javascript> toastr.success('Senha alterada com sucesso') </script>";
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