namespace WinFormsApp2
{
    partial class app
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(app));
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            txtCaminhoArquivo3 = new TextBox();
            txtCaminhoArquivo2 = new TextBox();
            btnAnexar2 = new Button();
            btnAnexar = new Button();
            btnAnexar3 = new Button();
            txtCaminhoArquivo = new TextBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            btnAnexar4 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtCaminhoArquivo3
            // 
            txtCaminhoArquivo3.Location = new Point(275, 150);
            txtCaminhoArquivo3.Name = "txtCaminhoArquivo3";
            txtCaminhoArquivo3.Size = new Size(448, 23);
            txtCaminhoArquivo3.TabIndex = 5;
            txtCaminhoArquivo3.TextChanged += textBox3_TextChanged;
            // 
            // txtCaminhoArquivo2
            // 
            txtCaminhoArquivo2.Location = new Point(275, 93);
            txtCaminhoArquivo2.Name = "txtCaminhoArquivo2";
            txtCaminhoArquivo2.Size = new Size(448, 23);
            txtCaminhoArquivo2.TabIndex = 4;
            txtCaminhoArquivo2.TextChanged += textBox2_TextChanged;
            // 
            // btnAnexar2
            // 
            btnAnexar2.Location = new Point(14, 92);
            btnAnexar2.Name = "btnAnexar2";
            btnAnexar2.Size = new Size(239, 23);
            btnAnexar2.TabIndex = 6;
            btnAnexar2.Text = "planilha_lotes_com_sequencia";
            btnAnexar2.UseVisualStyleBackColor = true;
            btnAnexar2.Click += btnAnexar2_Click;
            // 
            // btnAnexar
            // 
            btnAnexar.Location = new Point(14, 37);
            btnAnexar.Name = "btnAnexar";
            btnAnexar.Size = new Size(239, 23);
            btnAnexar.TabIndex = 0;
            btnAnexar.Text = "planilha_tape_rodeiros";
            btnAnexar.UseVisualStyleBackColor = true;
            btnAnexar.Click += button1_Click;
            // 
            // btnAnexar3
            // 
            btnAnexar3.Location = new Point(14, 149);
            btnAnexar3.Name = "btnAnexar3";
            btnAnexar3.Size = new Size(239, 23);
            btnAnexar3.TabIndex = 7;
            btnAnexar3.Text = "planilha_quilometragem_rodeiros";
            btnAnexar3.UseVisualStyleBackColor = true;
            btnAnexar3.Click += btnAnexar3_Click;
            // 
            // txtCaminhoArquivo
            // 
            txtCaminhoArquivo.BackColor = SystemColors.ControlLightLight;
            txtCaminhoArquivo.Location = new Point(275, 38);
            txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            txtCaminhoArquivo.ReadOnly = true;
            txtCaminhoArquivo.Size = new Size(448, 23);
            txtCaminhoArquivo.TabIndex = 3;
            txtCaminhoArquivo.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveBorder;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnAnexar4);
            groupBox1.Controls.Add(txtCaminhoArquivo);
            groupBox1.Controls.Add(btnAnexar3);
            groupBox1.Controls.Add(btnAnexar);
            groupBox1.Controls.Add(btnAnexar2);
            groupBox1.Controls.Add(txtCaminhoArquivo2);
            groupBox1.Controls.Add(txtCaminhoArquivo3);
            groupBox1.Location = new Point(259, 289);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(729, 272);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "anexar arquivos aqui";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(445, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // btnAnexar4
            // 
            btnAnexar4.Location = new Point(14, 211);
            btnAnexar4.Name = "btnAnexar4";
            btnAnexar4.Size = new Size(239, 23);
            btnAnexar4.TabIndex = 8;
            btnAnexar4.Text = "planilha_notas_manutencao";
            btnAnexar4.UseVisualStyleBackColor = true;
            btnAnexar4.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 36);
            panel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(940, 3);
            button1.Name = "button1";
            button1.Size = new Size(69, 30);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = SystemColors.ButtonFace;
            maskedTextBox1.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(386, 40);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(537, 46);
            maskedTextBox1.TabIndex = 11;
            maskedTextBox1.Text = "Adequação do supermercado de rodeiros";
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // app
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources._5189_20250203085217__1_;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1010, 560);
            Controls.Add(maskedTextBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "app";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
        private TextBox txtCaminhoArquivo3;
        private TextBox txtCaminhoArquivo2;
        private Button btnAnexar2;
        private Button btnAnexar;
        private Button btnAnexar3;
        private TextBox txtCaminhoArquivo;
        private GroupBox groupBox1;
        private Panel panel1;
        private Button button1;
        private Button btnAnexar4;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
    }
}
