namespace DemoEFCoreConsole.Models;

using Microsoft.EntityFrameworkCore;

public class FilmesDbContext : DbContext
{
    public DbSet<Filme> Filmes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Filme>(entity =>
        {
            entity.Property(e => e.Titulo).HasMaxLength(50);
            //entity.Property(e => e.Ano).HasDefaultValue(1950);
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        // optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=ITEF;Integrated Security=True");
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ITEF;Integrated Security=True");
        optionsBuilder.EnableSensitiveDataLogging().LogTo(Console.WriteLine); //Loga para o console tudo que EF executar.
    }

}