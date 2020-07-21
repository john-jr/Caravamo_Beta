using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;

/// <summary>
/// Descrição resumida de CompanyDB
/// </summary>
public class CompanyDB
{
    public static int selectEmpresa(String id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select count(*) as existe from empresa where usu_id = ?usu_id ;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?usu_id", id));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return Convert.ToInt32(ds.Tables[0].Rows[0]["existe"].ToString());
    }

    public static int selectEmpresa2(String id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select emp_id as id from empresa where usu_id = ?usu_id ;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?usu_id", id));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
    }

    public static String selectEmpresa3(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select emp_nome as nome from empresa where emp_id = ?emp_id ;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?emp_id",id));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds.Tables[0].Rows[0]["nome"].ToString();
    }

    public static DataSet selectEmpresa4(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select empresa.emp_nome, empresa.emp_razaosocial, usuario.usu_email, usuario.usu_senha from empresa inner join usuario on empresa.usu_id = usuario.usu_id where emp_id = ?emp_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?emp_id", id));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static int UpdateNomeFantasia(string nomefantasia,int id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "update empresa set emp_nome = ?emp_nome where emp_id = ?emp_id;";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?emp_nome", nomefantasia));
            query.Parameters.Add(Mapped.Parameter("?emp_id", id));
            
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

    public static int UpdateRazaoSocial(string razaoSocial, int id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "update empresa set emp_razaosocial = ?emp_nome where emp_id = ?emp_id;";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?emp_nome", razaoSocial));
            query.Parameters.Add(Mapped.Parameter("?emp_id", id));

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




    public static int UpdateEmail(string email, int id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "update usuario inner join empresa on empresa.usu_id = usuario.usu_id set usu_email = ?usu_email where emp_id = ?emp_id;";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?usu_email",email));
            query.Parameters.Add(Mapped.Parameter("?emp_id", id));

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

    public static int UpdateSenha(string senha, int id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "update usuario inner join empresa on empresa.usu_id = usuario.usu_id set usu_senha = ?usu_senha where emp_id = ?emp_id;";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?usu_senha",senha));
            query.Parameters.Add(Mapped.Parameter("?emp_id", id));

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

    public static int MakePropostas(Proposta p)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into proposta (pro_valor, emp_id, pro_status, pro_data) values (?pro_valor, ?emp_id, ?pro_status, ?pro_data); select last_insert_id() as id";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?emp_id", p.Emp_id));
            query.Parameters.Add(Mapped.Parameter("?pro_valor", p.Pro_valor));
            query.Parameters.Add(Mapped.Parameter("?pro_status", p.Pro_status));
            query.Parameters.Add(Mapped.Parameter("?pro_data", p.Pro_data));

           status  = Convert.ToInt32(query.ExecuteScalar());
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

    public static int insertProposta_has_Motorista(Proposta p,int id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into proposta_tem_motorista (proposta_pro_id, motorista_mot_id) values (?pro_id, ?mot_id);";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?pro_id", id));
            query.Parameters.Add(Mapped.Parameter("?mot_id", p.Mot_id));

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

    public static int insertProposta_has_Veiculo(Proposta p, int id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into proposta_tem_veiculos (proposta_pro_id, veiculos_vei_id) values (?pro_id, ?vei_id);";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?pro_id", id));
            query.Parameters.Add(Mapped.Parameter("?vei_id", p.Vei_id));

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

     public static int insertCaravana_has_Proposta(Proposta p, int id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into caravana_tem_proposta (caravana_car_id, proposta_pro_id) values (?car_id, ?pro_id);";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?pro_id", id));
            query.Parameters.Add(Mapped.Parameter("?car_id", p.Car_id));

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


    public static DataSet SelectPropostasFeitas(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select proposta.pro_id as id, proposta.pro_valor as Valor, mot_nome as NomeMotorista, vei_placa as Placa, mod_marca as Marca, mod_nome as Modelo, proposta.pro_status as StatusProposta,proposta.con_id as ContraProposta,proposta.pro_data as dataDeEnvio, caravana.car_id ,caravana.car_titulo as titulo, caravana.car_datahorachegada as DataHoraRetorno, caravana.car_datahorasaida as DataHoraSaida,  group_concat(DISTINCT en.end_bairro) as bairro, group_concat(DISTINCT en.end_rua) as rua, group_concat(DISTINCT en.end_tipo) as tipoEnd ,group_concat(DISTINCT ufcity.uc_uf) as uf, group_concat(DISTINCT ufcity.uc_cidade) as cidade from empresa inner join proposta on proposta.emp_id = empresa.emp_id inner join caravana_tem_proposta as chp on chp.proposta_pro_id = proposta.pro_id inner join caravana on caravana.car_id = chp.caravana_car_id inner join caravana_tem_endereco as cha on cha.caravana_car_id = caravana.car_id inner join endereco as en on cha.endereco_end_id = end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id inner join proposta_tem_motorista as phm on phm.proposta_pro_id = proposta.pro_id inner join motorista on mot_id =phm.motorista_mot_id inner join proposta_tem_veiculos as phv on proposta.pro_id = phv.proposta_pro_id inner join veiculos on phv.veiculos_vei_id = veiculos.vei_id inner join modelo on veiculos.mod_id = modelo.mod_id where empresa.emp_id = ?emp_id group by car_datadecriação;;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?emp_id", id));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static DataSet SelectPropostasFeitas2(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select proposta.pro_id as id, proposta.pro_valor as Valor, mot_nome as NomeMotorista, vei_placa as Placa, mod_marca as Marca, mod_nome as Modelo, proposta.pro_status as StatusProposta,proposta.con_id as ContraProposta,proposta.pro_data as dataDeEnvio, caravana.car_id ,caravana.car_titulo as titulo, caravana.car_datahorachegada as DataHoraRetorno, caravana.car_datahorasaida as DataHoraSaida,  group_concat(DISTINCT en.end_bairro) as bairro, group_concat(DISTINCT en.end_rua) as rua, group_concat(DISTINCT en.end_tipo) as tipoEnd ,group_concat(DISTINCT ufcity.uc_uf) as uf, group_concat(DISTINCT ufcity.uc_cidade) as cidade from empresa inner join proposta on proposta.emp_id = empresa.emp_id inner join caravana_tem_proposta as chp on chp.proposta_pro_id = proposta.pro_id inner join caravana on caravana.car_id = chp.caravana_car_id inner join caravana_tem_endereco as cha on cha.caravana_car_id = caravana.car_id inner join endereco as en on cha.endereco_end_id = end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id inner join proposta_tem_motorista as phm on phm.proposta_pro_id = proposta.pro_id inner join motorista on mot_id =phm.motorista_mot_id inner join proposta_tem_veiculos as phv on proposta.pro_id = phv.proposta_pro_id inner join veiculos on phv.veiculos_vei_id = veiculos.vei_id inner join modelo on veiculos.mod_id = modelo.mod_id where empresa.emp_id = ?emp_id and caravana.car_idempcriador is null or caravana.car_idempcriador <> ?emp_id group by car_datadecriação limit 3;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?emp_id", id));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }


    public static DataSet SelectThisProposta(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select proposta.pro_id as id, proposta.pro_valor as Valor, mot_nome as NomeMotorista, mot_datanasciment as DataNascimento, vei_placa as Placa, vei_ano as ano, mod_marca as Marca, mod_nome as Modelo, proposta.pro_status as StatusProposta,proposta.con_id as ContraProposta,proposta.pro_data as dataDeEnvio, caravana.car_id ,caravana.car_titulo as titulo, caravana.car_datahorachegada as DataHoraRetorno, caravana.car_datahorasaida as DataHoraSaida,  group_concat(DISTINCT en.end_bairro) as bairro, group_concat(DISTINCT en.end_rua) as rua, group_concat(DISTINCT en.end_tipo) as tipoEnd ,group_concat(DISTINCT ufcity.uc_uf) as uf, group_concat(DISTINCT ufcity.uc_cidade) as cidade from empresa inner join proposta on proposta.emp_id = empresa.emp_id inner join caravana_tem_proposta as chp on chp.proposta_pro_id = proposta.pro_id inner join caravana on caravana.car_id = chp.caravana_car_id inner join caravana_tem_endereco as cha on cha.caravana_car_id = caravana.car_id inner join endereco as en on cha.endereco_end_id = end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id inner join proposta_tem_motorista as phm on phm.proposta_pro_id = proposta.pro_id inner join motorista on mot_id =phm.motorista_mot_id inner join proposta_tem_veiculos as phv on proposta.pro_id = phv.proposta_pro_id inner join veiculos on phv.veiculos_vei_id = veiculos.vei_id inner join modelo on veiculos.mod_id = modelo.mod_id where proposta.pro_id = ?pro_id group by car_datadecriação;;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?pro_id", id));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static int UpdateProposta(string statu, int id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "update proposta set pro_status = '"+ statu +"' where pro_id = ?pro_id;";
            query = Mapped.Command(command, conexao);

         
            query.Parameters.Add(Mapped.Parameter("?pro_id",id ));

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