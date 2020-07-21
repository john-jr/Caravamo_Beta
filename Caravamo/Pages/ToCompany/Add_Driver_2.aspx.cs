using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToCompany_Add_Driver_2 : System.Web.UI.Page
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
        if (Session["cadastro"] != null && Session["cadastro"] is Motorista)
        {
            Motorista mot = (Motorista)Session["cadastro"];
            if (String.IsNullOrEmpty(mot.Mot_cnh) && String.IsNullOrWhiteSpace(mot.Mot_cnh) && String.IsNullOrWhiteSpace(mot.Mot_cpf) && String.IsNullOrEmpty(mot.Mot_cpf))
            {

            }
            else {
                txt_cnh.Text = mot.Mot_cnh.ToString();
                txt_cpf.Text = mot.Mot_cpf.ToString();
            }
        }
    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        Motorista mot = (Motorista)Session["cadastro"];
        mot.Mot_cnh = txt_cnh.Text;
        mot.Mot_cpf = txt_cpf.Text;
        Response.Redirect("Add_Driver_3.aspx");
    }

    protected void btn_Retornar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add_Driver_1.aspx");
    }
}