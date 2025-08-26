namespace WinFormsApp2.View
{
    partial class Form2
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
            tabControl1 = new TabControl();
            filtros = new TabPage();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(filtros);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1144, 481);
            tabControl1.TabIndex = 1;
            // 
            // filtros
            // 
            filtros.Controls.Add(label3);
            filtros.Controls.Add(button1);
            filtros.Controls.Add(label2);
            filtros.Controls.Add(textBox1);
            filtros.Controls.Add(comboBox1);
            filtros.Controls.Add(dataGridView1);
            filtros.Controls.Add(label1);
            filtros.Location = new Point(4, 24);
            filtros.Name = "filtros";
            filtros.Padding = new Padding(3);
            filtros.Size = new Size(1136, 453);
            filtros.TabIndex = 0;
            filtros.Text = "Filtros";
            filtros.UseVisualStyleBackColor = true;
            filtros.Click += filtros_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Bahnschrift SemiCondensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 154);
            label3.Name = "label3";
            label3.Size = new Size(129, 61);
            label3.TabIndex = 8;
            label3.Text = "Selecione o campo na lista, depois esceva no campo de busca...";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 409);
            button1.Name = "button1";
            button1.Size = new Size(126, 27);
            button1.TabIndex = 7;
            button1.Text = "EXPORTAR (.csv)";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 10F);
            label2.Location = new Point(0, 98);
            label2.Name = "label2";
            label2.Size = new Size(131, 17);
            label2.TabIndex = 6;
            label2.Text = "Digite o valor de busca";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Id", "Lote", "Vagão", "Sequência", "Rodeio", "Tape" });
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Id", "Lote", "Vagão", "Rodeiro", "Sequência", "tape" });
            comboBox1.Location = new Point(3, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 23);
            comboBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(135, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(976, 422);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 10F);
            label1.Location = new Point(3, 45);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 1;
            label1.Text = "Filtrar por:";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1136, 453);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Graficos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.trem_de_carga_da_vale_292529;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1196, 526);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "JANELA DE FILTROS";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            filtros.ResumeLayout(false);
            filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage filtros;
        private TabPage tabPage2;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
    }
}