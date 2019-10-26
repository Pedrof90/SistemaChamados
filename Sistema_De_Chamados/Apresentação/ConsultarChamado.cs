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

namespace Sistema_De_Chamados
{
    public partial class ConsultarChamado : Form
    {
        public ConsultarChamado()
        {
            InitializeComponent();
        }

        private void ConsultarChamado_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            int idChamado = 0;

            if(tbConsultaChamado.Text != string.Empty)
            {
                idChamado = Convert.ToInt32(tbConsultaChamado.Text);
            }
            DataTable dt = new DataTable();
            dt = new ChamadoDaoComandos().ConsultarChamado(idChamado);

            dgvChamados.DataSource = dt;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Chamados ch = new Chamados();
            ch.Visible = true;
        }
    }
}
