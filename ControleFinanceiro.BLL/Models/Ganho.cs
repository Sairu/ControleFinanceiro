using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.BLL.Models
{
    public class Ganho
    {
        public string GanhoId { get; set; }

        public string Descricao { get; set; }

        public string CategoriaId { get; set; }

        public Categoria Categorias { get; set; }

        public double Valor { get; set; }

        public int Dia { get; set; }

        public int MesId { get; set; }

        public Mes Mes { get; set; }

        public int Ano { get; set; }

        public string UsuarioID { get; set; }

        public Usuario usuario { get; set; }


    }
}
