using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Veiculo
/// </summary>
public class Veiculo
{
    private string vei_placa;
    private string vei_crlv;
    private string vei_tipo;
    private string mod_modelo;
    private string mod_marca;
    private string acessorio;
    private int mod_id;
    private int vei_ano;
    private int vei_assentos;
    private int emp_id;

    public string Vei_placa
    {
        get
        {
            return vei_placa;
        }

        set
        {
            vei_placa = value;
        }
    }

    public string Vei_crlv
    {
        get
        {
            return vei_crlv;
        }

        set
        {
            vei_crlv = value;
        }
    }

    public string Vei_tipo
    {
        get
        {
            return vei_tipo;
        }

        set
        {
            vei_tipo = value;
        }
    }

    public string Mod_modelo
    {
        get
        {
            return mod_modelo;
        }

        set
        {
            mod_modelo = value;
        }
    }

    public string Mod_marca
    {
        get
        {
            return mod_marca;
        }

        set
        {
            mod_marca = value;
        }
    }

    public int Mod_id
    {
        get
        {
            return mod_id;
        }

        set
        {
            mod_id = value;
        }
    }

    public int Vei_ano
    {
        get
        {
            return vei_ano;
        }

        set
        {
            vei_ano = value;
        }
    }

    public int Vei_assentos
    {
        get
        {
            return vei_assentos;
        }

        set
        {
            vei_assentos = value;
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

    public string Acessorio
    {
        get
        {
            return acessorio;
        }

        set
        {
            acessorio = value;
        }
    }
}