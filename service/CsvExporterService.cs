using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace WinFormsApp2.service 
    {
        public class CsvExporterService
        {
            /// <summary>
            /// Exporta uma lista de objetos (de qualquer tipo, incluindo anônimos) para um arquivo CSV.
            /// </summary>
            /// <param name="dados">A lista de dados a ser exportada.</param>
            /// <param name="caminhoArquivo">O caminho completo onde o arquivo CSV será salvo.</param>
            public void ExportarParaCsv(List<dynamic> dados, string caminhoArquivo)
            {
                if (dados == null || !dados.Any())
                {
                    throw new ArgumentException("A lista de dados não pode ser nula ou vazia.", nameof(dados));
                }

                var sb = new StringBuilder();

                

                // Pega o primeiro objeto para descobrir as propriedades
                var primeiroItem = dados.First();
                Type tipoDoItem = primeiroItem.GetType();
                PropertyInfo[] propriedades = tipoDoItem.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                // Cria a linha do cabeçalho a partir dos nomes das propriedades
                sb.AppendLine(string.Join(";", propriedades.Select(p => p.Name)));

                // Adiciona as linhas de dados
                foreach (var item in dados)
                {
                    var linha = new List<string>();
                    foreach (var prop in propriedades)
                    {
                        // Pega o valor da propriedade para o item atual
                        object valorObj = prop.GetValue(item, null);
                        var valor = valorObj?.ToString() ?? "";

                        // Lógica para tratar valores que já contêm o separador ou aspas
                        if (valor.Contains(";") || valor.Contains("\""))
                        {
                            valor = $"\"{valor.Replace("\"", "\"\"")}\"";
                        }
                        linha.Add(valor);
                    }
                    sb.AppendLine(string.Join(";", linha));
                }

                // Escreve o conteúdo no arquivo, usando UTF-8 para garantir a compatibilidade com acentos
                File.WriteAllText(caminhoArquivo, sb.ToString(), Encoding.UTF8);
            }

        //futuramente aqui será inserida uma função que vai reaizar um filtro por algum
        //parâmetro de busca, sendo por família, rodeiro ou por outro parâmetro
        //retornando tudo a uma lista e ser exportado para. csv para exportação dos dados.
        }
    }