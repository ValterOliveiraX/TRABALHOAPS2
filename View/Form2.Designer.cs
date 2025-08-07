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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
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
            filtros.Controls.Add(dataGridView1);
            filtros.Controls.Add(label1);
            filtros.Controls.Add(button1);
            filtros.Location = new Point(4, 24);
            filtros.Name = "filtros";
            filtros.Padding = new Padding(3);
            filtros.Size = new Size(1136, 453);
            filtros.TabIndex = 0;
            filtros.Text = "Filtros";
            filtros.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(124, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(987, 422);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(6, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}