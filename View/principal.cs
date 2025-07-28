using System.Windows.Forms;
using System;
using System.Data;
using System.IO;
using ExcelDataReader;

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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
                // Define o título da janela de seleção de arquivo
            

            // Define os filtros de arquivo para mostrar planilhas do Excel.
            // O formato é "Descrição Visível|*.extensao1;*.extensao2"
            // Aqui incluímos os formatos modernos (.xlsx) e os mais antigos (.xls).
            openFileDialog1.Filter = "Planilhas Excel (*.xlsx;*.xls)|*.xlsx;*.xls|Todos os arquivos (*.*)|*.*";
           

            // Abre a janela de seleção de arquivo e verifica se o usuário clicou em "OK"
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Se o usuário selecionou um arquivo e clicou em "OK",
                // pegamos o caminho completo do arquivo e o colocamos no nosso TextBox.
                txtCaminhoArquivo3.Text = openFileDialog1.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnexar2_Click(object sender, EventArgs e)
        {
            // Define o título da janela de seleção de arquivo
            openFileDialog1.Title = "Selecione uma planilha do Excel";

            // Define os filtros de arquivo para mostrar planilhas do Excel.
            // O formato é "Descrição Visível|*.extensao1;*.extensao2"
            // Aqui incluímos os formatos modernos (.xlsx) e os mais antigos (.xls).
            openFileDialog1.Filter = "Planilhas Excel (*.xlsx;*.xls)|*.xlsx;*.xls|Todos os arquivos (*.*)|*.*";

            // Abre a janela de seleção de arquivo e verifica se o usuário clicou em "OK"
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Se o usuário selecionou um arquivo e clicou em "OK",
                // pegamos o caminho completo do arquivo e o colocamos no nosso TextBox.
                txtCaminhoArquivo3.Text = openFileDialog1.FileName;
            }
        }

        private void btnAnexar3_Click(object sender, EventArgs e)
        {
            // Define o título da janela de seleção de arquivo
            openFileDialog1.Title = "Selecione uma planilha do Excel";

            // Define os filtros de arquivo para mostrar planilhas do Excel.
            // O formato é "Descrição Visível|*.extensao1;*.extensao2"
            // Aqui incluímos os formatos modernos (.xlsx) e os mais antigos (.xls).
            openFileDialog1.Filter = "Planilhas Excel (*.xlsx;*.xls)|*.xlsx;*.xls|Todos os arquivos (*.*)|*.*";

            // Abre a janela de seleção de arquivo e verifica se o usuário clicou em "OK"
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Se o usuário selecionou um arquivo e clicou em "OK",
                // pegamos o caminho completo do arquivo e o colocamos no nosso TextBox.
                txtCaminhoArquivo3.Text = openFileDialog1.FileName;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Esta linha fecha o formulário atual.
            this.Close();
        }
        // primeiro botçao de anexar arquivo

    }
}
