using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Model
{
    public class Quilometragem
    {
        // Propriedades que correspondem às colunas do seu Excel.
        // Use os tipos de dados corretos (int, string, decimal, DateTime, etc.)
        public int idVagao { get; set; }
        public int Rodeiro { get; set; }
        public int km{ get; set; }

        // Opcional: Sobrescrever o método Equals para facilitar comparações
        // Isso é útil para encontrar itens idênticos em duas listas diferentes usando LINQ.
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Quilometragem outro = (Quilometragem)obj;
            return this.idVagao == outro.idVagao; // Dois produtos são considerados "iguais" se tiverem o mesmo ID.
        }

        public override int GetHashCode()
        {
            return this.idVagao.GetHashCode();
        }
    }


}

