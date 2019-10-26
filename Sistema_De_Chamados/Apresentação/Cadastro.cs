using Sistema_De_Chamados.DAL;
using Sistema_De_Chamados.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;


using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_De_Chamados
{
    public partial class CadastroLogin : Form
    {
        public CadastroLogin(bool Cadastrar = true)
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbldep_Click(object sender, EventArgs e)
        {

        }

        private void Btnsalvar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor preencher o Login", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if (txtInscricao.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor preencher a Inscricao!", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInscricao.Focus();
            }
            else if (txtEmail.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor preencher o Email!", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (mkdCelular.Text.Length < 15)
            {
                MessageBox.Show("Favor preencher o Celular!", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mkdCelular.Focus();
            }
            else if (txtSenha.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor preencher a Senha!", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }else if (txtSenha.Text != txtRepSenha.Text)
            {
                MessageBox.Show("As senhas não são iguais");
            }
            else
            {
                LoginDaoComandos CadastroLogin = new LoginDaoComandos();

                try
                {
                    CadastroLogin.cadastro(txtLogin.Text
                    , txtEmail.Text
                    , txtSenha.Text
                    , mkdCelular.Text
                    , txtInscricao.Text
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar login!\n\n " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Login Cadastrado com sucesso!");
                TelaLogin login = new TelaLogin();
                login.Show();

                this.Close();

            }
          
        }

        private void Txtinscricao_TextChanged(object sender, EventArgs e)
        {
         
        }
         
        private void Txtcelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRepSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
        }

       

        private void btnAlterar_Click(object sender, EventArgs e)
        { 
        }
           
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.txtLogin.Clear();
            this.txtInscricao.Clear();
            this.txtEmail.Clear();
            this.mkdCelular.Clear();
            this.txtSenha.Clear();
            this.txtRepSenha.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
         
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaLogin t = new TelaLogin();
            t.Visible = true;
            this.Close();
        }
    }
    }

