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

namespace Sistema_De_Chamados
{
    public partial class GerarRelatorio : Form
    {
        public GerarRelatorio()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Chamados ch = new Chamados();
            ch.Visible = true;
        }

        private void richtxtmotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void GerarRelatorio_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = new ChamadoDaoComandos().GeraRelatorio();

            dgvRelatorios.DataSource = dt;
        }
    }
}
