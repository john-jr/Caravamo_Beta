using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Usuario
/// </summary>
public class Usuario
{
    private int usu_id;
    private string usu_email;
    private string usu_senha;

    public int Usu_id
    {
        get
        {
            return usu_id;
        }

        set
        {
            usu_id = value;
        }
    }

    public string Usu_email
    {
        get
        {
            return usu_email;
        }

        set
        {
            usu_email = value;
        }
    }

    public string Usu_senha
    {
        get
        {
            return usu_senha;
        }

        set
        {
            usu_senha = value;
        }
    }
}