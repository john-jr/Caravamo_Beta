using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tipo_cad : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = HttpContext.Current.Request.Url.AbsoluteUri;
        id = id.Substring(id.IndexOf("=") + 1);
        if(id.Equals(HttpContext.Current.Request.Url.AbsoluteUri))
        {
            Response.Redirect("../ToVisitor/Index.aspx?er=0");
        }

        DataSet ds = VisitorBD.SelectValidReset(id);
        if(ds.Tables[0].Rows.Count == 0)
        {
            Response.Redirect("../ToVisitor/Index.aspx?er=0");
        }
        else
        {
            ltl_aux.Text = ds.Tables[0].Rows[0]["id"].ToString();
            
        }
      
    }

    protected void btn_redefinir_Click(object sender, EventArgs e)
    {
       if (txtSenha.Text.Equals(txtSenha2.Text)){
            int id = Convert.ToInt32 (ltl_aux.Text);
            string senha = txtSenha.Text;
            senha = UserDB.Criptografia(senha);
            if(VisitorBD.UpdateSenha(senha,id) == 0)
            {
                string hash = HttpContext.Current.Request.Url.AbsoluteUri;
                hash = hash.Substring(hash.IndexOf("=") + 1);
                if(VisitorBD.DeleteHash(hash,id) == 0)
                {
                    string email = VisitorBD.selectEmail(id);
                    VisitorBD.SendEmailSenhaAtualizada(email);

                    ltl_status.Text = "<script type='text/javascript'>swal('Sucesso', 'Sua senha foi alterada com sucesso', 'success')";
                    ltl_status.Text += ".then((value) => {window.location.replace('Index.aspx')}); </script> ";
                }
                else
                {
                    ltl_status.Text = "<script type=text/javascript> toastr.error('Algo deu errado, tente novamente mais tarde') </script >";
                }

              
            }
            else
            {
                ltl_status.Text = "<script type=text/javascript> toastr.error('Algo deu errado, tente novamente mais tarde') </script >";
            }
        }
        else{
            ltl_status.Text = "<script type=text/javascript> toastr.error('As senhas digitadas não são iguais!') </script >";
        }
      

    }
}