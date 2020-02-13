using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToUser_Create_Caravan_4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            cbl_categorias.Items.Clear(); ;
            cbl_categorias.Items.Add(new ListItem("Placeholder"));
            DataSet ds = CaravanDB.selectAllCategorias();
            cbl_categorias.DataSource = ds;
            cbl_categorias.DataTextField = "cat_nome";
            cbl_categorias.DataValueField = "cat_id";
            cbl_categorias.DataBind();
            cbl_categorias.Items.Remove("Placeholder");
        }
    }

    protected void cbl_categorias_SelectedIndexChanged(object sender, EventArgs e)
    {
        var items = from ListItem li in cbl_categorias.Items
                    where li.Selected == true
                    select li;

      

        if (items.Count() > 2)
        {
            ltl_status.Text = "<script type = 'text/javascript'> toastr.error('Só é possivel selecionar no máximo duas categorias!') </ script >"; ;
            items.Last().Selected = false;
        }
    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        var items = from ListItem li in cbl_categorias.Items
                    where li.Selected == true
                    select li;

        ltl_valid.Text = "";

        if (items.Count() > 0)
        {

            Caravan car = (Caravan)Session["cadastro"];

            foreach (ListItem categoria in cbl_categorias.Items)
            {
                if (categoria.Selected)
                {
                    car.Car_categoria += categoria.Text.ToString() + ";";
                }
            }
            car.Car_categoria = car.Car_categoria.Substring(0, car.Car_categoria.Length - 1);
            Response.Redirect("Create_Caravan_5.aspx");
        }
        else
        {
            ltl_valid.Text += "Por favor, escolha até duas categorias para sua caravana.";
        }

    }
}