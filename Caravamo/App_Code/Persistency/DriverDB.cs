using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de DriverDB
/// </summary>
public class DriverDB
{
    public static int insertDriver(Motorista mot)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "INSERT into motorista(mot_nome, mot_foto ,mot_genero, mot_datanasciment, mot_cpf, mot_cnh, emp_id, tip_id, usu_id) values (?mot_nome, ?foto ,?mot_genero, ?mot_datanasciment, ?mot_cpf, ?mot_cnh, ?emp_id, ?tip_id, ?usu_id);";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?mot_nome", mot.Mot_nome));
            query.Parameters.Add(Mapped.Parameter("?foto",mot.Mot_foto));
            query.Parameters.Add(Mapped.Parameter("?mot_genero", mot.Mot_genero));
            query.Parameters.Add(Mapped.Parameter("?mot_datanasciment", mot.Mot_datadenascimento));
            query.Parameters.Add(Mapped.Parameter("?mot_cpf", mot.Mot_cpf));
            query.Parameters.Add(Mapped.Parameter("?mot_cnh", mot.Mot_cnh));
            query.Parameters.Add(Mapped.Parameter("?emp_id", mot.Mot_emp_id));
            query.Parameters.Add(Mapped.Parameter("?tip_id", mot.Mot_tip_id));
            query.Parameters.Add(Mapped.Parameter("?usu_id", mot.Usu_id));

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

    public static DataSet selectDriver(int id)
    {


        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select motorista.mot_id, motorista.mot_foto as foto  ,motorista.mot_nome, motorista.mot_genero ,motorista.mot_datanasciment  , motorista.emp_id, usuario.usu_email from motorista inner join usuario on motorista.usu_id = usuario.usu_id where emp_id = ?emp_id";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?emp_id", id));



        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static DataSet selectDriver2(int id)
    {


        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select motorista.mot_id,  motorista.mot_nome, motorista.mot_genero ,motorista.mot_datanasciment, usuario.usu_email from motorista inner join usuario on motorista.usu_id = usuario.usu_id where motorista.mot_id = ?mot_id";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?mot_id", id));



        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static string selectDriverNome(int id)
    {


        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select mot_nome as nome from motorista where mot_id = ?mod_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?mod_id", id));



        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return (ds.Tables[0].Rows[0]["nome"].ToString());
    }


    public static int updateDriver(Motorista mot,string email,string id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "update usuario inner join motorista on motorista.usu_id = usuario.usu_id set usu_email = ?usu_email, mot_nome = ?mot_nome, mot_datanasciment = ?mot_datanasciment, mot_genero = ?mot_genero  where mot_id = ?mot_id;";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?mot_nome", mot.Mot_nome));
            query.Parameters.Add(Mapped.Parameter("?mot_genero", mot.Mot_genero));
            query.Parameters.Add(Mapped.Parameter("?mot_datanasciment", mot.Mot_datadenascimento));
            query.Parameters.Add(Mapped.Parameter("?mot_id",id));
            query.Parameters.Add(Mapped.Parameter("?usu_email", email));

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


    public static int deleteDriver(string id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "delete usuario, motorista from usuario, motorista where usuario.usu_id = motorista.usu_id and mot_id = ?mot_id;";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?mot_id", id));
     

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

}