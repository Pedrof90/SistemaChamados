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
using Sistema_De_Chamados.Modelo;

namespace Sistema_De_Chamados
{
    public partial class TelaAdm : Form
    {
        public TelaAdm()
        {
            InitializeComponent();
        }

        private void TelaAdm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = new PessoaDaoComandos().consultaUsuarios();

            dgvUsuarios.DataSource = dt;

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int linha = dgvUsuarios.CurrentCell.RowIndex;

                tbUsuario.Text = dgvUsuarios[0, linha].Value.ToString();
                tbSenha.Text = dgvUsuarios[4, linha].Value.ToString();
                tbCelular.Text = dgvUsuarios[3, linha].Value.ToString();
                tbInscricao.Text = dgvUsuarios[1, linha].Value.ToString();
                tbEmail.Text = dgvUsuarios[2, linha].Value.ToString();

                if (Convert.ToInt32(dgvUsuarios[5, linha].Value) == 1)
                {
                    rbSuporte.Checked = true;
                    rbUsuario.Checked = false;
                    rbAdm.Checked = false;
                }
                else if(Convert.ToInt32(dgvUsuarios[5, linha].Value) == 2)
                {
                    rbUsuario.Checked = true;
                    rbSuporte.Checked = false;
                    rbAdm.Checked = false;
                }
                else
                {
                    rbUsuario.Checked = false;
                    rbSuporte.Checked = false;
                    rbAdm.Checked = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um usuário!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void rbUsuario_Click(object sender, EventArgs e)
        {
            rbSuporte.Checked = false;
            rbAdm.Checked = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Alterar os dados?", "teste", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int tipoUsuario;

                if(rbSuporte.Checked)
                {
                    tipoUsuario = 1;
                }
                else if(rbAdm.Checked)
                {
                    tipoUsuario = 3;
                }
                else
                {
                    tipoUsuario = 2;
                }

                if (new PessoaDaoComandos().SalvarDados(tbUsuario.Text, tbEmail.Text, tbSenha.Text, tbCelular.Text, tbInscricao.Text, tipoUsuario)) 
                {
                    MessageBox.Show("Dados Alterados Com Sucesso!");
                    this.Close();
                    Chamados ch = new Chamados();
                    ch.Visible = true;
                };
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Chamados ch = new Chamados();

            this.Close();
            ch.Visible = true;
        }

        private void rbAdm_Click_1(object sender, EventArgs e)
        {
            rbUsuario.Checked = false;
            rbSuporte.Checked = false;
        }

        private void rbSuporte_Click(object sender, EventArgs e)
        {
            rbUsuario.Checked = false;
            rbAdm.Checked = false;
        }
    }
}
