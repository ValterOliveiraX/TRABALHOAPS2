using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Model
{
    public class NotasManutencao
    {
        public int idVagao { get; set; }
        public int Rodeio { get; set; }
        public string  NotaManutencao { get; set; }
        public int Tape { get; set; }
    
            // Opcional: Sobrescrever o método Equals para facilitar comparações
    // Isso é útil para encontrar itens idênticos em duas listas diferentes usando LINQ.
    public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            NotasManutencao outro = (NotasManutencao)obj;
            return this.idVagao == outro.idVagao; // Dois produtos são considerados "iguais" se tiverem o mesmo ID.
        }
        public override int GetHashCode()
        {
            return this.idVagao.GetHashCode();
        }
    }
}
