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
            btnExportarCsv = new Button();
            btnFiltrar = new Button();
            btnBD = new Button();
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
            dgvResultados.Location = new Point(3, 133);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(785, 225);
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
            // btnExportarCsv
            // 
            btnExportarCsv.Font = new Font("Bahnschrift SemiCondensed", 15F);
            btnExportarCsv.Location = new Point(3, 364);
            btnExportarCsv.Name = "btnExportarCsv";
            btnExportarCsv.Size = new Size(224, 41);
            btnExportarCsv.TabIndex = 12;
            btnExportarCsv.Text = "Exportar para CSV";
            btnExportarCsv.UseVisualStyleBackColor = true;
            btnExportarCsv.Click += btnExportarCsv_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Font = new Font("Bahnschrift SemiCondensed", 15F);
            btnFiltrar.Location = new Point(243, 364);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(163, 41);
            btnFiltrar.TabIndex = 13;
            btnFiltrar.Text = "Filtros:";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnBD
            // 
            btnBD.Font = new Font("Bahnschrift SemiCondensed", 15F);
            btnBD.Location = new Point(421, 364);
            btnBD.Name = "btnBD";
            btnBD.Size = new Size(123, 41);
            btnBD.TabIndex = 14;
            btnBD.Text = "Salvar no BD";
            btnBD.UseVisualStyleBackColor = true;
            btnBD.Click += btnBD_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.trem_de_carga_da_vale_292529;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 447);
            Controls.Add(btnBD);
            Controls.Add(btnFiltrar);
            Controls.Add(btnExportarCsv);
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
        private Button btnExportarCsv;
        private Button btnFiltrar;
        private Button btnBD;
    }
}