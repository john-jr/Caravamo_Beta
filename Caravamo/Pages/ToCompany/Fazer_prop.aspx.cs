﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Fazer_prop : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        DataSet ds = VehicleDB.selectVeiculo2(Convert.ToInt32(Session["id"]));
        string ltl_status = "";
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            Literal top = new Literal();
            Literal bottom = new Literal();
            ltl_status += "  <div class='container col-xl-3 col-lg-4 col-md-6 col-sm-12 mb-4'>";
            top.Text = ltl_status;
            ltl_status = "";
            LinkButton veiculo = new LinkButton(); ;
            veiculo.Text = "<div class='container'><div class='card bg-light border-dark auxiliar'><div class='card-body'><img src = '../../img/1498585513-sprinter-415-van-15-1-k42e--b-.jpg' /> </div > <div class='card-footer text-center'> <p><h4>" + dr["vei_placa"] + "<h4> </p> </div>  </div> </div>";
            veiculo.Click += new System.EventHandler(this.carroEsse_Click);
            veiculo.ID = "V" + dr["vei_id"].ToString();
            ltl_status += "</div>";
            bottom.Text = ltl_status;
            ltl_status = "";
            phl_vehicle.Controls.Add(top);
            phl_vehicle.Controls.Add(veiculo);
            phl_vehicle.Controls.Add(bottom);
        }

    }

    void carroEsse_Click(object sender, EventArgs e)
    {
        LinkButton button = (LinkButton)sender;
        string buttonId = button.ID;
      

        foreach (Control control in phl_vehicle.Controls)
        {
           
            if (control is LinkButton)
            {
                if (((LinkButton)control).ID == buttonId)
                {
                    ((LinkButton)control).CssClass = "selected";
                }
                else
                {
                    ((LinkButton)control).CssClass = "";
                }


            }
        }
        buttonId = Regex.Replace(buttonId, "[^0-9.]", "");
        lbl_id.Text = buttonId;

    }


    protected void Page_Load(object sender, EventArgs e)
    {
        string aux = Session["auxiliar"].ToString();
        string id = Regex.Replace(aux, "[^0-9.]", "");
        lbl_idCar.Text = id;
        aux = Regex.Replace(aux, @"[\d-]", string.Empty); ;
        ltl_auxiliar.Text = "<h2>Proposta para: "+ aux+"</h2>";
    }

    protected void btnAvancar1_Click(object sender, EventArgs e)
    {
        Proposta pro = new Proposta();
        String[] nomes = new string[2];
        pro.Emp_id = Convert.ToInt32(Session["id"]);
        pro.Car_id = Convert.ToInt32 (lbl_idCar.Text);
        pro.Vei_id = Convert.ToInt32(lbl_id.Text);
        Session["cadastro"] = pro;
        Response.Redirect("Fazer_prop2.aspx");
    }

    protected void btn_cancelar_Click(object sender, EventArgs e)
    {
        Session["cadastro"] = null;
        Session["auxiliar"] = null;
        Response.Redirect("Requisicoes.aspx");
    }
}