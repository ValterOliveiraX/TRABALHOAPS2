﻿namespace WinFormsApp2.View
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
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // btnProcessar
            // 
            btnProcessar.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            btnProcessar.Location = new Point(12, 65);
            btnProcessar.Name = "btnProcessar";
            btnProcessar.Size = new Size(315, 79);
            btnProcessar.TabIndex = 0;
            btnProcessar.Text = "Carregar e Processar Arquivos";
            btnProcessar.UseVisualStyleBackColor = true;
            btnProcessar.Click += btnProcessar_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResultados.BackgroundColor = SystemColors.Window;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(7, 147);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(776, 332);
            dgvResultados.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.ControlLightLight;
            lblStatus.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            lblStatus.Location = new Point(333, 131);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 25);
            lblStatus.TabIndex = 2;
            lblStatus.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources._5189_20250203085217__1_;
            ClientSize = new Size(800, 675);
            Controls.Add(lblStatus);
            Controls.Add(dgvResultados);
            Controls.Add(btnProcessar);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProcessar;
        private DataGridView dgvResultados;
        private Label lblStatus;
    }
}