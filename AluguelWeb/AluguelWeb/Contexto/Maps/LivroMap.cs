using AluguelWeb.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelWeb.Contexto.Maps
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("livro", "dbo_aluguel");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id).HasColumnName("cd_livro");

            builder.Property(f => f.Nome).HasColumnName("nm_livro");

            builder.Property(f => f.AutorID).HasColumnName("cd_autor");

            builder.HasOne(s => s.Autor).WithMany().HasForeignKey(e => e.AutorID).IsRequired();

            builder.Property(f => f.EditoraID).HasColumnName("cd_editora");

            builder.HasOne(s => s.Editora).WithMany().HasForeignKey(e => e.EditoraID).IsRequired();

            builder.Property(f => f.Status).HasColumnName("st_livro");
        }
    }
}
