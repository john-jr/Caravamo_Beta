using Canducci.Zip;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToUser_Create_Caravan_2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataSet ds = AddressDB.selectAllEstados();
            ddl_estadoDestino.DataSource = ds;
            ddl_estadoOrigem.DataSource = ds;

            ddl_estadoDestino.DataTextField = "uc_uf";
            ddl_estadoDestino.DataValueField = "uc_uf";
            ddl_estadoDestino.DataBind();


           
            ddl_estadoOrigem.DataTextField = "uc_uf";
            ddl_estadoOrigem.DataValueField = "uc_uf";
            ddl_estadoOrigem.DataBind();

            string estado = ddl_estadoDestino.SelectedValue;
            ds = AddressDB.selectAllCidades(estado);
            ddl_cidadeDestino.DataSource = ds;
            ddl_cidadeDestino.DataTextField = "uc_cidade";
            ddl_cidadeDestino.DataValueField = "uc_cidade";
            ddl_cidadeDestino.DataBind();

            estado = ddl_estadoOrigem.SelectedValue;
            ds = AddressDB.selectAllCidades(estado);
            ddl_cidadeOrigem.DataSource = ds;
            ddl_cidadeOrigem.DataTextField = "uc_cidade";
            ddl_cidadeOrigem.DataValueField = "uc_cidade";
            ddl_cidadeOrigem.DataBind();
        }
    }



    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        
        endereco[] enderecos = new endereco[2];
        enderecos[0] = new endereco();
        enderecos[1] = new endereco();
        ddl_estadoOrigem.Enabled = true;
        ddl_cidadeOrigem.Enabled = true;
        txt_bairroOrigem.Enabled = true;
        txt_ruaOrigem.Enabled = true;

        ddl_estadoDestino.Enabled = true;
        ddl_cidadeDestino.Enabled = true;
        txt_bairroDestino.Enabled = true;
        txt_ruaDestino.Enabled = true;

        enderecos[0].End_bairro = txt_bairroDestino.Text.ToString();
        enderecos[0].End_cidade = ddl_cidadeDestino.SelectedValue.ToString();
        enderecos[0].End_cep = txt_cepDestino.Text;
        enderecos[0].End_rua = txt_ruaDestino.Text;
        enderecos[0].End_tipo = "D";
        enderecos[0].End_uf = ddl_estadoDestino.SelectedValue.ToString();
        enderecos[0].End_num = txt_numeroDestino.Text;

        enderecos[1].End_bairro = txt_bairroOrigem.Text;
        enderecos[1].End_cidade = ddl_cidadeOrigem.SelectedValue.ToString();
        enderecos[1].End_cep = txt_cepOrigem.Text;
        enderecos[1].End_rua = txt_ruaOrigem.Text;
        enderecos[1].End_tipo = "S";
        enderecos[1].End_uf = ddl_estadoOrigem.SelectedValue.ToString();
        enderecos[1].End_num = txt_numeroOrigem.Text;

        Session["auxiliar"] = enderecos;
        Response.Redirect("Create_Caravan_3.aspx");
    }

    protected void txt_cepOrigem_TextChanged(object sender, EventArgs e)
    {
        string cep = txt_cepOrigem.Text;    
        if (cep.Length == 9)
        {
            try
            {
                //Formato válido para o CEP: 01414000 ou 01414-000 ou 01.414-000
                ZipCodeLoad zipLoad = new ZipCodeLoad();

                ZipCode zipCode = null;
                ddl_estadoOrigem.Enabled = true;
                ddl_cidadeOrigem.Enabled = true;
                if (ZipCode.TryParse(cep, out zipCode))
                {
                    ZipCodeInfo zipCodeInfo = zipLoad.Find(zipCode);
                   txt_ruaOrigem.Text = zipCodeInfo.Address;
                    string estado = zipCodeInfo.Uf;
                    if (estado.Equals("SP") || estado.Equals("RJ") || estado.Equals("MG") || estado.Equals("ES"))
                    {
                        switch (estado)
                        {
                            case "SP":
                                ddl_estadoOrigem.SelectedValue = "São Paulo";
                                break;

                            case "RJ":
                                ddl_estadoOrigem.SelectedValue = "Rio de Janeiro";
                                break;

                            case "MG":
                                ddl_estadoOrigem.SelectedValue = "Minas Gerais";
                                break;
                            case "ES":
                                ddl_estadoOrigem.SelectedValue = "Espírito Santo";
                                break;

                        }


                        ddl_cidadeOrigem.SelectedValue = zipCodeInfo.City;

                        txt_bairroOrigem.Text = zipCodeInfo.District;
                        ddl_estadoOrigem.Enabled = false;
                        ddl_cidadeOrigem.Enabled = false;
                      
                    }
                    else
                    {
                        ltl_status.Text = "<script type = 'text/javascript' > toastr.error('Erro 7: Endereço fora da região sudeste') </script>";
                    }

                   
                   
                }

            }
            catch (ZipCodeException)
            {
                ltl_status.Text = "<script type = 'text/javascript' > toastr.error('Erro 0: Desconhecido') </ script >";     
            }
        }else if (string.IsNullOrEmpty(cep))
        {
            ddl_estadoOrigem.Enabled = true;
            ddl_cidadeOrigem.Enabled = true;
            txt_bairroOrigem.Enabled = true;
            txt_ruaOrigem.Enabled = true;

            txt_ruaOrigem.Text = "";
            txt_bairroOrigem.Text = "";
        }

    }


    protected void txt_cepDestino_TextChanged(object sender, EventArgs e)
    {
        string cep = txt_cepDestino.Text;
        
        if (cep.Length == 9)
        {
            try
            {
                //Formato válido para o CEP: 01414000 ou 01414-000 ou 01.414-000
                ZipCodeLoad zipLoad = new ZipCodeLoad();

                ZipCode zipCode = null;
                ddl_estadoDestino.Enabled = true;
                ddl_cidadeDestino.Enabled = true;
                if (ZipCode.TryParse(cep, out zipCode))
                {
                    ZipCodeInfo zipCodeInfo = zipLoad.Find(zipCode);
                    txt_ruaDestino.Text = zipCodeInfo.Address;
                    string estado = zipCodeInfo.Uf;
                    if (estado.Equals("SP") || estado.Equals("RJ") || estado.Equals("MG") || estado.Equals("ES"))
                    {
                        switch (estado)
                        {
                            case "SP":
                                ddl_estadoOrigem.SelectedValue = "São Paulo";
                                break;

                            case "RJ":
                                ddl_estadoOrigem.SelectedValue = "Rio de Janeiro";
                                break;

                            case "MG":
                                ddl_estadoOrigem.SelectedValue = "Minas Gerais";
                                break;
                            case "ES":
                                ddl_estadoOrigem.SelectedValue = "Espírito Santo";
                                break;

                        }
                        txt_bairroDestino.Text = zipCodeInfo.District;
                        ddl_estadoDestino.Enabled = false;
                        ddl_cidadeDestino.Enabled = false;
                     
                    }
                    else
                    {
                        ltl_status.Text = "<script type = 'text/javascript' > toastr.error('Erro 7: Endereço fora da região sudeste') </ script >";
                    }

                }

            }
            catch (ZipCodeException)
            {
                ltl_status.Text = "<script type = 'text/javascript' > toastr.error('Erro 0: Desconhecido') </ script >";
            }
        }else if (string.IsNullOrEmpty(cep))
        {
            ddl_estadoDestino.Enabled = true;
            ddl_cidadeDestino.Enabled = true;
            txt_bairroDestino.Enabled = true;
            txt_ruaDestino.Enabled = true;

            txt_bairroDestino.Text = "";
            txt_ruaDestino.Text = "";
        }

    }

    protected void ddl_estadoDestino_SelectedIndexChanged(object sender, EventArgs e)
    {
        string estado = ddl_estadoDestino.SelectedValue;
        DataSet ds = AddressDB.selectAllCidades(estado);
        ddl_cidadeDestino.DataSource = ds;
        ddl_cidadeDestino.DataTextField = "uc_cidade";
        ddl_cidadeDestino.DataValueField = "uc_cidade";
        ddl_cidadeDestino.DataBind();
    }

    protected void ddl_estadoOrigem_SelectedIndexChanged(object sender, EventArgs e)
    {
        string estado = ddl_estadoOrigem.SelectedValue;
        DataSet ds = AddressDB.selectAllCidades(estado);
        ddl_cidadeOrigem.DataSource = ds;
        ddl_cidadeOrigem.DataTextField = "uc_cidade";
        ddl_cidadeOrigem.DataValueField = "uc_cidade";
        ddl_cidadeOrigem.DataBind();
    }
}