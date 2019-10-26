using Sistema_De_Chamados.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_De_Chamados.Modelo;
using Sistema_De_Chamados.Apresentação;

namespace Sistema_De_Chamados
{
    public partial class Chamados : Form
    {
        public string login;
        public string senha;
        public Chamados()
        {

            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaChamado_Load(object sender, EventArgs e)
        {
            bool adm;
            bool suporte;
            tssUsuario.Text = Cadastro.Login;
            adm = new LoginDaoComandos().VerificaADM(Cadastro.Login, Cadastro.Senha);
            suporte = new LoginDaoComandos().VerificaSuporte(Cadastro.Login, Cadastro.Senha);

            if (adm)
            {
                this.menuAdm.Enabled = true;
                this.menuSuporte.Enabled = true;
                tssTIpo.Text = "Administrador";
            }
            else if (suporte)
            {
                this.menuSuporte.Enabled = true;
                this.menuAdm.Enabled = false;
                tssTIpo.Text = "Suporte";
            }
            else
            {
                tssTIpo.Text = "Cliente";
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string MensagemRetorno;

            if (txtTitulo.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor preencher o Título", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitulo.Focus();
            }
            else if (txtProduto.Text.Equals(string.Empty))
            {
                MessageBox.Show("Favor preencher a Inscricao!", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProduto.Focus();
            }
            else if (mkdContato.Text.Length < 15)
            {
                MessageBox.Show("Favor preencher o contato!", "Cadastro inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mkdContato.Focus();
            }
        
            else
            {
                ChamadoDaoComandos CadastraChamado = new ChamadoDaoComandos();

                try
                {
                    MensagemRetorno = CadastraChamado.ordemservico(txtTitulo.Text
                    , txtProduto.Text
                    , mkdContato.Text
                    , richtxtDescricao.Text
                    ,Cadastro.Login
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar login!\n\n " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(MensagemRetorno, "Chamado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaDados();

            }
        }

        private void LimpaDados()
        {
            txtProduto.Text = string.Empty;
            richtxtDescricao.Text = string.Empty;
            mkdContato.Text = string.Empty;
            txtTitulo.Text = string.Empty;
        }

        private void richtxtDescricao_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void menuAdm_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarChamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarChamado cc = new ConsultarChamado();
            cc.Show();
        }

        private void alteraçãoDadosCadastraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void chamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void alteraçãoDadosCadastraisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaAdm adm = new TelaAdm();
            this.Visible = false;
            adm.Show();
        }

        private void chamadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GerenciarChamado gc = new GerenciarChamado();
            gc.Visible = true;
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GerarRelatorio gr = new GerarRelatorio();
            gr.Show();
        }
    }
}
