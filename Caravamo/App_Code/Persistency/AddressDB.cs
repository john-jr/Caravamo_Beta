using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de AddressDB
/// </summary>
public class AddressDB
{
    public static DataSet selectAllEstados()
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select uc_uf from uf_e_cidades group by uc_uf order by uc_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static DataSet selectAllCidades(string estado)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select uc_cidade from uf_e_cidades where uc_uf = ?uc_cidade;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?uc_cidade",estado));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static int selectCidadeEstadoId(String cidade,String estado)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select uc_id as id from uf_e_cidades where uc_cidade = ?uc_cidade and uc_uf = ?uc_uf;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);

        command.Parameters.Add(Mapped.Parameter("?uc_cidade", cidade));
        command.Parameters.Add(Mapped.Parameter("?uc_uf", estado));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
    }

    public static int insertEndereco(string bairro,string rua,int id,string tipo)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into endereco(end_bairro, end_rua, end_tipo, uc_id) values (?end_bairro, ?end_rua, ?end_tipo, ?uc_id);";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?end_bairro", bairro));
            query.Parameters.Add(Mapped.Parameter("?end_rua", rua));
            query.Parameters.Add(Mapped.Parameter("?end_tipo", tipo));
            query.Parameters.Add(Mapped.Parameter("?uc_id", id));
         


            query.ExecuteNonQuery();
            conexao.Close();
            conexao.Dispose();
            query.Dispose();

        }
        catch (Exception)
        {
            status = 2;

        }
        return status;
    }

    public static int selectEndereco(string bairro,string rua,int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select end_id as id from endereco where end_bairro = ?end_bairro and end_rua = ?end_rua and uc_id = ?uc_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);

        command.Parameters.Add(Mapped.Parameter("?uc_id", id));
        command.Parameters.Add(Mapped.Parameter("?end_rua", rua));
        command.Parameters.Add(Mapped.Parameter("?end_bairro", bairro));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
    }

    public static int selectEndereco2(string pesquisa)
    {
        pesquisa = "\"%"+pesquisa+"%\"";
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select  uc_id from uf_e_cidades where uc_uf like ?pesquisa or uc_cidade like ?pesquisa ;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);

        command.Parameters.Add(Mapped.Parameter("?pesquisa",pesquisa));
      

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
    }



}