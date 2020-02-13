using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToCompany_Add_Driver : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            if (Session["cadastro"] != null && Session["cadastro"] is Motorista && Session["auxiliar"] is Usuario)
            {
                Motorista mot = (Motorista)Session["cadastro"];
                Usuario user = (Usuario)Session["auxiliar"];
                if (String.IsNullOrEmpty(user.Usu_email) && String.IsNullOrWhiteSpace(user.Usu_email) && String.IsNullOrEmpty(mot.Mot_nome) && String.IsNullOrWhiteSpace(mot.Mot_nome))
                {

                }
                else
                {
                    txt_email.Text = user.Usu_email.ToString();
                    var dob = Convert.ToDateTime(mot.Mot_datadenascimento);
                    txt_datanasc.Text = dob.ToString("yyyy-MM-dd");
                    txt_NomeMotorista.Text = mot.Mot_nome.ToString();
                    rbl_sexo.SelectedValue = mot.Mot_genero.ToString();
                }
            }
            else
            {
             
            }
           ;
        }
        
    }


    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        Motorista mot = new Motorista();
        Usuario user = new Usuario();
        user.Usu_email = txt_email.Text;
        user.Usu_senha = "0";
        mot.Mot_nome = txt_NomeMotorista.Text;
        mot.Mot_datadenascimento = Convert.ToDateTime(txt_datanasc.Text);
        mot.Mot_genero = Convert.ToChar(rbl_sexo.SelectedItem.Value.ToString());
        Session["cadastro"] = mot;
        Session["auxiliar"] = user;
        Response.Redirect("Add_Driver_2.aspx");

    }

    protected void btn_cancelar_Click(object sender, EventArgs e)
    {

        Session["cadastro"] = null;
        Response.Redirect("Drivers.aspx");

    }
}