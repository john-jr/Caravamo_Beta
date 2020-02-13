using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToCompany_Add_Vehicle_4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!Page.IsPostBack)
        {
            Veiculo vei = (Veiculo)Session["cadastro"];
            lbl_MarcaVeiculo.Text += " " + vei.Mod_marca.ToString();
            lbl_ModeloVeiculo.Text += " " + vei.Mod_modelo.ToString();
            lbl_TipoVeiculo.Text += " " + vei.Vei_tipo.ToString();
            lbl_qntassentos.Text += " " + vei.Vei_assentos.ToString();
            lbl_Placa.Text += " " + vei.Vei_placa.ToString();
            lbl_ano.Text += " " + vei.Vei_ano.ToString();
            lbl_crlv.Text += " " + vei.Vei_crlv.ToString();
            string[] acessorios = vei.Acessorio.ToString().Split(';');
            for (int i = 0; i < acessorios.Length; i++)
            {
                lbx_acessorios.Items.Add(acessorios[i]);
            }


        }
    }

    protected void retornar_Click(object sender, EventArgs e)
    {
        //Observação: O Add_Vehicle_3.aspx está desativado até que seja possível adicionar imagens no sistema (front e banco de dados)
        Response.Redirect("Add_Vehicle_2");
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        Veiculo vei = (Veiculo)Session["cadastro"];
        string[] acessorios = vei.Acessorio.ToString().Split(';');
        if (VehicleDB.insertModelo(vei) == 0)
        {
            int id = VehicleDB.selectModelo(vei);
            int aux = 0;
            int id2 = 0;
            Boolean nothingWrong = true;
            if (id != -1)
            {
                if (VehicleDB.insertVeiculo(vei, id) == 0)
                {
                    id = VehicleDB.selectVeiculo(vei);
                    if (id != -1)
                    {
                        for (int i = 0; i < acessorios.Length; i++)
                        {
                            aux = VehicleDB.existAcessorio(acessorios[i]);
                            if (aux == 0)
                            {
                                if (VehicleDB.insertAcessorio(acessorios[i]) == 0)
                                {
                                    id2 = VehicleDB.selectAcessorio(acessorios[i]);
                                    if(VehicleDB.insertVeiculo_Acessorio(id,id2) == 0)
                                    {

                                    }
                                    else
                                    {
                                        //Algo deu errado
                                        nothingWrong = false;
                                    }
                                }
                                else
                                {
                                    // Algo deu errado
                                    nothingWrong = false;
                                    break;

                                }
                            }
                            else if (aux == -1)
                            {
                                // Algo deu errado
                                nothingWrong = false;
                                break;
                            }
                            else
                            {
                                id2 = VehicleDB.selectAcessorio(acessorios[i]);
                                if (VehicleDB.insertVeiculo_Acessorio(id, id2) == 0)
                                {

                                }
                                else
                                {
                                    //Algo deu errado
                                    nothingWrong = false;
                                }
                            }
                        }
                        if(nothingWrong == true)
                        {
                            ltl_status.Text = "<script type='text/javascript'> swal('Sucesso!', 'Você cadastrou um veículo', 'success')";
                            ltl_status.Text += ".then((value) => {window.location.replace('Vehicles.aspx')}); </script> ";

                            
                        }
                        else
                        {
                            // Deu tudo errado!
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
                // Algo deu errado
            }
        }
        else
        {
            // Algo deu errado
        }


    }

}