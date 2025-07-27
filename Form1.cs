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
            // Define o título da janela de seleção de arquivo
            openFileDialog1.Title = "Selecione um arquivo";

            // Define os filtros de arquivo. O usuário só poderá ver e selecionar esses tipos.
            // Formato: "Descrição|*.extensao1;*.extensao2|Outra Descrição|*.extensao3"
            openFileDialog1.Filter = "Documentos PDF (*.pdf)|*.pdf|Documentos Word (*.docx)|*.docx|Todos os arquivos (*.*)|*.*";

            // Abre a janela de seleção de arquivo e verifica se o usuário clicou em "OK"
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Se o usuário selecionou um arquivo e clicou em "OK",
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
            // Define o título da janela de seleção de arquivo
            openFileDialog1.Title = "Selecione um arquivo";

            // Define os filtros de arquivo. O usuário só poderá ver e selecionar esses tipos.
            // Formato: "Descrição|*.extensao1;*.extensao2|Outra Descrição|*.extensao3"
            openFileDialog1.Filter = "Documentos PDF (*.pdf)|*.pdf|Documentos Word (*.docx)|*.docx|Todos os arquivos (*.*)|*.*";

            // Abre a janela de seleção de arquivo e verifica se o usuário clicou em "OK"
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Se o usuário selecionou um arquivo e clicou em "OK",
                // pegamos o caminho completo do arquivo e o colocamos no nosso TextBox.
                txtCaminhoArquivo2.Text = openFileDialog1.FileName;
            }
        }

        private void btnAnexar3_Click(object sender, EventArgs e)
        {
            // Define o título da janela de seleção de arquivo
            openFileDialog1.Title = "Selecione um arquivo";

            // Define os filtros de arquivo. O usuário só poderá ver e selecionar esses tipos.
            // Formato: "Descrição|*.extensao1;*.extensao2|Outra Descrição|*.extensao3"
            openFileDialog1.Filter = "Documentos PDF (*.pdf)|*.pdf|Documentos Word (*.docx)|*.docx|Todos os arquivos (*.*)|*.*";

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
        // primeiro botçao de anexar arquivo

    }
}
