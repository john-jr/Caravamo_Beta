using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cad_emp : System.Web.UI.Page
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
                        Empresa emp = new Empresa();
                        emp.Emp_nome = txtNome.Text;
                        emp.Emp_razaosocial = txtRazao.Text;
                        emp.Emp_cnpj = txtcnpj.Text;
                        emp.Emp_notificao = 0;
                        emp.Numeroartesp = txtArtesp.Text;
                        emp.Usu_id = id;
                        switch (UserDB.insertCompany(emp))
                        {
                            case 0:
                                string hash = UserDB.selectHashConf(id).ToString();
                                if (!hash.Equals("0"))
                                {
                                    VisitorBD.SendEmailConf(c.Usu_email, hash);
                                    ltl_status.Text = "<script type='text/javascript'> swal('Sucesso!', 'Você será redirecionado a página inicial', 'success')";
                                    ltl_status.Text += ".then((value) => {window.location.replace('Index.aspx')}); </script> ";
                                }
                                else
                                {
                                    ltl_status.Text = "<script type=text/javascript> toastr.error('Erro 2: Não foi possível inserir cliente') </";
                                    ltl_status.Text += "script>";
                                }
                                break;

                            case 2:
                               
                                 ltl_status.Text="<script type='text/javascript'> toastr.error('Erro 2: Não foi possível inserir empresa') </script>";
                                    
                               
                                break;
                        }
                        break;

                    case 2:
                      ltl_status.Text=("<script type='text/javascript'> toastr.error('Erro 2: Não foi possível inserir usuário') </script>");
                         
                    
                        break;
                }
            }
            else
            {
             
               ltl_status.Text=("<script type='text/javascript'> toastr.error('Já existe um usuário com este e-mail!') </script>");
                    
              
            }
        }
        else
        {
          
           ltl_status.Text=("<script type='text/javascript'> toastr.error('As senhas digitadas não coicidem!') </script>");
              
               
            
        }
    }
}