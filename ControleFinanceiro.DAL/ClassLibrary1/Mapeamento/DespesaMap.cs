using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.DALL.Mapeamento
{
    public class DespesaMap : IEntityTypeConfiguration<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> builder)
        {
            builder.HasKey(d => d.DespesaId);

            builder.Property(d => d.Descricao).IsRequired().HasMaxLength(20);

            builder.Property(d => d.Valor).IsRequired();
            builder.Property(d => d.Dia).IsRequired();
            builder.Property(d => d.ano).IsRequired();

            builder.HasOne(d => d.cartao).WithMany(d => d.Despesas).HasForeignKey(d => d.DespesaId).IsRequired();
            builder.HasOne(d => d.Categoria).WithMany(d => d.Despesas).HasForeignKey(d => d.CategoriaId).IsRequired();
            builder.HasOne(d => d.Mes).WithMany(d => d.Despesas).HasForeignKey(d => d.MesId).IsRequired();
            builder.HasOne(d => d.usuario).WithMany(d => d.Despesas).HasForeignKey(d => d.UsuarioId).IsRequired();

            builder.ToTable("despesas");

        }
    }
}
