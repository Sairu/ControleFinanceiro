using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.BLL.Models
{
    public class Categoria
    {
        public string CategoriaId { set; get; }

        public string Nome { get; set; }

        public string Icone { get; set; }

        public int TipoId { get; set; }

        public Tipo tipo { get; set; }
        public object Tipo { get; set; }
        public virtual ICollection<Despesa> Despesas { get; set; }

        public virtual ICollection<Ganho> Ganhos { get; set; }


    }
}
