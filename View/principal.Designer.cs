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
            panel1 = new Panel();
            button1 = new Button();
            btnAbrirProcessador = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 36);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
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
            // btnAbrirProcessador
            // 
            btnAbrirProcessador.BackColor = Color.White;
            btnAbrirProcessador.BackgroundImageLayout = ImageLayout.Center;
            btnAbrirProcessador.Font = new Font("Bahnschrift SemiCondensed", 24F);
            btnAbrirProcessador.Location = new Point(386, 105);
            btnAbrirProcessador.Name = "btnAbrirProcessador";
            btnAbrirProcessador.Size = new Size(118, 57);
            btnAbrirProcessador.TabIndex = 12;
            btnAbrirProcessador.Text = "INICIAR";
            btnAbrirProcessador.UseVisualStyleBackColor = false;
            btnAbrirProcessador.Click += btnAbrirProcessador_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift SemiCondensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 47);
            label1.Name = "label1";
            label1.Size = new Size(570, 42);
            label1.TabIndex = 13;
            label1.Text = "Adequação do supermercado de rodeiros";
            label1.Click += label1_Click;
            // 
            // app
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources._5189_20250203085217__1_;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1010, 560);
            Controls.Add(label1);
            Controls.Add(btnAbrirProcessador);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "app";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            Text = "Form1";
            Load += app_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
        private Panel panel1;
        private Button button1;
        private Button btnAbrirProcessador;
        private Label label1;
    }
}
