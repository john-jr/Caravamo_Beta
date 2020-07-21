using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Pages_ToCompany_Add_Vehicle_2 : System.Web.UI.Page
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
            cbl_acessorios.Items.Clear(); ;
            cbl_acessorios.Items.Add(new ListItem("Placeholder"));
            DataSet ds = VehicleDB.selectAllAcessories();
            cbl_acessorios.DataSource = ds;
            cbl_acessorios.DataTextField = "ace_nome";
            cbl_acessorios.DataValueField = "ace_nome";
            cbl_acessorios.DataBind();
            cbl_acessorios.Items.Remove("Placeholder");

         
         
         //   cbl_acessorios.Items.Add(new ListItem("Televisão"));
         //   cbl_acessorios.Items.Add(new ListItem("Rádio"));
         //   cbl_acessorios.Items.Add(new ListItem("Bluetooth"));
         //   cbl_acessorios.Items.Add(new ListItem("Wi - Fi"));
         //   cbl_acessorios.Items.Add(new ListItem("Frigobar"));
         //   cbl_acessorios.Items.Add(new ListItem("Som"));
          //  cbl_acessorios.Items.Add(new ListItem("DVD"));
         //   cbl_acessorios.Items.Add(new ListItem("Poltrona Leito"));
        }
    }

    protected void btn_add_Click(object sender, EventArgs e)
    {
        if (!(string.IsNullOrWhiteSpace(txt_novoAcessorio.Text)))
        {
            ListItem listItem = new ListItem();
            listItem.Value = txt_novoAcessorio.Text;
            listItem.Text = txt_novoAcessorio.Text;
            listItem.Selected = true;

            cbl_acessorios.Items.Add(listItem);
        }
    }

    protected void btnRetornar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add_Vehicle_1.aspx");
    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        Veiculo vei = (Veiculo)Session["cadastro"];
       

        vei.Vei_assentos = Convert.ToInt32(amount.Text);
        
        foreach (ListItem acessorio in cbl_acessorios.Items)
        {
            if (acessorio.Selected)
            {         
                    vei.Acessorio += acessorio.Text.ToString() + ";";
            }
        }
        vei.Acessorio = vei.Acessorio.Substring(0, vei.Acessorio.Length - 1);
        Session["cadastro"] = vei;

        // Nota: o Add_Vehicle_3.aspx é a página para adicionar fotos,não implementado ainda
        Response.Redirect("Add_Vehicle_4.aspx");

    }
}