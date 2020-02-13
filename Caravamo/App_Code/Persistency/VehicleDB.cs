using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de VehicleDB
/// </summary>
public class VehicleDB
{
    public static int insertModelo(Veiculo vei)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into modelo(mod_marca, mod_nome) values(?mod_marca, ?mod_nome);";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?mod_marca", vei.Mod_marca));
            query.Parameters.Add(Mapped.Parameter("?mod_nome", vei.Mod_modelo));

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

    public static int selectModelo(Veiculo vei)
    {
        int status = 0;
        try
        {
            DataSet ds = new DataSet();
            IDbConnection conexao;
            IDbCommand command;
            IDataAdapter dataAdapter;
            conexao = Mapped.Connection();
            string query = "select mod_id as id from modelo where mod_marca = ?mod_marca and mod_nome = ?mod_nome;";

            command = Mapped.Command(query, conexao);
            dataAdapter = Mapped.Adapter(command);
            command.Parameters.Add(Mapped.Parameter("?mod_marca",vei.Mod_marca));
            command.Parameters.Add(Mapped.Parameter("?mod_nome", vei.Mod_modelo));

            dataAdapter.Fill(ds);
            conexao.Close();
            conexao.Dispose();
            command.Dispose();

            return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
        }
        catch (Exception)
        {
            return status = -1;
        }
    }


    public static string selectVeiculoPlaca(int id)
    {
       
            DataSet ds = new DataSet();
            IDbConnection conexao;
            IDbCommand command;
            IDataAdapter dataAdapter;
            conexao = Mapped.Connection();
            string query = "select vei_placa as placa from veiculos where vei_id = ?vei_id;";

            command = Mapped.Command(query, conexao);
            dataAdapter = Mapped.Adapter(command);
            command.Parameters.Add(Mapped.Parameter("?vei_id", id));
           

            dataAdapter.Fill(ds);
            conexao.Close();
            conexao.Dispose();
            command.Dispose();

            return ds.Tables[0].Rows[0]["placa"].ToString();
        
    }


    public static int insertVeiculo(Veiculo vei, int id_modelo)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into veiculos (vei_placa, vei_crlv, vei_tipo, mod_id, vei_ano, vei_assentos, emp_id) values (?vei_placa, ?vei_crlv, ?vei_tipo, ?mod_id, ?vei_ano, ?vei_assentos, ?emp_id);";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?vei_placa", vei.Vei_placa));
            query.Parameters.Add(Mapped.Parameter("?vei_crlv", vei.Vei_crlv));
            query.Parameters.Add(Mapped.Parameter("?vei_tipo", vei.Vei_tipo));
            query.Parameters.Add(Mapped.Parameter("?mod_id", id_modelo));
            query.Parameters.Add(Mapped.Parameter("?vei_ano", vei.Vei_ano));
            query.Parameters.Add(Mapped.Parameter("?vei_assentos", vei.Vei_assentos));
            query.Parameters.Add(Mapped.Parameter("?emp_id", vei.Emp_id));



            query.ExecuteNonQuery();
            conexao.Close();
            conexao.Dispose();
            query.Dispose();

        }
        catch (Exception ex)
        {
            string a = ex.ToString();
            status = 2;

        }
        return status;
    }


    public static int selectVeiculo(Veiculo vei)
    {
        int status = 0;
        try
        {
            DataSet ds = new DataSet();
            IDbConnection conexao;
            IDbCommand command;
            IDataAdapter dataAdapter;
            conexao = Mapped.Connection();
            string query = "select vei_id as id from veiculos where vei_placa = ?vei_placa and vei_crlv = ?vei_crlv and vei_tipo = ?vei_tipo and vei_ano = ?vei_ano and vei_assentos = ?vei_assentos and emp_id = ?emp_id";

            command = Mapped.Command(query, conexao);
            dataAdapter = Mapped.Adapter(command);

            command.Parameters.Add(Mapped.Parameter("?vei_placa", vei.Vei_placa));
            command.Parameters.Add(Mapped.Parameter("?vei_crlv", vei.Vei_crlv));
            command.Parameters.Add(Mapped.Parameter("?vei_tipo", vei.Vei_tipo));
            command.Parameters.Add(Mapped.Parameter("?vei_ano", vei.Vei_ano));
            command.Parameters.Add(Mapped.Parameter("?vei_assentos", vei.Vei_assentos));
            command.Parameters.Add(Mapped.Parameter("?emp_id", vei.Emp_id));


            dataAdapter.Fill(ds);
            conexao.Close();
            conexao.Dispose();
            command.Dispose();

            return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
        }
        catch (Exception ex)
        {
          
            return status = -1;
        }

    }

    public static DataSet selectVeiculo2(int id)
    {
        
      
            DataSet ds = new DataSet();
            IDbConnection conexao;
            IDbCommand command;
            IDataAdapter dataAdapter;
            conexao = Mapped.Connection();
        string query = "select veiculos.vei_assentos, veiculos.vei_id, veiculos.vei_placa, veiculos.vei_tipo, modelo.mod_marca, modelo.mod_nome ,veiculos.vei_ano from veiculos  inner join modelo on  modelo.mod_id = veiculos.mod_id where emp_id = ?emp_id;";

            command = Mapped.Command(query, conexao);
            dataAdapter = Mapped.Adapter(command);
            command.Parameters.Add(Mapped.Parameter("?emp_id",id));
         


            dataAdapter.Fill(ds);
            conexao.Close();
            conexao.Dispose();
            command.Dispose();

            return ds;    
    }


    public static DataSet selectVeiculo3(int id)
    {


        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select veiculos.vei_assentos, veiculos.vei_placa, veiculos.vei_tipo, modelo.mod_marca, modelo.mod_nome ,veiculos.vei_ano from veiculos  inner join modelo on  modelo.mod_id = veiculos.mod_id where vei_id = ?vei_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?vei_id", id));



        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }



    public static DataSet selectAllAcessories()
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "SELECT * FROM acessorios";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }


    public static int existAcessorio(string acessorio)
    {
        int status = 0;
        try
        {
            DataSet ds = new DataSet();
            IDbConnection conexao;
            IDbCommand command;
            IDataAdapter dataAdapter;
            conexao = Mapped.Connection();
            string query = "select count(ace_id) as id from acessorios where ace_nome = ?ace_nome;";

            command = Mapped.Command(query, conexao);
            dataAdapter = Mapped.Adapter(command);

            command.Parameters.Add(Mapped.Parameter("?ace_nome", acessorio));

            dataAdapter.Fill(ds);
            conexao.Close();
            conexao.Dispose();
            command.Dispose();

            return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
        }
        catch (Exception)
        {
            return status = -1;
        }

    }

    public static int selectAcessorio(string acessorio)
    {
        int status = 0;
        try
        {
            DataSet ds = new DataSet();
            IDbConnection conexao;
            IDbCommand command;
            IDataAdapter dataAdapter;
            conexao = Mapped.Connection();
            string query = "select ace_id as id from acessorios where ace_nome = ?ace_nome;";

            command = Mapped.Command(query, conexao);
            dataAdapter = Mapped.Adapter(command);

            command.Parameters.Add(Mapped.Parameter("?ace_nome", acessorio));

            dataAdapter.Fill(ds);
            conexao.Close();
            conexao.Dispose();
            command.Dispose();

            return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
        }
        catch (Exception)
        {
            return status = -1;
        }

    }


    public static int insertAcessorio(string acessorio)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into acessorios (ace_nome) values (?ace_nome);";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?ace_nome", acessorio));
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

    public static int insertVeiculo_Acessorio(int id,int id2)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into veiculo_acessorio(vei_id, ace_id) values(?vei_id, ?ace_id);";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?vei_id", id));
            query.Parameters.Add(Mapped.Parameter("?ace_id", id2));



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

    public static int updateVeiculo(Veiculo vei, string id)
    {
        int status = 0;
        try
        {
            DataSet ds = new DataSet();
            IDbConnection conexao;
            IDbCommand command;
            IDataAdapter dataAdapter;
            conexao = Mapped.Connection();
            string query = "update veiculos set vei_ano = ?vei_ano, vei_placa = ?vei_placa, vei_tipo = ?vei_tipo, vei_assentos = ?vei_assentos, mod_id = ?mod_id where vei_id = ?vei_id; ";

            command = Mapped.Command(query, conexao);
            dataAdapter = Mapped.Adapter(command);

            command.Parameters.Add(Mapped.Parameter("?vei_placa", vei.Vei_placa));
            command.Parameters.Add(Mapped.Parameter("?mod_id", vei.Mod_id));
            command.Parameters.Add(Mapped.Parameter("?vei_tipo", vei.Vei_tipo));
            command.Parameters.Add(Mapped.Parameter("?vei_ano", vei.Vei_ano));
            command.Parameters.Add(Mapped.Parameter("?vei_assentos", vei.Vei_assentos));
            command.Parameters.Add(Mapped.Parameter("?vei_id", id));


            dataAdapter.Fill(ds);
            conexao.Close();
            conexao.Dispose();
            command.Dispose();

            return status;
        }
        catch (Exception ex)
        {

            return status = -1;
        }

    }

    public static int deleteVeiculo(string id)
    {
        int status = 0;
        try
        {
            DataSet ds = new DataSet();
            IDbConnection conexao;
            IDbCommand command;
            IDataAdapter dataAdapter;
            conexao = Mapped.Connection();
            string query = "delete from veiculos where vei_id = ?vei_id;";

            command = Mapped.Command(query, conexao);
            dataAdapter = Mapped.Adapter(command);
            command.Parameters.Add(Mapped.Parameter("?vei_id", id));


            dataAdapter.Fill(ds);
            conexao.Close();
            conexao.Dispose();
            command.Dispose();

            return status;
        }
        catch (Exception ex)
        {   
            return status = -1;
        }

    }


    public static int deleteVeiculo_Acessorio_Relation(string id)
    {
        int status = 0;
        try
        {
            DataSet ds = new DataSet();
            IDbConnection conexao;
            IDbCommand command;
            IDataAdapter dataAdapter;
            conexao = Mapped.Connection();
            string query = "delete from veiculo_acessorio where vei_id = ?vei_id;";

            command = Mapped.Command(query, conexao);
            dataAdapter = Mapped.Adapter(command);
            command.Parameters.Add(Mapped.Parameter("?vei_id", id));


            dataAdapter.Fill(ds);
            conexao.Close();
            conexao.Dispose();
            command.Dispose();

            return status;
        }
        catch (Exception ex)
        {     
            return status = -1;
        }

    }


}
