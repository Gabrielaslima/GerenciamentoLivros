using AluguelWeb.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelWeb.Contexto.Maps
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("autor", "dbo_aluguel");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id).HasColumnName("cd_autor");

            builder.Property(f => f.Nome).HasColumnName("nm_autor");

            builder.Property(f => f.Cpf).HasColumnName("cpf_autor");
        }
    }
}
