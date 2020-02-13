using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Pessoa
/// </summary>
public class Pessoa
{
    private int cli_id;
    private string cli_nome;
    private int cli_cpf;
    private DateTime cli_datanascimento;
    private char cli_genero;
    private string cli_foto;
    private string cli_email;
    private string cli_celular;
    private string cli_telefone;
    private int tip_id;
    private int end_id;
    private int usu_id;

    public int Cli_id
    {
        get
        {
            return cli_id;
        }

        set
        {
            cli_id = value;
        }
    }

    public string Cli_nome
    {
        get
        {
            return cli_nome;
        }

        set
        {
            cli_nome = value;
        }
    }

    public int Cli_cpf
    {
        get
        {
            return cli_cpf;
        }

        set
        {
            cli_cpf = value;
        }
    }

    public DateTime Cli_datanascimento
    {
        get
        {
            return cli_datanascimento;
        }

        set
        {
            cli_datanascimento = value;
        }
    }

    public char Cli_genero
    {
        get
        {
            return cli_genero;
        }

        set
        {
            cli_genero = value;
        }
    }

    public string Cli_foto
    {
        get
        {
            return cli_foto;
        }

        set
        {
            cli_foto = value;
        }
    }

    public string Cli_email
    {
        get
        {
            return cli_email;
        }

        set
        {
            cli_email = value;
        }
    }

    public string Cli_celular
    {
        get
        {
            return cli_celular;
        }

        set
        {
            cli_celular = value;
        }
    }

    public string Cli_telefone
    {
        get
        {
            return cli_telefone;
        }

        set
        {
            cli_telefone = value;
        }
    }

    public int Tip_id
    {
        get
        {
            return tip_id;
        }

        set
        {
            tip_id = value;
        }
    }

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
}