using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Define o t�tulo da janela de sele��o de arquivo
            openFileDialog1.Title = "Selecione um arquivo";

            // Define os filtros de arquivo. O usu�rio s� poder� ver e selecionar esses tipos.
            // Formato: "Descri��o|*.extensao1;*.extensao2|Outra Descri��o|*.extensao3"
            openFileDialog1.Filter = "Documentos PDF (*.pdf)|*.pdf|Documentos Word (*.docx)|*.docx|Todos os arquivos (*.*)|*.*";

            // Abre a janela de sele��o de arquivo e verifica se o usu�rio clicou em "OK"
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Se o usu�rio selecionou um arquivo e clicou em "OK",
                // pegamos o caminho completo do arquivo e o colocamos no nosso TextBox.
                txtCaminhoArquivo.Text = openFileDialog1.FileName;
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
            // Define o t�tulo da janela de sele��o de arquivo
            openFileDialog1.Title = "Selecione um arquivo";

            // Define os filtros de arquivo. O usu�rio s� poder� ver e selecionar esses tipos.
            // Formato: "Descri��o|*.extensao1;*.extensao2|Outra Descri��o|*.extensao3"
            openFileDialog1.Filter = "Documentos PDF (*.pdf)|*.pdf|Documentos Word (*.docx)|*.docx|Todos os arquivos (*.*)|*.*";

            // Abre a janela de sele��o de arquivo e verifica se o usu�rio clicou em "OK"
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Se o usu�rio selecionou um arquivo e clicou em "OK",
                // pegamos o caminho completo do arquivo e o colocamos no nosso TextBox.
                txtCaminhoArquivo2.Text = openFileDialog1.FileName;
            }
        }

        private void btnAnexar3_Click(object sender, EventArgs e)
        {
            // Define o t�tulo da janela de sele��o de arquivo
            openFileDialog1.Title = "Selecione um arquivo";

            // Define os filtros de arquivo. O usu�rio s� poder� ver e selecionar esses tipos.
            // Formato: "Descri��o|*.extensao1;*.extensao2|Outra Descri��o|*.extensao3"
            openFileDialog1.Filter = "Documentos PDF (*.pdf)|*.pdf|Documentos Word (*.docx)|*.docx|Todos os arquivos (*.*)|*.*";

            // Abre a janela de sele��o de arquivo e verifica se o usu�rio clicou em "OK"
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Se o usu�rio selecionou um arquivo e clicou em "OK",
                // pegamos o caminho completo do arquivo e o colocamos no nosso TextBox.
                txtCaminhoArquivo3.Text = openFileDialog1.FileName;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        // primeiro bot�ao de anexar arquivo

    }
}
