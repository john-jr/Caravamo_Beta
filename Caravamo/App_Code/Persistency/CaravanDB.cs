using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CaravanDB
/// </summary>
public class CaravanDB
{
    public static DataSet selectAllCategorias()
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "SELECT * FROM categoria";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static int  insertCaravan(Caravan car)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into Caravana(car_titulo, car_privacidade, car_descricao, car_datahorachegada, car_datahorasaida, car_idcriador, car_datadecriação) values (?car_titulo, ?car_privacidade, ?car_descricao, ?car_datahorachegada, ?car_datahorasaida, ?car_idcriador, ?car_datadecriação);";
            query = Mapped.Command(command, conexao);
            car.Horacriacao = DateTime.UtcNow;

            query.Parameters.Add(Mapped.Parameter("?car_titulo", car.Car_titulo));
            query.Parameters.Add(Mapped.Parameter("?car_privacidade", car.Car_privacidade));
            query.Parameters.Add(Mapped.Parameter("?car_descricao", car.Car_descricao));
            query.Parameters.Add(Mapped.Parameter("?car_datahorachegada",car.HoraDeChegada));
            query.Parameters.Add(Mapped.Parameter("?car_datahorasaida", car.HoraDeSaída));
            query.Parameters.Add(Mapped.Parameter("?car_idcriador", car.Usu_car_criador));
            query.Parameters.Add(Mapped.Parameter("?car_datadecriação", car.Horacriacao));


            query.ExecuteNonQuery();
            conexao.Close();
            conexao.Dispose();
            query.Dispose();

        }
        catch (Exception e)
        {
            string a = e.ToString();
            status = 2;

        }
        return status;
    }

    public static int selectCaravan(Caravan car)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select car_id as id from Caravana where car_titulo = ?car_titulo and car_privacidade = ?car_privacidade and car_descricao = ?car_descricao and car_datahorachegada = ?car_datahorachegada and car_datahorasaida = ?car_datahorasaida and car_idcriador = ?car_idcriador;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_titulo", car.Car_titulo));
        command.Parameters.Add(Mapped.Parameter("?car_privacidade", car.Car_privacidade));
        command.Parameters.Add(Mapped.Parameter("?car_descricao", car.Car_descricao));
        command.Parameters.Add(Mapped.Parameter("?car_datahorachegada", car.HoraDeChegada));
        command.Parameters.Add(Mapped.Parameter("?car_datahorasaida", car.HoraDeSaída));
        command.Parameters.Add(Mapped.Parameter("?car_idcriador", car.Usu_car_criador));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
    }




    public static DataSet selectCaravanCriador(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select c.car_id, c.car_titulo, c.car_privacidade, c.car_datahorachegada, c.car_datahorasaida, en.end_bairro, en.end_rua, en.end_tipo ,ufcity.uc_uf, ufcity.uc_cidade  from caravana as c inner join caravana_tem_endereco as che on c.car_id = che.caravana_car_id inner join endereco as en on che.endereco_end_id = en.end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id where c.car_idcriador = ?car_idcriador;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);   
        command.Parameters.Add(Mapped.Parameter("?car_idcriador",id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }


    public static int selectCategoria(string cnome)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select cat_id as id from categoria where cat_nome = ?cat_nome;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?cat_nome", cnome));
     


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
    }

    public static int insertCaravan_has_Category(int car_id, int cat_id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into Caravana_tem_Categoria (caravana_car_id, categoria_cat_id) values (?car_id, ?cat_id);;";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?car_id", car_id));
            query.Parameters.Add(Mapped.Parameter("?cat_id", cat_id));


            query.ExecuteNonQuery();
            conexao.Close();
            conexao.Dispose();
            query.Dispose();

        }
        catch (Exception e)
        {
            status = 2;

        }
        return status;
    }

    public static int insertCaravan_has_Address(int car_id, int end_id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into Caravana_tem_Endereco (caravana_car_id, endereco_end_id) values (?car_id, ?end_id);;";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?car_id", car_id));
            query.Parameters.Add(Mapped.Parameter("?end_id", end_id));


            query.ExecuteNonQuery();
            conexao.Close();
            conexao.Dispose();
            query.Dispose();

        }
        catch (Exception )
        {
            status = 2;

        }
        return status;
    }

    public static DataSet selectCaravanaSemConfirmacao()
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select c.car_id as id from caravana_tem_proposta as ctp inner join Proposta as p on ctp.proposta_pro_id = p.pro_id inner join caravana as c on ctp.caravana_car_id = c.car_id where p.pro_status <> 'Confirmado';";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
    

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static DataSet selectCaravan2(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select c.car_id as id, c.car_titulo as titulo, c.car_privacidade as privacidade, c.car_datahorachegada as dataHoraChegada , c.car_datahorasaida as dataHoraSaida, group_concat(en.end_bairro) as bairro, group_concat(en.end_rua) as rua, group_concat(en.end_tipo) as tipoEnd ,group_concat(ufcity.uc_uf) as uf, group_concat(ufcity.uc_cidade) as cidade  from caravana as c inner join caravana_tem_endereco as che on c.car_id = che.caravana_car_id inner join endereco as en on che.endereco_end_id = en.end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id where c.car_id = ?car_id; ";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_id", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static DataSet selectCaravan3()
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select c.car_id as id from caravana as c;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
      


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static int selectCaravanCountProposta(string id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select count(*) as existe from caravana_tem_proposta as ctp where ctp.caravana_car_id = ?car_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_id", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return Convert.ToInt32(ds.Tables[0].Rows[0]["existe"].ToString());
    }


}