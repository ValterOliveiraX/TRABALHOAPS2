// Arquivo: RodeiroService.cs

using OfficeOpenXml;
using System;
using System.Linq;

namespace WinFormsApp2.View
{
    public class RodeiroService
    {
        public RodeiroService()
        {
            // A configuração da licença pode ficar aqui.
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public object ProcessarArquivosRodeiro(string caminhoLotes, string caminhoTape, string caminhoKm, string caminhoNotas)
        {
            // 1. Usa o Leitor de Dados para carregar as informações
            var lotes = ExcelDataReader.LerXlsx<LoteSequencia>(caminhoLotes);
            var tapes = ExcelDataReader.LerXlsx<TapeRodeiro>(caminhoTape);
            var quilometragens = ExcelDataReader.LerXlsx<QuilometragemRodeiro>(caminhoKm);
            var notasManutencao = ExcelDataReader.LerXlsx<NotaManutencao>(caminhoNotas);

            // 2. Executa a lógica de negócio (união e filtro)
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
                                  n?.NotaDeManutencao
                              };

            var dadosFiltrados = dadosUnidos
                .Where(d => d.Quilometragem < 100000 && string.IsNullOrEmpty(d.NotaDeManutencao))
                .ToList();

            // 3. Retorna o resultado final
            return dadosFiltrados;
        }
    }
}