using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home_emp : System.Web.UI.Page
{
    static Boolean firstload = true;
    static String name;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(firstload == true)
        {
            firstload = false;
            int aux =(int)Session["id"];
            name =(CompanyDB.selectEmpresa3(aux));
            
        }
        lbl_nomeEmp.Text = name; 
    }
}