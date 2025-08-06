using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using WinFormsApp2.View;

namespace WinFormsApp2
{
    public partial class app : Form
    {

        public app()
        {
            InitializeComponent();
            //usando esta linha para o excel datra reader
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Esta linha fecha o formulário atual.
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAbrirProcessador_Click(object sender, EventArgs e)
        {
            Form1 formDoProcessador = new Form1();
            formDoProcessador.ShowDialog(); // Abre a janela de processamento
        }

        private void app_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // primeiro botçao de anexar arquivo

    }
}
