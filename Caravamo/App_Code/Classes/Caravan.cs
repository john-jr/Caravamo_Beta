using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Caravan
/// </summary>
public class Caravan
{
    private string car_titulo;
    private int car_privacidade;
    private string car_descricao;
    private string car_foto;
    private string car_categoria;
    private DateTime horaDeChegada;
    private DateTime horaDeSaída;
    private DateTime horacriacao;
    private int usu_car_criador;

    public string Car_titulo
    {
        get
        {
            return car_titulo;
        }

        set
        {
            car_titulo = value;
        }
    }

    public int Car_privacidade
    {
        get
        {
            return car_privacidade;
        }

        set
        {
            car_privacidade = value;
        }
    }

    public string Car_descricao
    {
        get
        {
            return car_descricao;
        }

        set
        {
            car_descricao = value;
        }
    }

    public string Car_foto
    {
        get
        {
            return car_foto;
        }

        set
        {
            car_foto = value;
        }
    }

    public DateTime HoraDeChegada
    {
        get
        {
            return horaDeChegada;
        }

        set
        {
            horaDeChegada = value;
        }
    }

    public DateTime HoraDeSaída
    {
        get
        {
            return horaDeSaída;
        }

        set
        {
            horaDeSaída = value;
        }
    }

    public int Usu_car_criador
    {
        get
        {
            return usu_car_criador;
        }

        set
        {
            usu_car_criador = value;
        }
    }

    public string Car_categoria
    {
        get
        {
            return car_categoria;
        }

        set
        {
            car_categoria = value;
        }
    }

    public DateTime Horacriacao
    {
        get
        {
            return horacriacao;
        }

        set
        {
            horacriacao = value;
        }
    }
}