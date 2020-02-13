using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Proposta
/// </summary>
public class Proposta
{
    private int pro_valor;
    private int emp_id;
    private int vei_id;
    private int mot_id;
    private int contraproposta_id;
    private String pro_status;
    private DateTime pro_data;
    private DateTime pro_validade;
    private int car_id;

    public int Pro_valor
    {
        get
        {
            return pro_valor;
        }

        set
        {
            pro_valor = value;
        }
    }

    public int Emp_id
    {
        get
        {
            return emp_id;
        }

        set
        {
            emp_id = value;
        }
    }

    public int Contraproposta_id
    {
        get
        {
            return contraproposta_id;
        }

        set
        {
            contraproposta_id = value;
        }
    }

 

    public DateTime Pro_data
    {
        get
        {
            return pro_data;
        }

        set
        {
            pro_data = value;
        }
    }

    public DateTime Pro_validade
    {
        get
        {
            return pro_validade;
        }

        set
        {
            pro_validade = value;
        }
    }

    public int Car_id
    {
        get
        {
            return car_id;
        }

        set
        {
            car_id = value;
        }
    }

    public int Vei_id
    {
        get
        {
            return vei_id;
        }

        set
        {
            vei_id = value;
        }
    }

    public int Mot_id
    {
        get
        {
            return mot_id;
        }

        set
        {
            mot_id = value;
        }
    }

    public string Pro_status
    {
        get
        {
            return pro_status;
        }

        set
        {
            pro_status = value;
        }
    }
}