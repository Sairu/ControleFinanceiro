using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.DALL.Mapeamento
{
    public class TipoMap : IEntityTypeConfiguration<Tipo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Tipo> builder)
        {
            builder.HasKey(t => t.TipoId);
            builder.Property(t => t.Nome).IsRequired().HasMaxLength(20);
            builder.HasMany(t => t.Categorias).WithOne(t => t.tipo);
            builder.HasData(
                new Tipo
                {
                    TipoId = 1,
                    Nome = "Despesa"
                },
                new Tipo
                {
                    TipoId = 2,
                    Nome = "Ganho"
                });
            builder.ToTable("Tipos");
        }
    }
}
