using AluguelWeb.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelWeb.Contexto.Maps
{
    public class EmprestimoMap : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("emprestimo", "dbo_aluguel");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id).HasColumnName("cd_emprestimo");

            builder.Property(f => f.LivroID).HasColumnName("cd_livro");

            builder.HasOne(s => s.Livro).WithMany().HasForeignKey(e => e.LivroID).IsRequired();

            builder.Property(f => f.ClienteID).HasColumnName("cd_cliente");

            builder.HasOne(s => s.Cliente).WithMany().HasForeignKey(e => e.ClienteID).IsRequired();

            builder.Property(f => f.DataEmprestimo).HasColumnName("dt_emrpestimo");

            builder.Property(f => f.PreviaDevolucao).HasColumnName("pv_devolucao");
        }
    }
}
