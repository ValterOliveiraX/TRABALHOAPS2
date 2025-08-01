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
using WinFormsApp2.Model;
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
                var caminhoTape = SelecionarArquivo("Selecione a planilha de Tape dos Rodeiros (.xlsx)");
                var caminhoKm = SelecionarArquivo("Selecione a planilha de Quilometragem (.xlsx)");
                var caminhoNotas = SelecionarArquivo("Selecione a planilha de Notas de Manutenção (.xlsx)");

                if (string.IsNullOrEmpty(caminhoLotes) || string.IsNullOrEmpty(caminhoTape) ||
                    string.IsNullOrEmpty(caminhoKm) || string.IsNullOrEmpty(caminhoNotas))
                {
                    lblStatus.Text = "Processo cancelado pelo usuário.";
                    return;
                }

                lblStatus.Text = "Lendo e processando dados...";
                this.Cursor = Cursors.WaitCursor;

                var lotes = LerXlsx<LoteSequencia>(caminhoLotes);
                var tapes = LerXlsx<TapeRodeiro>(caminhoTape);
                var quilometragens = LerXlsx<QuilometragemRodeiro>(caminhoKm);
                var notasManutencao = LerXlsx<NotaManutencao>(caminhoNotas);

                var dadosUnidos = from lote in lotes
                                  join km in quilometragens on lote.Id equals km.Id
                                  join tape in tapes on lote.Id equals tape.Id
                                  join nota in notasManutencao on lote.Id equals nota.Id into notasGroup
                                  from n in notasGroup.DefaultIfEmpty()
                                  select new
                                  {
                                      lote.Id,
                                      lote.Lote,
                                      lote.Vagao,
                                      lote.Rodeiro,
                                      lote.Sequencia,
                                      tape.Tape,
                                      km.Quilometragem,
                                      NotaDeManutencao = n?.NotaDeManutencao
                                  };

                var dadosFiltrados = dadosUnidos
                    .Where(d => d.Quilometragem < 100000 && string.IsNullOrEmpty(d.NotaDeManutencao))
                    .ToList();

                dgvResultados.DataSource = dadosFiltrados;
                lblStatus.Text = $"Processamento concluído. {dadosFiltrados.Count} registros encontrados.";
                this.Cursor = Cursors.Default;
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

        // ===================================================================
        // FUNÇÃO DE LEITURA COM A CORREÇÃO PARA O ERRO "INDEX OUT OF RANGE"
        // ===================================================================

        public List<T> LerXlsx<T>(string caminhoArquivo) where T : new()
        {
            var lista = new List<T>();
            var fileInfo = new FileInfo(caminhoArquivo);

            using (var package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets.FirstOrDefault();
                if (worksheet == null) throw new Exception($"Nenhuma planilha encontrada no arquivo: {caminhoArquivo}");

                var headers = worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column]
                                       .Select(cell => cell.Text.Trim().Replace(" ", ""))
                                       .ToList();

                for (int rowNum = 2; rowNum <= worksheet.Dimension.End.Row; rowNum++)
                {
                    var obj = new T();
                    var properties = typeof(T).GetProperties();

                    for (int colNum = 1; colNum <= worksheet.Dimension.End.Column; colNum++)
                    {
                        // VERIFICAÇÃO DE SEGURANÇA: Só processa se o índice do cabeçalho for válido
                        if (colNum - 1 < headers.Count)
                        {
                            var header = headers[colNum - 1];
                            var property = properties.FirstOrDefault(p => p.Name.Equals(header, StringComparison.OrdinalIgnoreCase));

                            if (property != null)
                            {
                                var cellValue = worksheet.Cells[rowNum, colNum].Value;
                                if (cellValue != null)
                                {
                                    try
                                    {
                                        var convertedValue = Convert.ChangeType(cellValue, property.PropertyType);
                                        property.SetValue(obj, convertedValue);
                                    }
                                    catch (FormatException)
                                    {
                                        property.SetValue(obj, cellValue.ToString());
                                    }
                                }
                            }
                        }
                    }
                    lista.Add(obj);
                }
            }
            return lista;
        }
    }

    // ===================================================================
    // LEMBRETE IMPORTANTE SOBRE AS CLASSES E NOMES DE COLUNAS
    // ===================================================================
    // O nome da propriedade na classe C# deve ser o mesmo do cabeçalho no Excel, mas SEM ESPAÇOS.
    // Ex: Coluna "Nota de manutenção" no Excel -> Propriedade "NotaDeManutencao" no C#
    // Classes com os tipos de dados corrigidos
    public class LoteSequencia
    {
        public string Id { get; set; }
        public string Lote { get; set; }
        public int Vagao { get; set; }
        public string Rodeiro { get; set; }
        public int Sequencia { get; set; }
    }

    public class TapeRodeiro
    {
        public string Id { get; set; }
        public int Vagao { get; set; }
        public string Rodeiro { get; set; }
        public int Tape { get; set; }
    }

    public class QuilometragemRodeiro
    {
        public string Id { get; set; }
        public int Vagao { get; set; }
        public string Rodeiro { get; set; }
        public int Quilometragem { get; set; }
    }

    public class NotaManutencao
    {
        public string Id { get; set; }
        public int Vagao { get; set; }
        public string Rodeiro { get; set; }
        public string NotaDeManutencao { get; set; }
    }
}