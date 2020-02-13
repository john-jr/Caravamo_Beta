using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToCompany_Drivers : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        DataSet ds = DriverDB.selectDriver(Convert.ToInt32(Session["id"]));
        string ltl_status = "";
        foreach (DataRow dr in ds.Tables[0].Rows)
        {

            Literal top = new Literal();
            Literal bottom = new Literal();


            ltl_status = "<div class='col-md-4 col-12 mt-3'>";
            ltl_status += "<div class='card'>";
            ltl_status += "<div class='card-header  text-center  pt-2 pb-1 '>";
            ltl_status += "<h5 class ='text-center'>";
            string auxN = dr["mot_nome"].ToString();
            var names = auxN.Split(' ');
            ltl_status += names[0];
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
            ltl_status += "<strong>Nome Completo:</strong>";
            ltl_status += "<asp:Literal runat='server'>" +  dr["mot_nome"].ToString() + "</asp:Literal>";
            ltl_status += "</div>";
            ltl_status += "<div>";
            ltl_status += "<strong>Gênero: </strong>";
            string aux = dr["mot_genero"].ToString();
            if (aux == "M")
            {
                aux = "Masculino";
            }
            else if (aux == "F")
            {
                aux = "Feminino";
            }
            else if (aux == "O")
            {
                aux = "Outro";
            }
            ltl_status += "<asp:Literal runat='server'>" + aux + "</asp:Literal>";
            ltl_status += "</div>";
            ltl_status += "</div>";
            ltl_status += "<div>";
            ltl_status += "<strong>Idade:</strong>";
            var data = DateTime.Today;
            var nasc = Convert.ToDateTime(dr["mot_datanasciment"]);
            var idade = data.Year - nasc.Year;
            if (nasc.Date > data.AddYears(-idade)) { idade--; }
            ltl_status += "<asp:Literal runat='server'>" + idade.ToString() + " Anos</asp:Literal>";
            ltl_status += "</div>";
            ltl_status += "<div>";
            ltl_status += "<strong>Data de nascimento: </strong>";
            ltl_status += "<asp:Literal runat='server'>" + nasc.ToShortDateString() + "</asp:Literal>";
            ltl_status += "</div>";
            ltl_status += "<div class='mt-2'>";
            ltl_status += "<strong>E - mail:: </strong>";
            ltl_status += "<asp:Literal runat='server'>" + dr["usu_email"].ToString() + "</asp:Literal>";
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
            btn_editar.Text = "Editar Motorista";
            btn_editar.ID = "E" + dr["mot_id"].ToString();
            btn_editar.CssClass = "dropdown-item m";
            btn_editar.Click += new System.EventHandler(this.editar_Click);
            Button btn_excluir = new Button();
            btn_excluir.Text = "Excluir Motorista";
            btn_excluir.ID = "D" + dr["mot_id"].ToString();
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
            ltl_status += "  <h5 class='text-center'>Não há motoristas cadastrados</h5>";
            ltl_status += "</div>";
            none.Text = ltl_status;
            plh_status.Controls.Add(none);

        }

    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_AdicionarMotoristas_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add_Driver_1.aspx");
    }

    void editar_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.ID;
        buttonId = Regex.Replace(buttonId, "[^0-9.]", "");
        lbl_id.Text = buttonId;
        DataSet ds = DriverDB.selectDriver2(Convert.ToInt32(buttonId));
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            txt_nome.Text = dr["mot_nome"].ToString();
            rbl_sexo.SelectedValue = dr["mot_genero"].ToString();
            var dob = Convert.ToDateTime(dr["mot_datanasciment"]);
            txt_nasc.Text = dob.ToString("yyyy-MM-dd");    
            txt_email.Text = dr["usu_email"].ToString(); 
        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#loginModal').modal('show');</script>", false);
    }

    protected void excluir_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string buttonId = button.ID;
        buttonId = Regex.Replace(buttonId, "[^0-9.]", "");
      
        if(DriverDB.deleteDriver(buttonId) == 0)
        {
            //Deu tudo certo!
            Response.Redirect(Request.RawUrl);
        }
        else
        {
            //Algo deu errado
        }
    }

    protected void btn_ConfirmarEdicao_Click(object sender, EventArgs e)
    {
        string mot_id = lbl_id.Text;
        Motorista mot = new Motorista();
        mot.Mot_nome = txt_nome.Text;
        mot.Mot_genero =Convert.ToChar (rbl_sexo.SelectedValue.ToString());
        mot.Mot_datadenascimento = Convert.ToDateTime(txt_nasc.Text);
        string email = txt_email.Text;
        if (DriverDB.updateDriver(mot, email, mot_id) == 0)
        {
            // Deu tudo certo!
            Response.Redirect(Request.RawUrl);
        }
        else
        {
            // Algo deu errado!
        }
    }
}