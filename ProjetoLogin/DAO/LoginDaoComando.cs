using System;
using System.Data.SqlClient;


namespace ProjetoLogin.DAO
{
    class LoginDaoComando
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(string login, string senha) 
        {
            //procurar no banco esse login e senha
            cmd.CommandText = "select * from Logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) //se foi encontrado
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;
        }

        public String cadasdtrar(string email, string senha, string confSenha) 
        {
            tem = false;
            //comandos para inserir
            if (senha.Equals(confSenha)) 
            {
                cmd.CommandText = "insert into Logins values(@e, @s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com o banco de dados";
                    
                }

            }
            else 
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem;
        }
    }
}
