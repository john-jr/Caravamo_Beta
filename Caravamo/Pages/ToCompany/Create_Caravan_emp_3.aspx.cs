using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToUser_Create_Caravan_3 : System.Web.UI.Page
{
    void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["id"] == null && Session["empresa"] == null)
        {
            Response.Redirect("../ToVisitor/Index.aspx?er=0");
        }

        if (Session["empresa"].Equals(true))
        {
            MasterPageFile = "~/Pages/Masters/Corporation.master";
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        Caravan car = (Caravan)Session["cadastro"];
        car.HoraDeChegada = Convert.ToDateTime(txt_dataRetorno.Text);
        car.HoraDeSaída = Convert.ToDateTime(txt_dataSaida.Text + " " + txt_horaDeSaida.Text);


      
        Session["cadastro"] = car;
        Response.Redirect("Create_Caravan_emp_4.aspx");

    }

    protected void btnRetornar1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Create_Caravan_emp_2.aspx");
    }
}