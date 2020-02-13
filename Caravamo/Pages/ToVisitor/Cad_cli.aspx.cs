using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cad_cli : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        Usuario c = new Usuario();
        c.Usu_email = txtEmail.Text;
 
        if (txtSenha.Text.Equals(txtSenha2.Text))
        {
            c.Usu_senha = UserDB.Criptografia(txtSenha.Text);
            if (UserDB.selectUser2(c.Usu_email) == false)
            {
                switch (UserDB.insertUser(c))
                {
                    case 0:

                        int id = UserDB.selectUser(c);
                        Pessoa P = new Pessoa();
                        P.Cli_nome = txtNome.Text;
                        P.Cli_email = c.Usu_email;
                        P.Cli_genero = Convert.ToChar(rblSexo.SelectedValue.ToString());
                        string aux = datapiker.Text;
                        P.Cli_datanascimento = Convert.ToDateTime(aux);
                        P.Tip_id = 2;
                        P.Usu_id = id;

                        switch (UserDB.insertClient(P))
                        {
                            case 0:

                                ltl_status.Text = "<script type='text/javascript'> swal('Sucesso!', 'Você será redirecionado a página inicial', 'success')";
                                ltl_status.Text += ".then((value) => {window.location.replace('Index.aspx')}); </script> ";           
                                break;
                            case 2:
                              
                              ltl_status.Text="<script type=text/javascript> toastr.error('Erro 2: Não foi possível inserir cliente') </";
                              ltl_status.Text+="script>";  
                                break;
                        }

                        break;
                    case 2:

                        ltl_status.Text = "<script type=text/javascript> toastr.error('Erro 2: Não foi possível inserir usuário') </";
                        ltl_status.Text += "script>";
                        break;
                }
            }
            else
            {
                ltl_status.Text = ("<script type=text/javascript> toastr.error('Já existe um usuário com este e-mail!') </");
                ltl_status.Text += ("script>");
            }
        }
        else
        {

            ltl_status.Text = "<script type=text/javascript> toastr.error('As senhas digitadas não são iguais!') </";
            ltl_status.Text += "script>";
           
        }
    }
}