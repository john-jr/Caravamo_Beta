using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de endereco
/// </summary>
public class endereco
{
    private int end_id;
    private string end_uf;
    private string end_cidade;
    private string end_bairro;
    private string end_rua;
    private string end_tipo;
    private string end_cep;
    private string end_num;

    public int End_id
    {
        get
        {
            return end_id;
        }

        set
        {
            end_id = value;
        }
    }

    public string End_uf
    {
        get
        {
            return end_uf;
        }

        set
        {
            end_uf = value;
        }
    }

    public string End_cidade
    {
        get
        {
            return end_cidade;
        }

        set
        {
            end_cidade = value;
        }
    }

    public string End_bairro
    {
        get
        {
            return end_bairro;
        }

        set
        {
            end_bairro = value;
        }
    }

    public string End_rua
    {
        get
        {
            return end_rua;
        }

        set
        {
            end_rua = value;
        }
    }

    public string End_tipo
    {
        get
        {
            return end_tipo;
        }

        set
        {
            end_tipo = value;
        }
    }

    public string End_cep
    {
        get
        {
            return end_cep;
        }

        set
        {
            end_cep = value;
        }
    }

    public string End_num
    {
        get
        {
            return end_num;
        }

        set
        {
            end_num = value;
        }
    }
}