using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;

/// <summary>
/// Descrição resumida de VisitorBD
/// </summary>
public class VisitorBD
{
    public static void SendEmailRecuperarSenha(string email, string hash)
    {
        MailMessage emailRecuperarSenha = new MailMessage("projetocaravamo@gmail.com", email);
        emailRecuperarSenha.Subject = "Redefinição de Senha da Conta Caravamo";

        StringBuilder emailbody = new StringBuilder();

        emailbody.Append("<h2>Atenção!</h2>");
        emailbody.Append("<P>Uma requisição para alterar a senha foi requisitada para esta conta</p>");
        emailbody.Append("<P>Caso não tenha sido você, ignore esta mensagem</p>");
        emailbody.Append("<div style= 'text-align:center'>");
        emailbody.Append("<a href='http://localhost:50783/Pages/ToVisitor/Redefinir_Senha_Secure.aspx?id=" + hash + "'>Clique aqui para criar uma nova senha</a>");
        emailbody.Append("</div>");


        emailRecuperarSenha.IsBodyHtml = true;
        emailRecuperarSenha.Body = emailbody.ToString();

        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new System.Net.NetworkCredential()
        {
            UserName = "projetocaravamo@gmail.com",
            Password = "caravamofatec"
        };

        smtpClient.EnableSsl = true;
        smtpClient.Send(emailRecuperarSenha);

    }

    public static void SendEmailConf(string email, string hash)
    {
        MailMessage emailRecuperarSenha = new MailMessage("projetocaravamo@gmail.com", email);
        emailRecuperarSenha.Subject = "Bem - vindo ao Caravamo";

        StringBuilder emailbody = new StringBuilder();

        emailbody.Append("<h2>Bem vindo!</h2>");
        emailbody.Append("<P>Parabéns! Você criou uma conta com sucesso no caravamo</p>");
        emailbody.Append("<P>Entretanto,para acessa-la precisamos que confirme este e-mail</p>");
        emailbody.Append("<div style= 'text-align:center'>");
        emailbody.Append("<a href='http://localhost:50783/Pages/ToVisitor/Index.aspx?confirmation=" + hash + "'>Clique aqui para confirmar o e-mail</a>");
        emailbody.Append("</div>");


        emailRecuperarSenha.IsBodyHtml = true;
        emailRecuperarSenha.Body = emailbody.ToString();

        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new System.Net.NetworkCredential()
        {
            UserName = "projetocaravamo@gmail.com",
            Password = "caravamofatec"
        };

        smtpClient.EnableSsl = true;
        smtpClient.Send(emailRecuperarSenha);

    }

    public static void SendEmailSenhaAtualizada(string email)
    {
        MailMessage emailRecuperarSenha = new MailMessage("projetocaravamo@gmail.com", email);
        emailRecuperarSenha.Subject = "Alteração de Senha da Conta Caravamo";

        StringBuilder emailbody = new StringBuilder();

        emailbody.Append("<h2>Atenção!</h2>");
        emailbody.Append("<P>A senha da sua conta caravamo foi alterada</p>");
        emailbody.Append("<P>Caso tenha sido você ignore esta mensagem,caso contrário</p>");
        emailbody.Append("<div style= 'text-align:center'>");
        emailbody.Append("<a href='http://localhost:50783/Pages/ToVisitor/Redefinir_Senha.aspx'>Clique aqui para criar uma nova senha</a>");
        emailbody.Append("</div>");


        emailRecuperarSenha.IsBodyHtml = true;
        emailRecuperarSenha.Body = emailbody.ToString();

        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new System.Net.NetworkCredential()
        {
            UserName = "projetocaravamo@gmail.com",
            Password = "caravamofatec"
        };

        smtpClient.EnableSsl = true;
        smtpClient.Send(emailRecuperarSenha);

    }


    public static void SendEmailAtualizacaoCaravana(string email, string titulo, string nomeCliente, string hash)
    {
        MailMessage emailAtualizacao = new MailMessage("projetocaravamo@gmail.com", email);
        emailAtualizacao.Subject = "Atualização da Caravana " + titulo;




        StringBuilder emailbody = new StringBuilder();
        emailbody.Append("<h2>Olá " + nomeCliente + "!</h2>");
        emailbody.Append("<P>Um novo usuário se inscreveu na caravana " + titulo + " que você mostrou interesse!</p>");
        emailbody.Append("<div style= 'text-align:center'>");
        emailbody.Append("<a href='http://localhost:50783/Pages/ToUser/Caravana.aspx?iud=" + hash + "'>Clique Aqui para ver a Caravana</a>");
        emailbody.Append("</div>");

        emailAtualizacao.IsBodyHtml = true;
        emailAtualizacao.Body = emailbody.ToString();



        emailAtualizacao.Body = emailbody.ToString();

        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new System.Net.NetworkCredential()
        {
            UserName = "projetocaravamo@gmail.com",
            Password = "caravamofatec"
        };

        smtpClient.EnableSsl = true;
        smtpClient.Send(emailAtualizacao);


    }

