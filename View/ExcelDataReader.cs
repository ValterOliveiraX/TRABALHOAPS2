// Arquivo: ExcelDataReader.cs

using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WinFormsApp2.View
{
    public class ExcelDataReader
    {
        // Este método agora vive aqui, isolado e com uma única responsabilidade.
        public static List<T> LerXlsx<T>(string caminhoArquivo) where T : new()
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
}