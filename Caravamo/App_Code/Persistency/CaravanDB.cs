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
    public static String selectInviteIdCaravan(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select car_idConvite as idConvite from caravana where car_id = ?car_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
       command.Parameters.Add(Mapped.Parameter("?car_id", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds.Tables[0].Rows[0]["idConvite"].ToString();
    }



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
            string command = "insert into Caravana(car_titulo, car_foto ,car_privacidade, car_descricao, car_datahorachegada, car_datahorasaida, car_idcriador, car_datadecriação, car_idConvite) values (?car_titulo, ?foto ,?car_privacidade, ?car_descricao, ?car_datahorachegada, ?car_datahorasaida, ?car_idcriador, ?car_datadecriação, (uuid()));";
            query = Mapped.Command(command, conexao);
            car.Horacriacao = DateTime.UtcNow;

            query.Parameters.Add(Mapped.Parameter("?car_titulo", car.Car_titulo));
            query.Parameters.Add(Mapped.Parameter("?foto", car.Car_foto));
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


    public static int insertCaravan2(Caravan car)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into Caravana(car_titulo, car_foto ,car_privacidade, car_descricao, car_datahorachegada, car_datahorasaida, car_idempcriador, car_datadecriação, car_idConvite) values (?car_titulo, ?foto ,?car_privacidade, ?car_descricao, ?car_datahorachegada, ?car_datahorasaida, ?car_idcriador, ?car_datadecriação, (uuid()));";
            query = Mapped.Command(command, conexao);
            car.Horacriacao = DateTime.UtcNow;

            query.Parameters.Add(Mapped.Parameter("?car_titulo", car.Car_titulo));
            query.Parameters.Add(Mapped.Parameter("?foto", car.Car_foto));
            query.Parameters.Add(Mapped.Parameter("?car_privacidade", car.Car_privacidade));
            query.Parameters.Add(Mapped.Parameter("?car_descricao", car.Car_descricao));
            query.Parameters.Add(Mapped.Parameter("?car_datahorachegada", car.HoraDeChegada));
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

    public static int selectCaravanEmp(Caravan car)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select car_id as id from Caravana where car_titulo = ?car_titulo and car_privacidade = ?car_privacidade and car_descricao = ?car_descricao and car_datahorachegada = ?car_datahorachegada and car_datahorasaida = ?car_datahorasaida and car_idempcriador = ?car_idcriador;";

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


    public static int selectCaravan4(string id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select car_id as id from Caravana where car_idConvite = ?car_idConvite ";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_idConvite", id));



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

    public static DataSet selectCaravanCriador2(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select car_id as id, car_foto as foto ,group_concat(distinct car_titulo) as titulo, group_concat(distinct car_privacidade) as privacidade, group_concat(distinct car_datahorachegada) as HoraDataChegada, group_concat(distinct car_datahorasaida) as HoraDataSaida,  group_concat(end_bairro) as bairro, group_concat(end_rua) as rua ,group_concat(end_tipo) as tipo , group_concat(uc_uf) as estado,  group_concat(uc_cidade) as cidade  from caravana  as c inner join caravana_tem_endereco as che on c.car_id = che.caravana_car_id inner join endereco as en on che.endereco_end_id = en.end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id where c.car_idcriador = ?car_idcriador group by car_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_idcriador", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static DataSet selectCaravanCriador22(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select car_id as id, group_concat(distinct car_titulo) as titulo, group_concat(distinct car_privacidade) as privacidade, group_concat(distinct car_datahorachegada) as HoraDataChegada, group_concat(distinct car_datahorasaida) as HoraDataSaida,  group_concat(end_bairro) as bairro, group_concat(end_rua) as rua ,group_concat(end_tipo) as tipo , group_concat(uc_uf) as estado,  group_concat(uc_cidade) as cidade  from caravana  as c inner join caravana_tem_endereco as che on c.car_id = che.caravana_car_id inner join endereco as en on che.endereco_end_id = en.end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id where c.car_idcriador = ?car_idcriador group by car_id order by car_datadecriação limit 3;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_idcriador", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static DataSet selectCaravanOtherUsers(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select car_id as id, group_concat(distinct car_titulo) as titulo, group_concat(distinct car_privacidade) as privacidade, group_concat(distinct car_datahorachegada) as HoraDataChegada, group_concat(distinct car_datahorasaida) as HoraDataSaida,  group_concat(end_bairro) as bairro, group_concat(end_rua) as rua ,group_concat(end_tipo) as tipo , group_concat(uc_uf) as estado,  group_concat(uc_cidade) as cidade  from caravana  as c inner join caravana_tem_endereco as che on c.car_id = che.caravana_car_id inner join endereco as en on che.endereco_end_id = en.end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id where c.car_privacidade = 0 group by car_id order by c.car_datadecriação limit 3;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_idcriador", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }


    public static DataSet selectCaravanCriadorbyEmpresa(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "Select car_id as id, car_foto as foto ,group_concat(distinct car_titulo) as titulo, group_concat(distinct car_privacidade) as privacidade, group_concat(distinct car_datahorachegada) as HoraDataChegada, group_concat(distinct car_datahorasaida) as HoraDataSaida,  group_concat(end_bairro) as bairro, group_concat(end_rua) as rua ,group_concat(end_tipo) as tipo , group_concat(uc_uf) as estado,  group_concat(uc_cidade) as cidade  from caravana  as c inner join caravana_tem_endereco as che on c.car_id = che.caravana_car_id inner join endereco as en on che.endereco_end_id = en.end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id where c.car_idempcriador = ?car_idcriador and c.car_datahorasaida > NOW() and c.car_datahorachegada > NOW() group by car_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_idcriador", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static DataSet selectCaravanCriadorbyEmpresa2(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "Select car_id as id, car_foto as foto ,group_concat(distinct car_titulo) as titulo, group_concat(distinct car_privacidade) as privacidade, group_concat(distinct car_datahorachegada) as HoraDataChegada, group_concat(distinct car_datahorasaida) as HoraDataSaida,  group_concat(end_bairro) as bairro, group_concat(end_rua) as rua ,group_concat(end_tipo) as tipo , group_concat(uc_uf) as estado,  group_concat(uc_cidade) as cidade  from caravana  as c inner join caravana_tem_endereco as che on c.car_id = che.caravana_car_id inner join endereco as en on che.endereco_end_id = en.end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id where c.car_idempcriador = ?car_idcriador and c.car_datahorachegada < NOW() and c.car_datahorasaida < NOW()  group by car_id;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_idcriador", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static DataSet selectCaravanCriadorbyEmpresa3(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "Select car_id as id, group_concat(distinct car_titulo) as titulo, group_concat(distinct car_privacidade) as privacidade, group_concat(distinct car_datahorachegada) as HoraDataChegada, group_concat(distinct car_datahorasaida) as HoraDataSaida,  group_concat(end_bairro) as bairro, group_concat(end_rua) as rua ,group_concat(end_tipo) as tipo , group_concat(uc_uf) as estado,  group_concat(uc_cidade) as cidade  from caravana  as c inner join caravana_tem_endereco as che on c.car_id = che.caravana_car_id inner join endereco as en on che.endereco_end_id = en.end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id where c.car_idempcriador = ?car_idcriador and c.car_datahorachegada < NOW() and c.car_datahorasaida < NOW()  group by car_id limit 3;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_idcriador", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }



    public static DataSet selectCaravanInscrito(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select c.car_id as id, car_foto as foto ,group_concat(distinct car_titulo) as titulo, group_concat(distinct car_privacidade) as privacidade, group_concat(distinct car_datahorachegada) as HoraDataChegada, group_concat(distinct car_datahorasaida) as HoraDataSaida,  group_concat(end_bairro) as bairro, group_concat(end_rua) as rua ,group_concat(end_tipo) as tipo , group_concat(uc_uf) as estado,  group_concat(uc_cidade) as cidade  from caravana as c inner join caravana_tem_endereco as che on c.car_id = che.caravana_car_id inner join endereco as en on che.endereco_end_id = en.end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id inner join cliente_caravana_status as ccs on c.car_id = ccs.car_id and ccs.cli_id = ?car_idcriador where c.car_idcriador != ?car_idcriador and ccs.css_status = 'Inscrito';";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_idcriador", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }


    public static DataSet selectEmpresaResp(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select mot_nome as nomeMotorista, mot_genero as sexo, mot_datanasciment as DataNascimentoMotorista, pro_valor as ValorTotal, emp_nome as EmpresaResponsavel, pro.emp_id as IdEmpresaResponsavel, vei_placa as PlacaVeiculo, vei_ano as AnoVeiculo, vei_tipo as TipoVeiculo, vei_assentos as QntAssentos ,mod_marca as marca, mod_nome as modelo ,group_concat(ace_nome) as acessorios  from caravana_tem_proposta as chp inner join proposta as pro on pro.pro_id = chp.proposta_pro_id inner join empresa on pro.emp_id = empresa.emp_id inner join proposta_tem_veiculos as phv on pro.pro_id = phv.proposta_pro_id  inner join veiculos on phv.veiculos_vei_id = veiculos.vei_id inner join proposta_tem_motorista as phm on phm.proposta_pro_id = pro.pro_id inner join motorista on phm.motorista_mot_id = motorista.mot_id inner join veiculo_acessorio as va on va.vei_id = veiculos.vei_id inner join acessorios on va.ace_id = acessorios.ace_id inner join Modelo on veiculos.mod_id = Modelo.mod_id where caravana_car_id = ?car_idcaravana and pro_status = 'Aceito';";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_idcaravana", id));

        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }


        public static DataSet selectThisCaravanCli(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select c.car_id as id, c.car_foto as foto ,c.car_titulo as titulo, cli_nome as nomeCriador ,c.car_privacidade as privacidade, group_concat(DISTINCT categoria.cat_nome) as categorias, c.car_descricao as descricao  ,c.car_datahorachegada as dataHoraChegada , c.car_datahorasaida as dataHoraSaida, group_concat(DISTINCT en.end_bairro) as bairro, group_concat(DISTINCT en.end_rua) as rua, group_concat(DISTINCT en.end_tipo) as tipoEnd ,group_concat(DISTINCT ufcity.uc_uf) as uf, group_concat(DISTINCT ufcity.uc_cidade) as cidade  from caravana as c inner join caravana_tem_endereco as che on c.car_id = che.caravana_car_id inner join endereco as en on che.endereco_end_id = en.end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id inner join cliente as cli on car_idcriador = cli_id inner join caravana_tem_categoria as chc on chc.caravana_car_id = c.car_id inner join categoria as categoria on chc.categoria_cat_id = categoria.cat_id where c.car_id = ?car_idcaravana;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_idcaravana", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static DataSet selectThisCaravanCli2(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select c.car_id as id, c.car_titulo as titulo, c.car_foto as foto , emp_nome as nomeCriador ,c.car_privacidade as privacidade, group_concat(DISTINCT categoria.cat_nome) as categorias, c.car_descricao as descricao  ,c.car_datahorachegada as dataHoraChegada , c.car_datahorasaida as dataHoraSaida, group_concat(DISTINCT en.end_bairro) as bairro, group_concat(DISTINCT en.end_rua) as rua, group_concat(DISTINCT en.end_tipo) as tipoEnd ,group_concat(DISTINCT ufcity.uc_uf) as uf, group_concat(DISTINCT ufcity.uc_cidade) as cidade  from caravana as c inner join caravana_tem_endereco as che on c.car_id = che.caravana_car_id inner join endereco as en on che.endereco_end_id = en.end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id inner join empresa as emp on car_idempcriador = emp_id inner join caravana_tem_categoria as chc on chc.caravana_car_id = c.car_id inner join categoria as categoria on chc.categoria_cat_id = categoria.cat_id where c.car_id = ?car_idcaravana;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_idcaravana", id));


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
        string query = "select c.car_id as id, c.car_foto as foto ,c.car_titulo as titulo, c.car_privacidade as privacidade, c.car_datahorachegada as dataHoraChegada , c.car_datahorasaida as dataHoraSaida, group_concat(en.end_bairro) as bairro, group_concat(en.end_rua) as rua, group_concat(en.end_tipo) as tipoEnd ,group_concat(ufcity.uc_uf) as uf, group_concat(ufcity.uc_cidade) as cidade  from caravana as c inner join caravana_tem_endereco as che on c.car_id = che.caravana_car_id inner join endereco as en on che.endereco_end_id = en.end_id inner join uf_e_cidades as ufcity on en.uc_id = ufcity.uc_id where c.car_id = ?car_id ; ";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_id", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static DataSet selectCaravan22()
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select c.car_id as id from caravana as c order by c.car_datadecriação DESC limit 3; ";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);



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
        string query = "select count(*) as existe from caravana_tem_proposta as ctp inner join proposta on ctp.proposta_pro_id = proposta.pro_id where ctp.caravana_car_id = ?car_id and pro_status = 'Aceito' ;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_id", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return Convert.ToInt32(ds.Tables[0].Rows[0]["existe"].ToString());
    }

    public static DataSet selectPropostas(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select pro_id as idProposta , pro_data as DataEnvio ,min(pro_valor) as valor, emp_nome as NomeEmpresa, mot_nome as nomeMotorista, vei_tipo as TipoVeiculo, mod_marca as Modelo, mod_nome as Marca, vei_ano as Ano, vei_assentos as qntAssentos from caravana join caravana_tem_proposta as chp on car_id = chp.caravana_car_id join proposta on chp.proposta_pro_id = pro_id join empresa  on proposta.emp_id = empresa.emp_id join proposta_tem_motorista as phm on phm.proposta_pro_id = proposta.pro_id join motorista on phm.motorista_mot_id = motorista.mot_id join proposta_tem_veiculos as phv on phv.proposta_pro_id = proposta.pro_id join veiculos on phv.veiculos_vei_id = veiculos.vei_id join modelo on veiculos.mod_id = modelo.mod_id where chp.caravana_car_id = ?car_id and pro_status != 'Negado'";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_id", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static DataSet selectCaravanSearch(string pesquisa, int id)
    {
        try
        {

            DataSet ds = new DataSet();
            IDbConnection conexao;
            IDbCommand command;
            IDataAdapter dataAdapter;
            conexao = Mapped.Connection();
            string query = "select car_id as id, car_foto as foto ,car_titulo as titulo, car_datahorachegada as DataHoraChegada, car_datahorasaida as DataHoraSaida,group_concat(uc_cidade ) as cidade, group_concat(uc_uf) as estado, group_concat(end_tipo) as tipo from caravana inner join caravana_tem_endereco as cha on car_id = cha.caravana_car_id inner join endereco on cha.endereco_end_id = end_id inner join uf_e_cidades as ufcity on endereco.uc_id = ufcity.uc_id where (car_titulo like '"+pesquisa+"%' or uc_uf like '"+pesquisa+"%' or uc_cidade like '"+pesquisa+ "%') and (car_idcriador != ?car_id or car_idcriador is null) and car_privacidade = 0 group by car_id order by car_datadecriação desc;";

            command = Mapped.Command(query, conexao);
            command.Parameters.Add(Mapped.Parameter("?car_id", id));
            dataAdapter = Mapped.Adapter(command);
            

            dataAdapter.Fill(ds);
            conexao.Close();
            conexao.Dispose();
            command.Dispose();
            return ds;
        }
        catch(Exception e)
        {
            return null;
        }

        

    }


    public static DataSet selectCaravanSearch2(string pesquisa, int id)
    {
        try
        {

            DataSet ds = new DataSet();
            IDbConnection conexao;
            IDbCommand command;
            IDataAdapter dataAdapter;
            conexao = Mapped.Connection();
            string query = "select car_id as id, car_foto as foto ,car_titulo as titulo, car_datahorachegada as DataHoraChegada, car_datahorasaida as DataHoraSaida,group_concat(uc_cidade ) as cidade, group_concat(uc_uf) as estado, group_concat(end_tipo) as tipo from caravana inner join caravana_tem_endereco as cha on car_id = cha.caravana_car_id inner join endereco on cha.endereco_end_id = end_id inner join uf_e_cidades as ufcity on endereco.uc_id = ufcity.uc_id where (car_titulo like '" + pesquisa + "%' or uc_uf like '" + pesquisa + "%' or uc_cidade like '" + pesquisa + "%') and (car_idcriador != ?car_id or car_idcriador is null) and car_privacidade = 0 group by car_id order by car_datadecriação asc;";

            command = Mapped.Command(query, conexao);
            command.Parameters.Add(Mapped.Parameter("?car_id", id));
            dataAdapter = Mapped.Adapter(command);


            dataAdapter.Fill(ds);
            conexao.Close();
            conexao.Dispose();
            command.Dispose();
            return ds;
        }
        catch (Exception e)
        {
            return null;
        }



    }


    public static DataSet selectCaravanPeople(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select * from cliente_caravana_status where car_id = ?car_id ;";

        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?car_id", id));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }



}