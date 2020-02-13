using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToCompany_Add_Vehicle_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_retornar_Click(object sender, EventArgs e)
    {
        Session["cadastro"] = null;
        Response.Redirect("Vehicles.aspx");
    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        Veiculo vei = new Veiculo();
        vei.Mod_marca = txt_marca.Text;
        vei.Mod_modelo = txt_modelo.Text;
        vei.Vei_tipo = rbl_tipoVeiculo.SelectedItem.Value.ToString();
        vei.Vei_ano = Convert.ToInt32(ddl_ano.SelectedItem.ToString());
        vei.Vei_placa = txt_placa.Text;
        vei.Vei_crlv = txt_crlv.Text;
        vei.Emp_id = Convert.ToInt32(Session["id"].ToString());
        Session["cadastro"] = vei;
        Response.Redirect("Add_Vehicle_2.aspx");
    }
}