﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.BLL.Models
{
    public class Despesa
    {
        public int DespesaId { get; set; }

        public int CartaoId { get; set; }

        public Cartao cartao { get; set; }

        public string Descricao { get; set; }

        public int CategoriaID { get; set; }

        public Categoria Categorias { get; set; }

        public double Valor { get; set; }

        public int Dia { get; set; }

        public int MesId { get; set; }

        public Mes Mes { get; set; }

        public int ano { get; set; }

        public string UsuarioId { get; set; }

        public Usuario usuario { get; set; }
    }
}