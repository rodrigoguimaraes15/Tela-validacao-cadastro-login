using ProjetoLogin.DAO;
using System;

namespace ProjetoLogin.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool acessar(string login, string senha)
        {
            LoginDaoComando loginDao = new LoginDaoComando();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals("")) 
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(string email, string senha, string confSenha) 
        {
            LoginDaoComando loginDao = new LoginDaoComando();
            this.mensagem = loginDao.cadasdtrar(email, senha, confSenha);

            if (loginDao.tem) 
            {
                this.tem = true;
            }
            return mensagem;
        } 
    }
}
