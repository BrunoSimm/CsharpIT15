using Microsoft.EntityFrameworkCore;

namespace Lab11.Models
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>(entityBuilder =>
            {
                entityBuilder.Property(e => e.PrimeiroNome).HasMaxLength(30);
                entityBuilder.Property(e => e.UltimoNome).HasMaxLength(30);
            });

            modelBuilder.Entity<Livro>(entityBuilder =>
            {
                entityBuilder.Property(e => e.Titulo).HasMaxLength(100);
            });
        }
    }
}