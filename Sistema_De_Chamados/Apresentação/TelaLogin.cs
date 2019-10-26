using Sistema_De_Chamados.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_De_Chamados
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                    Chamados bv = new Chamados();
                    bv.Show();
                   
                }
                else
                {
                    MessageBox.Show("Login não encontrados, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("bem vindo");

            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            
            CadastroLogin cad = new CadastroLogin();
            cad.Show();
            this.Visible = false;

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
