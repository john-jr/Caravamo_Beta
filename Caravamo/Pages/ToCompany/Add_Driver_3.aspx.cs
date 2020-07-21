using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToCompany_Add_Driver_3 : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["id"] == null && Session["empresa"] == null)
        {
            Response.Redirect("../ToVisitor/Index.aspx?er=0");
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["cadastro"] != null && Session["cadastro"] is Motorista && Session["auxiliar"] is Usuario)
            {
                Motorista mot = (Motorista)Session["cadastro"];
                lbl_cnh.Text += " " + mot.Mot_cnh.ToString();
                lbl_cpf.Text += " " + mot.Mot_cpf.ToString();
                lbl_NomeDoMotorista.Text += " " + mot.Mot_nome.ToString();
            
                string genero = mot.Mot_genero.ToString();
                switch (genero)
                {
                    case "M":
                        lbl_genero.Text += " Masculino";
                        break;
                    case "F":
                        lbl_genero.Text += " Feminino";
                        break;
                    case "O":
                        lbl_genero.Text += " Outro";
                        break;
                }

                string aux = " " + mot.Mot_datadenascimento.ToString();
                lbl_nasc.Text += aux.Substring(0, 11);
                int pos = mot.Mot_foto.LastIndexOf("\\") + 1;
                lbl_foto.Text += mot.Mot_foto.Substring(pos , mot.Mot_foto.Length - pos);
                Usuario user = (Usuario)Session["auxiliar"];
                lbl_email.Text += " " + user.Usu_email.ToString();
            }
        }
    }

    protected void btn_confirmar_Click(object sender, EventArgs e)
    {
        Motorista mot = (Motorista)Session["cadastro"];
        
        if(Session["auxiliar"] != null && Session["auxiliar"] is Usuario)
        {
            Usuario user = (Usuario)Session["auxiliar"];
            UserDB.insertUser(user);
            mot.Usu_id = UserDB.selectUser(user);
        }

        mot.Mot_tip_id = 1;
        mot.Mot_emp_id = (int)Session["id"];
        
        if(DriverDB.insertDriver(mot) == 0)
        {
            ltl_status.Text = "<script type='text/javascript'> swal('Sucesso!', 'Você cadastrou um novo motorista!', 'success')";
            ltl_status.Text += ".then((value) => {window.location.replace('Drivers.aspx')}); </script> ";       
        }
        else
        {
            //Não foi possível cadastrar motorista
        }


    }

   



    protected void btn_retornar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add_Driver_2.aspx");
    }
}