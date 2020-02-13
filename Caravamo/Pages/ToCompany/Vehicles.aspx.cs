using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToCompany_Vehicle : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {

        DataSet ds = VehicleDB.selectVeiculo2(Convert.ToInt32(Session["id"]));
        string ltl_status = "";

        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            Literal top = new Literal();
            Literal bottom = new Literal();


            ltl_status = "<div class='col-md-4 col-12 mt-3'>";
            ltl_status += "<div class='card'>";
            ltl_status += "<div class='card-header  text-center  pt-2 pb-1 '>";
            ltl_status += "<h5 class ='text-center'>";
            ltl_status += dr["vei_placa"].ToString();
            ltl_status += "</h5>";
            ltl_status += "</div>";
            ltl_status += "<div class='row'>";
            ltl_status += "<div class='col-12 rx-2'>";
            ltl_status += "<img src='../../img/index_images/noimg.png' Class='w-100 border border-light rounded'>";
            ltl_status += "</div>";
            ltl_status += "<div class='col-md-12  pt-2'>";
            ltl_status += "<div class='card-block btn-more'>";
            ltl_status += "<div class='ml-1 text-center'>";
            ltl_status += "<div class='mb-2'>";
            ltl_status += "<div>";
            ltl_status += "<strong>Ano:</strong>";
            ltl_status += "<asp:Literal runat='server'>" + dr["vei_ano"].ToString() + "</asp:Literal>";
            ltl_status += "</div>";
            ltl_status += "<div>";
            ltl_status += "<strong>Tipo: </strong>";
            string aux = dr["vei_tipo"].ToString();
            if (aux == "O")
            {
                aux = "Ônibus";
            }
            else if (aux == "M")
            {
                aux = "Micro - Ônibus";
            }
            else if (aux == "V")
            {
                aux = "Van";
            }
            ltl_status += "<asp:Literal runat='server'>" + aux + "</asp:Literal>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "<div>";
            ltl_status += "<strong>Marca:</strong>";
            ltl_status += "<asp:Literal runat='server'>" + dr["mod_marca"].ToString() + "</asp:Literal>";
            ltl_status += "</div>";
            ltl_status += "<div>";
            ltl_status += "<strong>Modelo: </strong>";
            ltl_status += "<asp:Literal runat='server'>" + dr["mod_nome"].ToString() + "</asp:Literal>";
            ltl_status += "</div>";
            ltl_status += "<div class='mt-2'>";
            ltl_status += "<strong>Quantidade de Assentos: </strong>";
            ltl_status += "<asp:Literal runat='server'>" + dr["vei_assentos"].ToString() + "</asp:Literal>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "<div class='col-12 mb-1 mt-5 mt-auto'>";
            ltl_status += "<div class='row'>";
            ltl_status += "<div class='col-2'>";
            ltl_status += "<div class='btn-group dropright'>";
            ltl_status += "<button class='btn btn-secondary dropdown-toggle' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false' style='padding-bottom:10px;background-color:#ffcc00;border: 1px solid transparent;'>";
            ltl_status += "<i class='fa fa-cog fa-lg pt-2'></i>";
            ltl_status += "</button>";
            ltl_status += "<div class='dropdown-menu' style='background-color:#ffcc00;'>";
            top.Text = ltl_status;
            ltl_status = " ";
            Button btn_editar = new Button();
            btn_editar.Text = "Editar Veículo";
            btn_editar.ID = "E" + dr["vei_id"].ToString();
            btn_editar.CssClass = "dropdown-item m";
            btn_editar.Click += new System.EventHandler(this.editar_Click);
            Button btn_excluir = new Button();
            btn_excluir.Text = "Excluir Veículo";
            btn_excluir.ID = "D" + dr["vei_id"].ToString();
            btn_excluir.CssClass = "dropdown-item m";
            btn_excluir.Click += new System.EventHandler(this.excluir_Click);
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "<div class='col-md-9 col-10  '>";
            ltl_status += "<label  class='genric-btn info w-100 btn-more mt-1'> Livre</label>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            bottom.Text = ltl_status;
            plh_status.Controls.Add(top);
            plh_status.Controls.Add(btn_editar);
            plh_status.Controls.Add(btn_excluir);
            plh_status.Controls.Add(bottom);

        }
        if (ltl_status == "")
        {
            Literal none = new Literal();
            ltl_status = "";
            ltl_status += "    <div class='col - 12'>";
            ltl_status += "  <h5 class='text-center'>Não há veiculos cadastrados</h5>";
            ltl_status += "</div>";
            none.Text = ltl_status;
            plh_status.Controls.Add(none);

        }


    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btn_AdicionarVeiculos_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add_Vehicle_1.aspx");
    }

    void editar_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.ID;
        buttonId = Regex.Replace(buttonId, "[^0-9.]", "");
        lbl_id.Text = buttonId;

        DataSet ds = VehicleDB.selectVeiculo3(Convert.ToInt32(buttonId));
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            txt_placa.Text = dr["vei_placa"].ToString();
            string ano = dr["vei_ano"].ToString();
            ano = ano.Substring(ano.Length - 2);
            ddl_ano.SelectedValue = ano;
            rbl_tipoVeiculo.SelectedValue = dr["vei_tipo"].ToString();
            txt_marca.Text = dr["mod_marca"].ToString();
            txt_modelo.Text = dr["mod_nome"].ToString();
            txt_qntAssentos.Text = dr["vei_assentos"].ToString();
        }
            Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#loginModal').modal('show');</script>", false);
    }



    protected void excluir_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.ID;
        buttonId = Regex.Replace(buttonId, "[^0-9.]", "");

        if (VehicleDB.deleteVeiculo_Acessorio_Relation(buttonId) == 0)
        {
            if (VehicleDB.deleteVeiculo(buttonId) == 0)
            {
                // Foi deletado
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                // Aconteceu um erro
            }
        }
        else
        {
            // Aconteceu um erro
        }
      
    }

    protected void btn_ConfirmarEdicao_Click(object sender, EventArgs e)
    {
        string vei_id = lbl_id.Text;
        Veiculo vei = new Veiculo();
        vei.Vei_ano =Convert.ToInt32 (ddl_ano.SelectedItem.ToString());
        vei.Vei_placa = txt_placa.Text;
        vei.Vei_tipo = rbl_tipoVeiculo.SelectedValue.ToString();
        vei.Mod_marca = txt_marca.Text;
        vei.Mod_modelo = txt_modelo.Text;
        vei.Vei_assentos = Convert.ToInt32(txt_qntAssentos.Text);
        if(VehicleDB.insertModelo(vei) == 0)
        {
          vei.Mod_id =  (VehicleDB.selectModelo(vei));
            if(VehicleDB.updateVeiculo(vei,vei_id) == 0)
            {
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                // Algo deu errado
            }

        }
        else
        {
            //Algo deu errado
        }
    }
}