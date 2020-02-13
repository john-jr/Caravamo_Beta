using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Empresa
/// </summary>
public class Empresa
{
    private string emp_nome;
    private string emp_razaosocial;
    private string emp_cnpj;
    private int emp_notificao;
    private string emp_foto;
    private string numeroartesp;
    private int usu_id;

    public string Emp_nome
    {
        get
        {
            return emp_nome;
        }

        set
        {
            emp_nome = value;
        }
    }

    public string Emp_razaosocial
    {
        get
        {
            return emp_razaosocial;
        }

        set
        {
            emp_razaosocial = value;
        }
    }

   

  

    public string Emp_foto
    {
        get
        {
            return emp_foto;
        }

        set
        {
            emp_foto = value;
        }
    }

    public string Numeroartesp
    {
        get
        {
            return numeroartesp;
        }

        set
        {
            numeroartesp = value;
        }
    }

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

    public int Emp_notificao
    {
        get
        {
            return emp_notificao;
        }

        set
        {
            emp_notificao = value;
        }
    }

    public string Emp_cnpj
    {
        get
        {
            return emp_cnpj;
        }

        set
        {
            emp_cnpj = value;
        }
    }
}