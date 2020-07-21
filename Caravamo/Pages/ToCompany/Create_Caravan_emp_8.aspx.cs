﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToUser_Create_Caravan_5 : System.Web.UI.Page
{

    protected void Page_PreInit(object sender, EventArgs e)
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
        


        if (!Page.IsPostBack)
        {
            Caravan car = (Caravan)Session["cadastro"];
            endereco[] enderecos = (endereco[])Session["auxiliar"];
            Proposta pro = (Proposta)Session["cadastro2"];

            ltl_tituloCaravana.Text = " " + car.Car_titulo;
            ltl_descricaoCaravana.Text = " " + car.Car_descricao;
             
            ltl_veiculo.Text = VehicleDB.selectVeiculoPlaca(Convert.ToInt32(pro.Vei_id));
            ltl_motorista.Text = DriverDB.selectDriverNome(Convert.ToInt32(pro.Mot_id));
            ltl_frete.Text ="R$ "+ pro.Pro_valor.ToString() +",00";

            int i = car.Car_privacidade;
            if(i == 0)
            {
                ltl_tipoCaravana.Text = " Caravana Publica";   
            }else if(i == 1)
            {
                ltl_tipoCaravana.Text = " Caravana Privada";
            }

            ltl_datSaida.Text = " " + car.HoraDeSaída.ToShortDateString();
            ltl_datDest.Text = " " + car.HoraDeChegada.ToShortDateString();

           
            ltl_endDest.Text = " " + enderecos[0].End_cidade;
            ltl_endDest.Text += ", " + enderecos[0].End_uf+"<br/>";
            ltl_endDest.Text += " " + enderecos[0].End_rua;       
            ltl_endDest.Text += ", " + enderecos[0].End_bairro;

            ltl_endSaida.Text = " " + enderecos[1].End_cidade;
            ltl_endSaida.Text += ", " + enderecos[1].End_uf + "<br/>";
            ltl_endSaida.Text += " " + enderecos[1].End_rua;           
            ltl_endSaida.Text += ", " + enderecos[1].End_bairro;

            string[] categoria = car.Car_categoria.Split(';');
            ltl_categoria.Text =" "+categoria[0];
            if(categoria.Length > 1)
            {
                ltl_categoria.Text += " e " + categoria[1];
            }
        }
    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        Caravan car = (Caravan)Session["cadastro"];
        endereco[] enderecos = (endereco[])Session["auxiliar"];
        car.Usu_car_criador = Convert.ToInt32(Session["id"]);
        Proposta pro = (Proposta)Session["cadastro2"];
        pro.Pro_status = "Aceito";
        pro.Pro_data = DateTime.UtcNow;
      
        if (CaravanDB.insertCaravan2(car) == 0)
        {
            int id = CaravanDB.selectCaravanEmp(car);
            pro.Car_id = id;
            int id2 = 0;
            string[] categoria = car.Car_categoria.Split(';');
            for (int i = 0; i < categoria.Length; i++)
            {
                id2 = CaravanDB.selectCategoria(categoria[i]);
                if (CaravanDB.insertCaravan_has_Category(id, id2) == 0)
                {

                }
                else
                {
                    // Algo deu errado
                }
            }
            Boolean error = false;
            foreach (endereco end in enderecos)
            {
                id2 = AddressDB.selectCidadeEstadoId(end.End_cidade.ToString(), end.End_uf.ToString());
                if (AddressDB.insertEndereco(end.End_bairro, end.End_rua, id2, end.End_tipo) == 0)
                {
                    id2 = AddressDB.selectEndereco(end.End_bairro, end.End_rua, id2);
                    if(CaravanDB.insertCaravan_has_Address(id,id2) == 0)
                    {

                    }
                    else
                    {
                        // Algo deu errado
                        error = true;
                    }

                }
                else
                {
                    //algo deu errado
                    error = true;
                    break;
                }

            }
            if(error == true)
            {
                // Deu tudo errado!
            }
            else
            {
                int id3 = CompanyDB.MakePropostas(pro);
                if(id3 != 0)
                {
                    if (CompanyDB.insertProposta_has_Motorista(pro, id3) == 0)
                    {
                        if (CompanyDB.insertProposta_has_Veiculo(pro, id3) == 0)
                        {
                            if (CompanyDB.insertCaravana_has_Proposta(pro, id3) == 0)
                            {
                                Session["CaravanID"] = id;
                                ltl_status.Text = "<script type='text/javascript'> swal('Sucesso!', 'Você será redirecionado a página da Caravana', 'success')";
                                ltl_status.Text += ".then((value) => {window.location.replace('../ToUser/Caravana.aspx')}); </script> ";

                            }
                            else
                            {
                                // Algo deu errado
                            }
                        }
                        else
                        {
                            // Algo deu errado
                        }
                    }
                    else
                    {
                        // Algo deu errado
                    }
                }
                else
                {
                    // Algo deu erro
                }
            }
        }
        else
        {
            // Algo deu errado
        }
    }
}