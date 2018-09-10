using AluguelWeb.Contexto.Maps;
using AluguelWeb.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AluguelWeb.Contexto
{
    public class AluguelContexto : DbContext
    {
        public AluguelContexto(DbContextOptions<AluguelContexto> options)
        : base(options)
        { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new AutorMap());
            modelBuilder.ApplyConfiguration(new EditoraMap());
            modelBuilder.ApplyConfiguration(new LivroMap());
            modelBuilder.ApplyConfiguration(new EmprestimoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}