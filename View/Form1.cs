using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using WinFormsApp2.Model; -> exempo de cmo se deve chamar uma classe externa
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LicenseContext = OfficeOpenXml.LicenseContext;
namespace WinFormsApp2.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // Linha da licença para a versão 6.x do EPPlus.
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Selecionando arquivos...";
                var caminhoLotes = SelecionarArquivo("Selecione a planilha de Lotes com Sequência (.xlsx)");
                Arq1.Text = caminhoLotes.ToString();
                var caminhoTape = SelecionarArquivo("Selecione a planilha de Tape dos Rodeiros (.xlsx)");
                Arq2.Text = caminhoTape.ToString();
                var caminhoKm = SelecionarArquivo("Selecione a planilha de Quilometragem (.xlsx)");
                Arq3.Text = caminhoKm.ToString();
                var caminhoNotas = SelecionarArquivo("Selecione a planilha de Notas de Manutenção (.xlsx)");
                Arq4.Text = caminhoNotas.ToString();

                if (string.IsNullOrEmpty(caminhoLotes) || string.IsNullOrEmpty(caminhoTape) ||
                    string.IsNullOrEmpty(caminhoKm) || string.IsNullOrEmpty(caminhoNotas))
                {
                    lblStatus.Text = "Processo cancelado pelo usuário.";
                    return;
                }

                lblStatus.Text = "Lendo e processando dados...";
                this.Cursor = Cursors.WaitCursor;

                // 1. Cria uma instância do nosso serviço de negócio
                var servico = new RodeiroService();

                // 2. Chama o método do serviço, delegando todo o trabalho
                var resultados = servico.ProcessarArquivosRodeiro(caminhoLotes, caminhoTape, caminhoKm, caminhoNotas);

                // 3. Exibe os resultados na tela
                dgvResultados.DataSource = resultados;
                var contagem = (resultados as System.Collections.IList).Count;
                lblStatus.Text = $"Processamento concluído. {contagem} registros encontrados.";



            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show($"Ocorreu um erro: {ex.Message}\n\nVerifique se os arquivos não estão abertos no Excel e se as colunas estão corretas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Ocorreu um erro durante o processamento.";
            }
        }

        private string SelecionarArquivo(string titulo)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = titulo;
                openFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return string.Empty;
        }

        private void Arq3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelVagoes_Paint(object sender, PaintEventArgs e)
        {

        }

        // ===================================================================
        // FUNÇÃO PARA CRIAR A INTERFACE GRÁFICA NO GRID DO PROGRAMA.
        // ===================================================================
        private void PopularGridDeVagoes(List<dynamic> resultados)
        {
            // 1. Limpa o painel de qualquer resultado anterior
            flowLayoutPanelVagoes.Controls.Clear();

            if (resultados == null || !resultados.Any()) return;

            // 2. Agrupa os resultados por Vagão
            var vagoesAgrupados = resultados
                .GroupBy(r => r.Vagao)
                .OrderBy(g => g.Key); // Ordena pelo número do vagão

            // 3. Para cada grupo (vagão), cria um card
            foreach (var grupoVagao in vagoesAgrupados)
            {
                // Cria um GroupBox para representar o vagão
                GroupBox cardVagao = new GroupBox();
                cardVagao.Text = $"Vagão: {grupoVagao.Key}"; // Título do card
                cardVagao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                cardVagao.Size = new Size(180, 70); // Tamanho do card
                cardVagao.Margin = new Padding(5); // Espaçamento entre os cards

                // Cria uma Label para mostrar os detalhes dentro do card
                Label detalhesLabel = new Label();
                detalhesLabel.Text = $"Rodeiros filtrados: {grupoVagao.Count()}";
                detalhesLabel.Dock = DockStyle.Fill; // Ocupa todo o espaço do card
                detalhesLabel.TextAlign = ContentAlignment.MiddleCenter;
                detalhesLabel.Font = new Font("Segoe UI", 10F);

                // Adiciona a label dentro do GroupBox
                cardVagao.Controls.Add(detalhesLabel);

                // 4. Adiciona o card pronto ao FlowLayoutPanel
                flowLayoutPanelVagoes.Controls.Add(cardVagao);
            }
        }
    }
}