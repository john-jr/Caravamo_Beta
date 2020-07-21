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

    }

    protected void btn_redefinir_Click(object sender, EventArgs e)
    {
        String email = txtEmail.Text;
       

        if (UserDB.selectUser2(email) == true)
        {
            ltl_status.Text = "<script type='text/javascript'>swal('Atenção', 'Um E-mail foi enviado para " + email + " com as instruções para redefinição de senha', 'info') ";
            ltl_status.Text += ".then((value) => {window.location.replace('Index.aspx')}); </script> ";
            VisitorBD.insertSenhaSegurancaUsuario(email);
            string hash = VisitorBD.selectHash();
            VisitorBD.SendEmailRecuperarSenha(email,hash);
        }
        else
        {
            ltl_status.Text = "<script type='text/javascript'>swal('Atenção', 'Usuário Não Encontrado', 'error'); </script>";
            txtEmail.Text = "";
        }


      

    }
}