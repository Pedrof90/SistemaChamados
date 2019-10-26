using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_De_Chamados.DAL;

namespace Sistema_De_Chamados.Apresentação
{
    public partial class GerenciarChamado : Form
    {
        public int idChamadoSelecionado;

        public GerenciarChamado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Chamados ch = new Chamados();
            ch.Visible = true;
        }

        private void bntPesquisa_Click(object sender, EventArgs e)
        {
 
            DataTable dt = new DataTable();
            dt = new ChamadoDaoComandos().ConsultaChamadosSuporte();

            dgvChamadosSuporte.DataSource = dt;
        }

        private void GerenciarChamado_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = new PessoaDaoComandos().ConsultaTecnico();

            foreach (DataRow item in dt.Rows)
            {
                cbTecnico.Items.Add(item[0].ToString());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool encerrado = new ChamadoDaoComandos().AlteraChamado(txtStatus.Text, cmbPrioridade.Text, richtxtResolucao.Text, DateTime.Now, this.idChamadoSelecionado, cbTecnico.Text);

            if (encerrado)
            {
                MessageBox.Show("Chamado alterado com sucesso!");
            }
        }

        private void dgvChamadosSuporte_Click(object sender, EventArgs e)
        {
            try
            {
                int linha = dgvChamadosSuporte.CurrentCell.RowIndex;

                tbUsuarioCHamadoAberto.Text = dgvChamadosSuporte[10, linha].Value.ToString();
                tbChamadoAberto.Text = Convert.ToDateTime(dgvChamadosSuporte[8, linha].Value).ToString("dd/MM/yyyy HH:mm");
                cmbPrioridade.Text = dgvChamadosSuporte[7, linha].Value.ToString();
                txtStatus.Text = dgvChamadosSuporte[6, linha].Value.ToString();
                richtxtResumo.Text = dgvChamadosSuporte[4, linha].Value.ToString();
                idChamadoSelecionado = (int)dgvChamadosSuporte[0, linha].Value;
                richtxtResolucao.Text = dgvChamadosSuporte[5, linha].Value.ToString();
                cbTecnico.Text = dgvChamadosSuporte[11, linha].Value.ToString();

                if (txtStatus.Text == "FECHADO")
                {
                    btnEncerrar.Enabled = false;
                    txtStatus.Enabled = false;
                    cmbPrioridade.Enabled = false;
                    richtxtResolucao.Enabled = false;
                    cbTecnico.Enabled = false;
                    btnSalvar.Enabled = false;
                }
                else
                {
                    btnEncerrar.Enabled = true;
                    txtStatus.Enabled = true;
                    cmbPrioridade.Enabled = true;
                    richtxtResolucao.Enabled = true;
                    cbTecnico.Enabled = true;
                    btnSalvar.Enabled = true;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um usuário!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void richtxtResolucao_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void richtxtResolucao_KeyUp(object sender, KeyEventArgs e)
        {
            if (richtxtResolucao.TextLength > 0)
            {
                btnEncerrar.Enabled = true;
            }
            else
            {
                btnEncerrar.Enabled = false;
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            bool encerrado = new ChamadoDaoComandos().AlteraChamado("FECHADO", cmbPrioridade.Text, richtxtResolucao.Text, DateTime.Now, this.idChamadoSelecionado, cbTecnico.Text);

            if (encerrado)
            {
                MessageBox.Show("Chamado encerrado com sucesso!");
            }
        }
    }
}
