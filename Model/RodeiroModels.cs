// Arquivo: RodeiroModels.cs

namespace WinFormsApp2.Model // Certifique-se de que o namespace é o mesmo do seu projeto
{
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