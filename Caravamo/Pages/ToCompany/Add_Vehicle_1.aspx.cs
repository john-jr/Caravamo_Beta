using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToCompany_Add_Vehicle_1 : System.Web.UI.Page
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

    }

    protected void btn_retornar_Click(object sender, EventArgs e)
    {
        Session["cadastro"] = null;
        Response.Redirect("Vehicles.aspx");
    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        Veiculo vei = new Veiculo();
        vei.Mod_marca = txt_marca.Text;
        vei.Mod_modelo = txt_modelo.Text;
        vei.Vei_tipo = rbl_tipoVeiculo.SelectedItem.Value.ToString();
        vei.Vei_ano = Convert.ToInt32(ddl_ano.SelectedItem.ToString());
        vei.Vei_placa = txt_placa.Text;
        vei.Vei_crlv = txt_crlv.Text;
        CriarDiretorio();;
        vei.Vei_foto = UploadArquivo(fu_foto, fu_foto.FileName);
        vei.Emp_id = Convert.ToInt32(Session["id"].ToString());
        Session["cadastro"] = vei;
        Response.Redirect("Add_Vehicle_2.aspx");
    }

    public static bool CriarDiretorio()
    {
        string dir = HttpContext.Current.Request.PhysicalApplicationPath + "Uploads\\Veiculos\\";
        if (!Directory.Exists(dir))
        {
            //Caso não exista devermos criar
            Directory.CreateDirectory(dir);
            return true;
        }
        else
            return false;
    }


    public static string UploadArquivo(FileUpload flpUpload, string nome)
    {



        string arq = Path.GetFileName(flpUpload.FileName);
        double tamanho = Convert.ToDouble(flpUpload.PostedFile.ContentLength) / 1024;
        string extensao = Path.GetExtension(flpUpload.FileName).ToLower();
        string diretorio = HttpContext.Current.Request.PhysicalApplicationPath + "Uploads\\Veiculos\\" + nome;
        string aux;
        int pos = 0;
        if ((extensao != ".png" && extensao != ".jpg"))
            return "Extenção Inválida";
        else
        {
            if (!File.Exists(diretorio))
            {
                flpUpload.SaveAs(diretorio);
                pos = diretorio.LastIndexOf("Caravamo") + 8;
                aux = diretorio.Substring(pos, diretorio.Length - pos);
                aux = "../.." + aux;
                return aux;
            }
            else
                pos = diretorio.LastIndexOf("Caravamo") + 8;
            aux = diretorio.Substring(pos, diretorio.Length - pos);
            aux = "../.." + aux;
            return aux;

        }





    }

}