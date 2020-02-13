using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToCompany_Fazer_prop4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string aux = Session["auxiliar"].ToString();
        aux = Regex.Replace(aux, @"[\d-]", string.Empty); ;
        ltl_auxiliar.Text = "<h2>Proposta para: " + aux + "</h2>";

        Proposta pro = (Proposta)Session["cadastro"];

        lblVeiculo.Text = VehicleDB.selectVeiculoPlaca(Convert.ToInt32(pro.Vei_id));

        string auxN = DriverDB.selectDriverNome(pro.Mot_id);
        var names = auxN.Split(' ');

        lbl_motorista.Text = names[0];

        lblValor.Text = "R$ "+ pro.Pro_valor.ToString() + ",00";

    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        Proposta pro = (Proposta)Session["cadastro"];
        pro.Pro_status = "Aguardando";
        pro.Pro_data = DateTime.UtcNow;
        int id = CompanyDB.MakePropostas(pro);
        if(id != 0)
        {
        if(CompanyDB.insertProposta_has_Motorista(pro,id) == 0)
            {
                if(CompanyDB.insertProposta_has_Veiculo(pro,id) == 0)
                {
                    if(CompanyDB.insertCaravana_has_Proposta(pro,id) == 0)
                    {
                        ltl_status.Text = "<script type='text/javascript'> swal('Sucesso!', 'Sua proposta foi enviada', 'success')";
                        ltl_status.Text += ".then((value) => {window.location.replace('Propostas_Realizadas.aspx')}); </script> ";

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