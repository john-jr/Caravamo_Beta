using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToUser_Create_Caravan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        Caravan car = new Caravan();
        car.Car_titulo = txt_tituloCaravana.Text;
        car.Car_descricao = txt_descricao.Text;
        if (rbtn_privada.Checked)
        {
            car.Car_privacidade = 1;
        }
        else if(rbtn_publica.Checked)
        {
            car.Car_privacidade = 0;
        }
        Session["cadastro"] = car;
        Response.Redirect("Create_Caravan_2.aspx");
    }

    protected void btn_cancelar_Click(object sender, EventArgs e)
    {
        


        Session["cadastro"] = null;
        Session["auxiliar"] = null;
        Response.Redirect("Home_User.aspx");
    }
}