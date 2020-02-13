using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Motorista
{
    private string mot_nome;
    private char mot_genero;
    private DateTime mot_datadenascimento;
    private string mot_cpf;
    private string mot_cnh;
    private string mot_foto;
    private int mot_emp_id;
    private int mot_tip_id;
    private int usu_id;

    public string Mot_nome
    {
        get
        {
            return mot_nome;
        }

        set
        {
            mot_nome = value;
        }
    }

    public char Mot_genero
    {
        get
        {
            return mot_genero;
        }

        set
        {
            mot_genero = value;
        }
    }

    public DateTime Mot_datadenascimento
    {
        get
        {
            return mot_datadenascimento;
        }

        set
        {
            mot_datadenascimento = value;
        }
    }

    public string Mot_cpf
    {
        get
        {
            return mot_cpf;
        }

        set
        {
            mot_cpf = value;
        }
    }

    public string Mot_cnh
    {
        get
        {
            return mot_cnh;
        }

        set
        {
            mot_cnh = value;
        }
    }

    public string Mot_foto
    {
        get
        {
            return mot_foto;
        }

        set
        {
            mot_foto = value;
        }
    }

    public int Mot_emp_id
    {
        get
        {
            return mot_emp_id;
        }

        set
        {
            mot_emp_id = value;
        }
    }

    public int Mot_tip_id
    {
        get
        {
            return mot_tip_id;
        }

        set
        {
            mot_tip_id = value;
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