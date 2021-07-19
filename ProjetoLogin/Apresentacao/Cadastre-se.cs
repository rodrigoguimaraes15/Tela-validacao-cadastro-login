using ProjetoLogin.Modelo;
using System;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentacao
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void Cadastre_se_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.cadastrar(txtLogin.Text,txtSenha.Text,txtConfirmarSenha.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.cadastrar(txtLogin2.Text,txtSenha2.Text,txtConfSenha.Text);
            if (controle.tem) 
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show(controle.mensagem); //mensagem de erro
            }

            //senhas tem que conter caracteres e numeros(regras) (quantidade de numeros)
            //antes de cadastrar um usuario, verificar se o usuario que existe no banco de dados
            // verificar se o final do email possui @dominio.com
        }
    }
}