    public static void SendEmailAtualizacaoCaravana2(string email, string titulo, string nomeCliente, string hash)
    {
        MailMessage emailAtualizacao = new MailMessage("projetocaravamo@gmail.com", email);
        emailAtualizacao.Subject = "Atualização da Caravana " + titulo;




        StringBuilder emailbody = new StringBuilder();
        emailbody.Append("<h2>Olá " + nomeCliente + "!</h2>");
        emailbody.Append("<P>A Caravana " + titulo + " que você mostrou interesse acabou de aceitar uma proposta de empresa!</p>");
        emailbody.Append("<div style= 'text-align:center'>");
        emailbody.Append("<a href='http://localhost:50783/Pages/ToUser/Caravana.aspx?iud=" + hash + "'>Clique Aqui para ver a Caravana</a>");
        emailbody.Append("</div>");

        emailAtualizacao.IsBodyHtml = true;
        emailAtualizacao.Body = emailbody.ToString();



        emailAtualizacao.Body = emailbody.ToString();

        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new System.Net.NetworkCredential()
        {
            UserName = "projetocaravamo@gmail.com",
            Password = "caravamofatec"
        };

        smtpClient.EnableSsl = true;
        smtpClient.Send(emailAtualizacao);

    }







    public static int insertSenhaSegurancaUsuario(string email)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "insert into senha_seguranca_usuario(SSU_id, SSU_UserId, SSU_DataRequisicao) values ((uuid()),(select usu_id from usuario where usu_email = ?usu_email), now() );";
            query = Mapped.Command(command, conexao);
            query.Parameters.Add(Mapped.Parameter("?usu_email", email));
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


    public static String selectHash()
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select SSU_id  as hash from senha_seguranca_usuario ORDER BY SSU_DataRequisicao DESC LIMIT 0,1;";
        Usuario auxu = new Usuario();


        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds.Tables[0].Rows[0]["hash"].ToString();
    }


    public static DataSet SelectValidReset(string hash)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select usu_id  as id from senha_seguranca_usuario inner join usuario on SSU_UserId = usu_id where SSU_id = ?hash;";



        command = Mapped.Command(query, conexao);
        dataAdapter = Mapped.Adapter(command);
        command.Parameters.Add(Mapped.Parameter("?hash", hash));


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds;
    }

    public static Boolean UpdateCheckEmail(string hash)
    {
        Boolean worked = true;
        try
        {
            DataSet ds = new DataSet();
            IDbConnection conexao;
            IDbCommand command;
            IDataAdapter dataAdapter;
            conexao = Mapped.Connection();
            string query = "update usuario set usu_confirmacao = 'Confirmado' where usu_confirmacao = ?hash;";



            command = Mapped.Command(query, conexao);
            dataAdapter = Mapped.Adapter(command);
            command.Parameters.Add(Mapped.Parameter("?hash", hash));


            dataAdapter.Fill(ds);
            conexao.Close();
            conexao.Dispose();
            command.Dispose();
        }
        catch (Exception e)
        {
            worked = false;

        }
        return worked;

    }



    public static int UpdateSenha(string senha, int id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "update usuario set usu_senha = ?usu_senha where usu_id = ?usu_id;";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?usu_senha", senha));
            query.Parameters.Add(Mapped.Parameter("?usu_id", id));

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

    public static int DeleteHash(string hash, int id)
    {
        int status = 0;
        try
        {
            IDbConnection conexao;
            IDbCommand query;
            conexao = Mapped.Connection();
            string command = "delete from senha_seguranca_usuario where SSU_id = '?ssu_id' and SSU_UserId = ?usu_id;";
            query = Mapped.Command(command, conexao);

            query.Parameters.Add(Mapped.Parameter("?ssu_id", hash));
            query.Parameters.Add(Mapped.Parameter("?usu_id", id));

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



    public static String selectEmail(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection conexao;
        IDbCommand command;
        IDataAdapter dataAdapter;
        conexao = Mapped.Connection();
        string query = "select usu_email as email from usuario where usu_id =?usu_id;";
        Usuario auxu = new Usuario();


        command = Mapped.Command(query, conexao);
        command.Parameters.Add(Mapped.Parameter("?usu_id", id));
        dataAdapter = Mapped.Adapter(command);


        dataAdapter.Fill(ds);
        conexao.Close();
        conexao.Dispose();
        command.Dispose();

        return ds.Tables[0].Rows[0]["email"].ToString();
    }


}