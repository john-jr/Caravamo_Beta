using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToUser_Caravana_NaoInscrito : System.Web.UI.Page
{
    void Page_PreInit(object sender, EventArgs e)
    {


        if (Session["cliente"] == null || (Session["empresa"].Equals(false) && Session["cliente"].Equals(false)))
        {
            MasterPageFile = "~/Pages/Masters/Visitor.master";
            Session["id"] = -1;
        }
        else if (Session["empresa"].Equals(true))
        {
            MasterPageFile = "~/Pages/Masters/Corporation.master";
        }
    }


    protected void Page_Init(object sender, EventArgs e)
    {
        btn_fazerInscricao.Enabled = true;
        string id = HttpContext.Current.Request.Url.AbsoluteUri;
        id = id.Substring(id.IndexOf("=") + 1);
        if (id.Equals(HttpContext.Current.Request.Url.AbsoluteUri))
        {
            id = "";
             
        }
        else
        {
            Session["CaravanID"] = CaravanDB.selectCaravan4(id);
        }

        int CaravanID = Convert.ToInt32(Session["CaravanID"]);

        if (Session["empresa"] != null)
        {
            if (Session["empresa"].Equals(true) && Session["auxiliar3"].Equals(false))
            {
                DataSet ds = CaravanDB.selectThisCaravanCli2(CaravanID);
                DataSet ds1 = CaravanDB.selectEmpresaResp(CaravanID);
                btn_retornar.Visible = true;
                btn_mostrarInteresse.Visible = false;
                btn_cancelarInscricao.Visible = false;
                
                btn_fazerInscricao.Visible = false;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lbl_titulo.Text = dr["titulo"].ToString();
                    lbl_descricao.Text = dr["descricao"].ToString();
                    lbl_Criador.Text = dr["nomeCriador"].ToString();
                    img_caravana.ImageUrl = dr["foto"].ToString();
                    DateTime data = Convert.ToDateTime(dr["dataHoraSaida"].ToString());
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
                    else if (cidade.Count() == 1)
                    {
                        lbl_UFDestino.Text = cidade[0] + " - " + estado[1];
                    }
                    else
                    {
                        lbl_UFDestino.Text = cidade[1] + " - " + estado[1];
                    }

                    lbl_EndSaida.Text = rua[0] + " - " + bairro[0];
                    lbl_EndDestino.Text = rua[1] + " - " + bairro[1];

                    auxiliar = dr["privacidade"].ToString();
                    if (auxiliar.Equals("1"))
                    {
                        lbl_privacidade.Text = "Apenas por Convite";
                    }
                    else
                    {
                        lbl_privacidade.Text = "Aberta ao Público";
                    }
                    double valor = 1;
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
                        for (int i = 0; i < acessorios.Count(); i++)
                        {
                            auxiliar += "<div class='row'>";
                            auxiliar += "<div class='col-6 col-lg-6'>";
                            auxiliar += "<p>" + acessorios[i] + "</p> ";
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


                        lbl_PrecoPessoa.Text = Convert.ToString(valor);
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
                    if(ins == 0)
                    {
                        lbl_PrecoPessoa.Text = Convert.ToString(valor /1);
                    }
                    else {
                        lbl_PrecoPessoa.Text = Convert.ToString(valor / ins);
                    }

                   
                }
               



            }
        }

        if ((Session["cliente"] == null && !id.Equals("")) || (Session["cliente"].Equals(true)) || (Session["empresa"].Equals(true) && Session["auxiliar3"].Equals(true)) || (Session["cliente"].Equals(false) && !id.Equals("")))
        {
            DataSet ds = CaravanDB.selectThisCaravanCli(CaravanID);
            if(ds.Tables[0].Rows[0]["privacidade"].Equals("0") || ds.Tables[0].Rows[0].IsNull("id"))
            {
               ds = CaravanDB.selectThisCaravanCli2(CaravanID);
            }
            DataSet ds1 = CaravanDB.selectEmpresaResp(CaravanID);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lbl_titulo.Text = dr["titulo"].ToString();
                lbl_descricao.Text = dr["descricao"].ToString();
                lbl_Criador.Text = dr["nomeCriador"].ToString();
                img_caravana.ImageUrl = dr["foto"].ToString();
                DateTime data = Convert.ToDateTime(dr["dataHoraSaida"].ToString());
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
                else if (cidade.Count() == 1)
                {
                    lbl_UFDestino.Text = cidade[0] + " - " + estado[1];
                }
                else
                {
                    lbl_UFDestino.Text = cidade[1] + " - " + estado[1];
                }

                lbl_EndSaida.Text = rua[0] + " - " + bairro[0];
                lbl_EndDestino.Text = rua[1] + " - " + bairro[1];

                auxiliar = dr["privacidade"].ToString();
                if (auxiliar.Equals("1"))
                {
                    lbl_privacidade.Text = "Apenas por Convite";
                }
                else
                {
                    lbl_privacidade.Text = "Aberta ao Público";
                }

                if (ds1.Tables[0].Rows[0].IsNull("IdEmpresaResponsavel"))
                {
                    lbl_EmpresaResponsa.Text = "Nenhum";
                    informacoesVeiculo.Visible = false;
                    informacoesMotorista.Visible = false;
                    div_aux.Visible = false;
                    preco.Visible = false;
                    ltl_semEmp2.Text = "<p>Nenhuma Informação</p>";
                    ltl_semEmp.Text = "<p>Nenhuma Informação</p>";
                    ltl_semEmp3.Text = "<p class='text-center'>Nenhuma Informação</p>";
                    btn_fazerInscricao.Visible = false;
                    btn_cancelarInscricao.Visible = false;
                }
                else
                {

                    double valor = 1;
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
                        for (int i = 0; i < acessorios.Count(); i++)
                        {
                            auxiliar += "<div class='row'>";
                            auxiliar += "<div class='col-6 col-lg-6'>";
                            auxiliar += "<p>" + acessorios[i] + "</p> ";
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


                        lbl_PrecoPessoa.Text = Convert.ToString(valor);
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
                    if (ins == 0)
                    {
                        lbl_PrecoPessoa.Text = Convert.ToString(valor / 1);
                    }
                    else
                    {
                        lbl_PrecoPessoa.Text = Convert.ToString(valor / ins);
                    }
                }

                if (!ds1.Tables[0].Rows[0]["IdEmpresaResponsavel"].ToString().Equals(Session["id"].ToString()))
                {
                    if (Session["auxiliar3"] == null || !Session["auxiliar3"].Equals(true))
                    {



                        DataSet ds2 = UserDB.SelectInscricaoCaravana2(CaravanID, Convert.ToInt32(Session["id"]));
                        foreach (DataRow dro in ds2.Tables[0].Rows)
                        {
                            if (dro["css_status"].ToString().Equals("Inscrito"))
                            {
                                btn_mostrarInteresse.Visible = false;
                                btn_cancelarInscricao.Visible = true;
                                btn_fazerInscricao.Visible = false;

                            }
                            else if (dro["css_status"].ToString().Equals("Interessado"))
                            {
                                btn_cancelarInscricao.Visible = false;
                                btn_mostrarInteresse.Text = "Interessado";
                                if (ds1.Tables[0].Rows[0].IsNull("IdEmpresaResponsavel"))
                                {
                                    btn_fazerInscricao.Visible = false;
                                }
                            }
                            else if (dro["css_status"].ToString().Equals("Convidado"))
                            {
                                btn_mostrarInteresse.Visible = false;
                                btn_cancelarInscricao.Visible = false;
                                btn_fazerInscricao.Visible = true;
                                btn_fazerInscricao.Text = "Aguardando...";
                                btn_fazerInscricao.Enabled = false;

                            }

                            else if ((dro["css_status"].ToString().Equals("Cancelado")))
                            {
                                btn_mostrarInteresse.Text = "Mostrar interesse";
                                btn_mostrarInteresse.Visible = true;
                                if (ds1.Tables[0].Rows[0].IsNull("IdEmpresaResponsavel"))
                                {
                                    btn_fazerInscricao.Visible = false;
                                }
                                else
                                {
                                    btn_fazerInscricao.Visible = true;
                                }
                                btn_cancelarInscricao.Visible = false;
                            }
                        }
                        if (Session["cliente"] == null || (Session["empresa"].Equals(false) && Session["cliente"].Equals(false)) || ((ds2.Tables[0].Rows.Count == 0)))
                        {
                            btn_cancelarInscricao.Visible = false;
                        }
                    }
                    else
                    {
                        Session["auxiliar4"] = ds.Tables[0].Rows[0]["titulo"].ToString();
                        Session["auxiliar4"] += ds.Tables[0].Rows[0]["id"].ToString();
                        btn_mostrarInteresse.Visible = false;
                        btn_cancelarInscricao.Visible = false;
                        btn_fazerInscricao.Visible = false;
                        btn_fazerPropsota.Visible = true;
                        btn_retornar.Visible = true;
                    }

                }
                else
                {
                    btn_mostrarInteresse.Visible = false;
                    btn_cancelarInscricao.Visible = false;
                    btn_fazerInscricao.Visible = false;
                    btn_fazerPropsota.Visible = false;
                    btn_retornar.Visible = true;
                }

            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_mostrarInteresse_Click(object sender, EventArgs e)
    {

        if (Session["cliente"] == null || Session["cliente"].Equals(false))
        {
            ltl_status.Text = "<script type=text/javascript>$('#loginModal').modal('show');</script>";
        }
        else
        {
            int CaravanID = Convert.ToInt32(Session["CaravanID"]);
            int ID = Convert.ToInt32(Session["id"]);
            if (btn_mostrarInteresse.Text.Equals("Interessado"))
            {
                if (UserDB.CancelarInscricaoCaravana(CaravanID, ID) == 0)
                {
                    ltl_status.Text = "<script type=text/javascript> toastr.warning('A partir de agora você não receberá atualizações desta caravana pelo seu e-mail') </script>";
                    Page_Init(this, EventArgs.Empty);

                }
            }
            else
            {
                if (UserDB.SelectInscricaoCaravana(CaravanID, ID) == false)
                {
                    if (UserDB.InteresseCaravana(CaravanID, ID) == 0)
                    {
                        ltl_status.Text = "<script type=text/javascript> toastr.info('A partir de agora você receberá atualizações desta caravana pelo seu e-mail') </script>";
                        Page_Init(this, EventArgs.Empty);
                    }
                }
                else
                {
                    if (UserDB.InteresseCaravana2(CaravanID, ID) == 0)
                    {
                        ltl_status.Text = "<script type=text/javascript> toastr.info('A partir de agora você receberá atualizações desta caravana pelo seu e-mail') </script>";
                        Page_Init(this, EventArgs.Empty);
                    }
                }

            }
        }

    }

    protected void btn_fazerInscricao_Click(object sender, EventArgs e)
    {
        if (Session["cliente"] == null || Session["cliente"].Equals(false))
        {
            ltl_status.Text = "<script type=text/javascript>$('#loginModal').modal('show');</script>";
        }
        else
        {
            int CaravanID = Convert.ToInt32(Session["CaravanID"]);
            int ID = Convert.ToInt32(Session["id"]);
            if (UserDB.SelectInscricaoCaravana(CaravanID, ID) == false)
            {
                if (lbl_privacidade.Text.Equals("Apenas por Convite"))
                {
                    if (UserDB.MandarConviteCaravana(CaravanID, ID) == 0)
                    {
                        ltl_status.Text = "<script type=text/javascript> toastr.success('Você enviou seu convite para se inscrever nesta caravana com sucesso') </script>";
                        Page_Init(this, EventArgs.Empty);
                    }
                }
                else
                {
                    if (UserDB.InscreverCaravana(CaravanID, ID) == 0)
                    {
                        DataSet ds = UserDB.select_Interessados(Convert.ToInt32(Session["CaravanID"]));
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            VisitorBD.SendEmailAtualizacaoCaravana(dr["email"].ToString(), dr["tituloCaravana"].ToString(), dr["nomeCliente"].ToString(), dr["convite"].ToString());
                        }

                        ltl_status.Text = "<script type=text/javascript> toastr.success('Você se inscreveu nesta caravana com sucesso') </script>";
                        Page_Init(this, EventArgs.Empty);
                    }
                }
            }
            else
            {
                if (UserDB.InscreverCaravana2(CaravanID, ID) == 0)
                {
                    DataSet ds = UserDB.select_Interessados(Convert.ToInt32(Session["CaravanID"]));
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        VisitorBD.SendEmailAtualizacaoCaravana(dr["email"].ToString(), dr["tituloCaravana"].ToString(), dr["nomeCliente"].ToString(), dr["convite"].ToString());
                    }
                    ltl_status.Text = "<script type=text/javascript> toastr.success('Você se inscreveu nesta caravana com sucesso') </script>";
                    Page_Init(this, EventArgs.Empty);

                }
            }
        }

    }

    protected void btn_cancelarInscricao_Click(object sender, EventArgs e)
    {

        int CaravanID = Convert.ToInt32(Session["CaravanID"]);
        int ID = Convert.ToInt32(Session["id"]);

        if (UserDB.CancelarInscricaoCaravana(CaravanID, ID) == 0)
        {
            ltl_status.Text = "<script type=text/javascript> toastr.error('Você cancelou sua inscrição nesta caravana') </script>";
            Page_Init(this, EventArgs.Empty);
        }
    }

    protected void btn_retornar_Click(object sender, EventArgs e)
    {
        string a = Session["auxiliar5"].ToString();

        Response.Redirect(a);
    }

    protected void btn_fazerPropsota_Click(object sender, EventArgs e)
    {
        Response.Redirect("../ToCompany/Fazer_prop.aspx");
    }
}