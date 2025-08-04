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
        private List<dynamic> resultadosCompletos = new List<dynamic>();

        public Form1()
        {
            InitializeComponent();
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Linha da licença para a versão 6.x do EPPlus.
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
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

                // Guarda os resultados completos em nossa variável global
                resultadosCompletos = resultados as List<dynamic>;


                // 3. Exibe os resultados na tela
                dgvResultados.DataSource = resultados;
                dgvResultados.DataSource = resultadosCompletos;
                var contagem = (resultados as System.Collections.IList).Count;
                lblStatus.Text = $"Processamento concluído. {contagem} registros encontrados.";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}\n\nVerifique se os arquivos não estão abertos no Excel e se as colunas estão corretas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Ocorreu um erro durante o processamento.";
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        // fim da main
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

        // NOVO: Evento de filtro em tempo real
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            // Se não houver resultados, não faz nada
            if (resultadosCompletos == null || !resultadosCompletos.Any()) return;

            string textoFiltro = txtFiltro.Text.ToLower().Trim();

            // Se o filtro está vazio, mostra todos os resultados
            if (string.IsNullOrEmpty(textoFiltro))
            {
                dgvResultados.DataSource = resultadosCompletos;
            }
            else // Caso contrário, aplica o filtro
            {
                var dadosFiltrados = resultadosCompletos.Where(r =>
                       r.Id.ToString().ToLower().Contains(textoFiltro)
                    || r.Lote.ToString().ToLower().Contains(textoFiltro)
                    || r.Vagao.ToString().ToLower().Contains(textoFiltro)
                    || r.Rodeiro.ToString().ToLower().Contains(textoFiltro)
                ).ToList();

                dgvResultados.DataSource = dadosFiltrados;
            }
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            List<dynamic> dadosParaExportar;
            string textoFiltro = txtFiltro.Text.ToLower().Trim();

            // 1. Reconstrói a lista a ser exportada com base no filtro atual
            if (string.IsNullOrEmpty(textoFiltro))
            {
                // Se não há filtro, usa a lista completa
                dadosParaExportar = resultadosCompletos;
            }
            else
            {
                // Se há filtro, aplica a mesma lógica de filtro novamente
                dadosParaExportar = resultadosCompletos.Where(r =>
                       r.Id.ToString().ToLower().Contains(textoFiltro)
                    || r.Lote.ToString().ToLower().Contains(textoFiltro)
                    || r.Vagao.ToString().ToLower().Contains(textoFiltro)
                    || r.Rodeiro.ToString().ToLower().Contains(textoFiltro)
                ).ToList();
            }

            // 2. Agora a verificação funciona corretamente
            if (dadosParaExportar == null || !dadosParaExportar.Any())
            {
                MessageBox.Show("Não há dados na tabela para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivo Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Salvar arquivo Excel";
                saveFileDialog.FileName = $"Rodeiros_Filtrados_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        ExportarParaExcel(dadosParaExportar, saveFileDialog.FileName);
                        MessageBox.Show("Dados exportados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao exportar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.Cursor = Cursors.Default;
                    }
                }
            }
        }

        // NOVO: Método auxiliar que cria o arquivo Excel
        private void ExportarParaExcel(List<dynamic> dados, string caminho)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Garante a licença

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Resultados");

                // Escreve os dados na planilha, começando da célula A1
                worksheet.Cells["A1"].LoadFromCollection(dados, true);

                // Formata o cabeçalho
                using (var range = worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                {
                    range.Style.Font.Bold = true;
                    range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                }

                // Ajusta a largura das colunas
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Salva o arquivo
                File.WriteAllBytes(caminho, package.GetAsByteArray());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}