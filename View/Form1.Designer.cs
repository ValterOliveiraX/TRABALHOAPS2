namespace WinFormsApp2.View
{
    partial class Form1
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
            btnProcessar = new Button();
            dgvResultados = new DataGridView();
            lblStatus = new Label();
            Arq2 = new TextBox();
            Arq3 = new TextBox();
            Arq4 = new TextBox();
            Arq1 = new TextBox();
            label = new Label();
            txtFiltro = new TextBox();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // btnProcessar
            // 
            btnProcessar.Font = new Font("Bahnschrift SemiCondensed", 20F);
            btnProcessar.Location = new Point(12, 12);
            btnProcessar.Name = "btnProcessar";
            btnProcessar.Size = new Size(347, 95);
            btnProcessar.TabIndex = 0;
            btnProcessar.Text = "Carregar e Processar Arquivos";
            btnProcessar.UseVisualStyleBackColor = true;
            btnProcessar.Click += btnProcessar_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.Location = new Point(18, 110);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(240, 150);
            dgvResultados.TabIndex = 11;
            dgvResultados.CellContentClick += dgvResultados_CellContentClick;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.ControlLightLight;
            lblStatus.Font = new Font("Bahnschrift SemiCondensed", 15F);
            lblStatus.Location = new Point(12, 110);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 24);
            lblStatus.TabIndex = 2;
            lblStatus.Click += label1_Click;
            // 
            // Arq2
            // 
            Arq2.Location = new Point(377, 36);
            Arq2.Name = "Arq2";
            Arq2.ReadOnly = true;
            Arq2.Size = new Size(389, 23);
            Arq2.TabIndex = 4;
            // 
            // Arq3
            // 
            Arq3.Location = new Point(377, 60);
            Arq3.Name = "Arq3";
            Arq3.ReadOnly = true;
            Arq3.Size = new Size(389, 23);
            Arq3.TabIndex = 5;
            Arq3.TextChanged += Arq3_TextChanged;
            // 
            // Arq4
            // 
            Arq4.Location = new Point(377, 84);
            Arq4.Name = "Arq4";
            Arq4.ReadOnly = true;
            Arq4.Size = new Size(389, 23);
            Arq4.TabIndex = 6;
            // 
            // Arq1
            // 
            Arq1.Location = new Point(377, 12);
            Arq1.Name = "Arq1";
            Arq1.ReadOnly = true;
            Arq1.Size = new Size(389, 23);
            Arq1.TabIndex = 7;
            Arq1.TextChanged += textBox1_TextChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = SystemColors.ButtonHighlight;
            label.Font = new Font("Bahnschrift SemiCondensed", 15F);
            label.Location = new Point(3, 255);
            label.Name = "label";
            label.Size = new Size(137, 24);
            label.TabIndex = 8;
            label.Text = "Filtrar na tabela:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(231, 349);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(100, 23);
            txtFiltro.TabIndex = 9;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(353, 350);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(157, 23);
            btnExportar.TabIndex = 10;
            btnExportar.Text = "Exportar para Excel";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources._5189_20250203085217__1_;
            ClientSize = new Size(800, 512);
            Controls.Add(btnExportar);
            Controls.Add(txtFiltro);
            Controls.Add(label);
            Controls.Add(Arq1);
            Controls.Add(Arq4);
            Controls.Add(Arq3);
            Controls.Add(Arq2);
            Controls.Add(lblStatus);
            Controls.Add(dgvResultados);
            Controls.Add(btnProcessar);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form1";
            Text = "SISTEMA DE GERENCIAMENTO DE RODEIROS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProcessar;
        private DataGridView dgvResultados;
        private Label lblStatus;
        private TextBox Arq2;
        private TextBox Arq3;
        private TextBox Arq4;
        private TextBox Arq1;
        private Label label;
        private TextBox txtFiltro;
        private Button btnExportar;
    }
}