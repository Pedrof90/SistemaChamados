namespace Sistema_De_Chamados.Apresentação
{
    partial class GerenciarChamado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntPesquisa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richtxtResumo = new System.Windows.Forms.RichTextBox();
            this.richtxtResolucao = new System.Windows.Forms.RichTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChamadosSuporte = new System.Windows.Forms.DataGridView();
            this.tbUsuarioCHamadoAberto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbChamadoAberto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosSuporte)).BeginInit();
            this.SuspendLayout();
            // 
            // bntPesquisa
            // 
            this.bntPesquisa.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPesquisa.Location = new System.Drawing.Point(25, 21);
            this.bntPesquisa.Name = "bntPesquisa";
            this.bntPesquisa.Size = new System.Drawing.Size(121, 42);
            this.bntPesquisa.TabIndex = 2;
            this.bntPesquisa.Text = "PESQUISAR";
            this.bntPesquisa.UseVisualStyleBackColor = true;
            this.bntPesquisa.Click += new System.EventHandler(this.bntPesquisa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "RESUMO DO PROBLEMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(800, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "RESOLUÇÃO DO PROBLEMA";
            // 
            // richtxtResumo
            // 
            this.richtxtResumo.Enabled = false;
            this.richtxtResumo.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtResumo.Location = new System.Drawing.Point(428, 386);
            this.richtxtResumo.Name = "richtxtResumo";
            this.richtxtResumo.Size = new System.Drawing.Size(298, 166);
            this.richtxtResumo.TabIndex = 5;
            this.richtxtResumo.Text = "";
            // 
            // richtxtResolucao
            // 
            this.richtxtResolucao.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtResolucao.Location = new System.Drawing.Point(803, 386);
            this.richtxtResolucao.Name = "richtxtResolucao";
            this.richtxtResolucao.Size = new System.Drawing.Size(298, 166);
            this.richtxtResolucao.TabIndex = 6;
            this.richtxtResolucao.Text = "";
            this.richtxtResolucao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richtxtResolucao_KeyDown);
            this.richtxtResolucao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richtxtResolucao_KeyUp);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(1075, 616);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(125, 40);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.Location = new System.Drawing.Point(534, 616);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(125, 40);
            this.btnEncerrar.TabIndex = 8;
            this.btnEncerrar.Text = "ENCERRAR";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(12, 616);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 40);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Items.AddRange(new object[] {
            "ALTA",
            "MEDIA",
            "BAIXA"});
            this.cmbPrioridade.Location = new System.Drawing.Point(25, 460);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(121, 25);
            this.cmbPrioridade.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prioridade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvChamadosSuporte);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 265);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chamados";
            // 
            // dgvChamadosSuporte
            // 
            this.dgvChamadosSuporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamadosSuporte.Location = new System.Drawing.Point(11, 21);
            this.dgvChamadosSuporte.Name = "dgvChamadosSuporte";
            this.dgvChamadosSuporte.RowHeadersWidth = 51;
            this.dgvChamadosSuporte.RowTemplate.Height = 24;
            this.dgvChamadosSuporte.Size = new System.Drawing.Size(1170, 235);
            this.dgvChamadosSuporte.TabIndex = 0;
            this.dgvChamadosSuporte.Click += new System.EventHandler(this.dgvChamadosSuporte_Click);
            // 
            // tbUsuarioCHamadoAberto
            // 
            this.tbUsuarioCHamadoAberto.Enabled = false;
            this.tbUsuarioCHamadoAberto.Location = new System.Drawing.Point(25, 389);
            this.tbUsuarioCHamadoAberto.Name = "tbUsuarioCHamadoAberto";
            this.tbUsuarioCHamadoAberto.Size = new System.Drawing.Size(134, 22);
            this.tbUsuarioCHamadoAberto.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Solicitante";
            // 
            // tbChamadoAberto
            // 
            this.tbChamadoAberto.Enabled = false;
            this.tbChamadoAberto.Location = new System.Drawing.Point(254, 386);
            this.tbChamadoAberto.Name = "tbChamadoAberto";
            this.tbChamadoAberto.Size = new System.Drawing.Size(134, 22);
            this.tbChamadoAberto.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Aberto em:";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "ABERTO",
            "RESOLVENDO",
            "FECHADO"});
            this.txtStatus.Location = new System.Drawing.Point(254, 460);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(121, 25);
            this.txtStatus.TabIndex = 19;
            // 
            // cbTecnico
            // 
            this.cbTecnico.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Location = new System.Drawing.Point(25, 527);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(121, 25);
            this.cbTecnico.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Técnico";
            // 
            // GerenciarChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 668);
            this.Controls.Add(this.cbTecnico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbChamadoAberto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUsuarioCHamadoAberto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPrioridade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.richtxtResolucao);
            this.Controls.Add(this.richtxtResumo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GerenciarChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciarChamado";
            this.Load += new System.EventHandler(this.GerenciarChamado_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosSuporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richtxtResumo;
        private System.Windows.Forms.RichTextBox richtxtResolucao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvChamadosSuporte;
        private System.Windows.Forms.TextBox tbUsuarioCHamadoAberto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbChamadoAberto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.ComboBox cbTecnico;
        private System.Windows.Forms.Label label7;
    }
}