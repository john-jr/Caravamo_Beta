using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ToUser_Create_Caravan : System.Web.UI.Page
{
    void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["id"] == null && Session["cliente"] == null)
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
        if (Session["cliente"].Equals(true))
        {
           
            ltl_privacidade.Text = "<p>Apenas Convidados</p>";
        }
        if (Session["empresa"].Equals(true))
        {
           
            ltl_privacidade.Text = "<p>Aberta ao Público</p>";
        }
    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        CriarDiretorio();
        Caravan car = new Caravan();
        car.Car_titulo = txt_tituloCaravana.Text;
        car.Car_descricao = txt_descricao.Text;
        car.Car_foto = UploadArquivo(fu_foto, fu_foto.FileName);

        if (Session["cliente"].Equals(true))
        {
            car.Car_privacidade = 1;
           
        }
        if (Session["empresa"].Equals(true))
        {
            car.Car_privacidade = 0;
           
        }


        Session["cadastro"] = car;
        Response.Redirect("Create_Caravan_2.aspx");
    }


    public static bool CriarDiretorio()
    {
        string dir = HttpContext.Current.Request.PhysicalApplicationPath + "Uploads\\Caravanas\\";
        if (!Directory.Exists(dir))
        {
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
        string diretorio = HttpContext.Current.Request.PhysicalApplicationPath + "Uploads\\Caravanas\\" + nome;
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

    protected void btn_cancelar_Click(object sender, EventArgs e)
    {
        Session["cadastro"] = null;
        Session["auxiliar"] = null;
        if (Session["empresa"].Equals(true))
        {
            Response.Redirect("../ToCompany/Home_emp.aspx");
        }
        else { 
            Response.Redirect("Home_User.aspx");
        }
    }
}