using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Model
{
    public class Lotes
    {
        // Propriedades que correspondem às colunas do seu Excel.
        // Use os tipos de dados corretos (int, string, decimal, DateTime, etc.)
        public int idLote { get; set; }
        public int lote { get; set; }
        public int Vagao { get; set; }
        public string Rodeiro { get; set; }
        public string Sequencia { get; set; }

        // Opcional: Sobrescrever o método Equals para facilitar comparações
    // Isso é útil para encontrar itens idênticos em duas listas diferentes usando LINQ.
    public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Lotes outro = (Lotes)obj;
            return this.idLote == outro.idLote; // Dois produtos são considerados "iguais" se tiverem o mesmo ID.
        }
        public override int GetHashCode()
        {
            return this.idLote.GetHashCode();
        }
    }
}
