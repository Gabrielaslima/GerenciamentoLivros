using AluguelWeb.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelWeb.Contexto.Maps
{
    public class EditoraMap : IEntityTypeConfiguration<Editora>
    {
        public void Configure(EntityTypeBuilder<Editora> builder)
        {
            builder.ToTable("editora", "dbo_aluguel");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id).HasColumnName("cd_editora");

            builder.Property(f => f.Nome).HasColumnName("nm_editora");

            builder.Property(f => f.Cnpj).HasColumnName("cnpj_editora");
        }

    }
}
