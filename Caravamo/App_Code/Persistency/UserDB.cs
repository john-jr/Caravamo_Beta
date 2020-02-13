using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using System.Security.Cryptography;

public class UserDB
{
    public static int insertClient(Pessoa cliente)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "INSERT INTO cliente(cli_nome, cli_cpf, cli_datanascimento, cli_genero, cli_email, tip_id, usu_id) values ( ?cli_nome, ?cli_cpf, ?cli_datanascimento, ?cli_genero, ?cli_email, ?tip_id, ?usu_id);";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?cli_nome", cliente.Cli_nome));
            query.Parameters.Add(Mapped.Parameter("?cli_cpf", cliente.Cli_cpf));
            query.Parameters.Add(Mapped.Parameter("?cli_datanascimento", cliente.Cli_datanascimento));
            query.Parameters.Add(Mapped.Parameter("?cli_genero", cliente.Cli_genero)); 
            query.Parameters.Add(Mapped.Parameter("?cli_email", cliente.Cli_email));
            query.Parameters.Add(Mapped.Parameter("?tip_id", cliente.Tip_id));
            query.Parameters.Add(Mapped.Parameter("?usu_id", cliente.Usu_id));

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

    public static int insertCompany(Empresa empresa)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "INSERT INTO empresa(emp_nome, emp_razaosocial, emp_cnpj, emp_numeroartesp, usu_id) values (?emp_nome, ?emp_razaosocial, ?emp_cnpj, ?emp_numeroartesp, ?usu_id)";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?emp_nome", empresa.Emp_nome));
            query.Parameters.Add(Mapped.Parameter("?emp_razaosocial", empresa.Emp_razaosocial));
            query.Parameters.Add(Mapped.Parameter("?emp_cnpj", empresa.Emp_cnpj));
            query.Parameters.Add(Mapped.Parameter("?emp_numeroartesp", empresa.Numeroartesp));
            query.Parameters.Add(Mapped.Parameter("?usu_id", empresa.Usu_id));
            query.ExecuteNonQuery();
            conexao.Close();
            conexao.Dispose();
            query.Dispose();

        }
        catch (Exception ex)
        {
            String e = ex.ToString();
            String t = e;
            status = 2;

        }
        return status;
    }


    public static int insertUser(Usuario user )
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "INSERT INTO usuario(usu_email, usu_senha) VALUES (?usu_email, ?usu_senha);";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?usu_email", user.Usu_email));
            query.Parameters.Add(Mapped.Parameter("?usu_senha", user.Usu_senha));
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


    public static int selectUser(Usuario user)
    {
        try
        {
            DataSet ds = new DataSet();
            IDbConnection conexao;
            IDbCommand command;
            IDataAdapter dataAdapter;
            conexao = Mapped.Connection();
            string query = "select usu_id as id from usuario where usu_senha = ?usu_senha and usu_email = ?usu_email;";

             command = Mapped.Command(query, conexao);
            dataAdapter = Mapped.Adapter(command);
            command.Parameters.Add(Mapped.Parameter("?usu_senha", user.Usu_senha));
            command.Parameters.Add(Mapped.Parameter("?usu_email", user.Usu_email));


            dataAdapter.Fill(ds);
            conexao.Close();
            conexao.Dispose();
            command.Dispose();

            if (Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString()) > 0) {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
            }
            else
            {
                return 0;
            }

            
        } catch (Exception)
        {
            return 0;
        }


    }

    public static Boolean selectUser2(string email)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select count(*) as existe from usuario where usu_email = ?usu_email;";
        Usuario auxu = new Usuario();
       

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?usu_email", email));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        if(Convert.ToInt32(ds.Tables[0].Rows[0]["existe"].ToString()) == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }


    public static int selectUser3(String id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select count(*) as existe from cliente where usu_id = ?usu_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?usu_id", id));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return Convert.ToInt32(ds.Tables[0].Rows[0]["existe"].ToString());
    }

    public static int selectUser4(String id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select cli_id as id from cliente where usu_id = ?usu_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?usu_id", id));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
    }

    public static string select_CompanyUserPassword(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select usu_senha as senha from usuario inner join empresa on empresa.usu_id = usuario.usu_id where empresa.emp_id = ?emp_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?emp_id", id));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds.Tables[0].Rows[0]["senha"].ToString();
    }

    public static DataSet select_Client(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select cliente.cli_nome, cliente.cli_email, usuario.usu_senha from cliente inner join usuario on cliente.usu_id = usuario.usu_id where cliente.cli_id = ?cli_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?cli_id", id));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }



    public static string select_ClientUserPassword(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select usu_senha as senha from usuario inner join cliente on cliente.usu_id = usuario.usu_id where cliente.cli_id = ?cli_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?cli_id", id));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds.Tables[0].Rows[0]["senha"].ToString();
    }


    public static String Criptografia(string pwd)
    {
        UnicodeEncoding UE = new UnicodeEncoding();
        byte[] HashValue, MessageBytes = UE.GetBytes(pwd);
        SHA512Managed SHhash = new SHA512Managed();
        string strHex = "";

        HashValue = SHhash.ComputeHash(MessageBytes);
        foreach (byte b in HashValue)
        {
            strHex += String.Format("{0:x2}", b);
        }
        return strHex;



    }


}