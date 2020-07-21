using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToUser_Caravana_Criador : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session["id"] == null && Session["cliente"] == null)
        {
            Response.Redirect("../ToVisitor/Index.aspx?er=0");
        }


        if (Session["CaravanID"].Equals(false))
        {

        }
        else
        {
            int CaravanID = Convert.ToInt32(Session["CaravanID"]);
           
            if (Session["empresa"].Equals(true))
            {
                propostas.Visible = false;
                convites.Visible = false;
                //DataSet ds = CaravanDB.selectThisCaravanCli(CaravanID);
              //  foreach (DataRow dr in ds.Tables[0].Rows)
             //   {

              //  }
            }
            else if (Session["cliente"].Equals(true))
            {
              DataSet ds = CaravanDB.selectThisCaravanCli(CaravanID);
                DataSet ds1 = CaravanDB.selectEmpresaResp(CaravanID);
            foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    img_capa.ImageUrl = dr["foto"].ToString();
                    lbl_titulo.Text = dr["titulo"].ToString();
                    lbl_descricao.Text = dr["descricao"].ToString();
                    lbl_Criador.Text = dr["nomeCriador"].ToString();
                    DateTime data = Convert.ToDateTime (dr["dataHoraSaida"].ToString());
                    Session["auxiliar"] = lbl_titulo.Text;
                    

                    lbl_dataSaida.Text = data.ToString("dd/MM/yyyy");

                    Session["auxiliar2"] = lbl_dataSaida.Text;

                    lbl_HoraSaida.Text = data.ToString("HH:mm");
                    lbl_dataSaida1.Text = data.ToString("dd/MM/yyyy");
                    data = Convert.ToDateTime(dr["dataHoraChegada"].ToString());
                    lbl_dataRetorno.Text = data.ToString("dd/MM/yyyy");
                    string auxiliar = dr["uf"].ToString();
                    string[] estado = auxiliar.Split(',');
                    auxiliar = dr["cidade"].ToString();
                    string[] cidade = auxiliar.Split(',');
                    auxiliar = dr["bairro"].ToString();
                    string[] bairro = auxiliar.Split(',');
                    auxiliar = dr["rua"].ToString();
                    string[] rua = auxiliar.Split(',');

                    lbl_UFSaida.Text = cidade[0] + " - " + estado[0];
                     if (cidade.Count() == 1 && estado.Count() == 1)
                    {
                        lbl_UFDestino.Text = cidade[0] + " - " + estado[0];
                    }

                    else if (estado.Count() == 1)
                    {
                        lbl_UFDestino.Text = cidade[1] + " - " + estado[0];
                    }
                    else if(cidade.Count() == 1)
                    {
                        lbl_UFDestino.Text = cidade[0] + " - " + estado[1];
                    }
                    
                    else
                    {
                        lbl_UFDestino.Text = cidade[1] + " - " + estado[1];
                    }

                    lbl_EndSaida.Text = rua[0] + " - " + bairro[0];
                    lbl_EndDestino.Text = rua[1] + " - " + bairro[1];
                    if(ds1.Tables[0].Rows[0].IsNull("IdEmpresaResponsavel"))
                    {
                        lbl_EmpresaResponsa.Text = "Nenhum";
                        informacoesVeiculo.Visible = false;
                        informacoesMotorista.Visible = false;
                        div_aux.Visible = false;
                        preco.Visible = false;
                        ltl_semEmp2.Text = "<p>Nenhuma Informação</p>";
                        ltl_semEmp.Text = "<p>Nenhuma Informação</p>";
                        ltl_semEmp3.Text = "<p class='text-center'>Nenhuma Informação</p>";
                    }
                    else
                    {
                        double valor = 1;
                        btn_cancelarCaravana.Visible = false;
                        propostas.Visible = false;
                        foreach (DataRow dro in ds1.Tables[0].Rows)
                        {


                             lbl_EmpresaResponsa.Text = dro["EmpresaResponsavel"].ToString();
                            lbl_VagasTotal.Text = dro["QntAssentos"].ToString();
                            lbl_lugaresVeiculo.Text = dro["QntAssentos"].ToString();
                            lbl_marca.Text = dro["Marca"].ToString();
                            lbl_NomeMot.Text = dro["nomeMotorista"].ToString();
                            auxiliar = dro["sexo"].ToString();
                            if (auxiliar.Equals("O"))
                            {
                                lbl_SexoMot.Text = "Outro";
                            }
                           else if (auxiliar.Equals("M"))
                            {
                                lbl_SexoMot.Text = "Masculino";
                            }
                            if (auxiliar.Equals("F"))
                            {
                                lbl_SexoMot.Text = "Feminino";
                            }
                            var dataH = DateTime.Today;
                            var nasc = Convert.ToDateTime(dro["DataNascimentoMotorista"]);
                            var idade = dataH.Year - nasc.Year;
                            lbl_Idade.Text = idade + " Anos";

                            lbl_modelo.Text = dro["Modelo"].ToString();
                            lbl_ano.Text = dro["AnoVeiculo"].ToString();
                            auxiliar = dro["TipoVeiculo"].ToString();
                            if (auxiliar.Equals("M"))
                            {
                                lbl_tipo.Text = "Mini - Ônibus";
                            }
                            else if (auxiliar.Equals("V"))
                            {
                                lbl_tipo.Text = "Van";
                            }
                            else if (auxiliar.Equals("O"))
                            {
                                lbl_tipo.Text = "Ônibus";
                            }

                            auxiliar = dro["acessorios"].ToString();
                            string[] acessorios = auxiliar.Split(',');
                            Literal l = new Literal();
                            auxiliar = "";
                            for(int i =0;i < acessorios.Count(); i++)
                            {
                                auxiliar += "<div class='row'>";
                                auxiliar += "<div class='col-6 col-lg-6'>";
                                auxiliar += "<p>"+acessorios[i]+"</p> ";
                                auxiliar += "</div>";
                                auxiliar += "<div class='col-2'>";
                                auxiliar += "<p>";
                                auxiliar += "<label>Sim</label>";
                                auxiliar += "</p>";
                                auxiliar += "</div>";
                                auxiliar += "</div>";
                            }
                            l.Text = auxiliar;
                            phl_acessorios.Controls.Add(l);
                            valor = Convert.ToDouble(dro["ValorTotal"].ToString());
                            

                            
                        }
                        DataSet ds2 = CaravanDB.selectCaravanPeople(CaravanID);
                        int dis = 0, ins = 0, inte = 0;
                        foreach (DataRow dro in ds2.Tables[0].Rows)
                        {
                            if (dro["css_status"].ToString().Equals("Inscrito"))
                            {
                                ins++;
                            }
                            else if (dro["css_status"].ToString().Equals("Interessado"))
                            {
                                inte++;
                            }
                        }
                        dis = Convert.ToInt32(lbl_VagasTotal.Text) - ins;
                        lbl_Inscritos.Text = Convert.ToString(ins);
                        lbl_Interessados.Text = Convert.ToString(inte);
                        lbl_VagasDisponivel.Text = Convert.ToString(dis);
                        lbl_PrecoPessoa.Text = Convert.ToString(valor/ ins);

                    }
                }
            }
            else
            {

            }
            

        }
        
    }


        protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Inscrever_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#modal').modal('show');</script>", false);
    }


    protected void btn_adicionar_Click(object sender, EventArgs e)
    {

    }

    protected void btn_modal2_Click1(object sender, EventArgs e) /*botao concluir no modal de adicionar participantes*/
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#modal').modal('hide');</script>", false);
    }



    protected void btn_fecharModal_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "script", "<script>$('#modal2').modal('hide');</script>", false);
    }
}