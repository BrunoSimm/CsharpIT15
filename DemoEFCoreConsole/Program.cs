using DemoEFCoreConsole.Models;

public class Program
{
    private static void Main(string[] args)
    {
        using (var context = new FilmesDbContext()) //Ao final do bloco, a instancia é eliminada.
        {
            // Filme newFilme = new Filme() { Titulo = $"TITULO{new Random().Next()}", Ano = new Random().Next(), Duracao = new Random().Next(), Diretor = "DIRECTOR" };
            // context.Add(newFilme);
            // context.SaveChanges();

            var umFilme = context.Filmes.Find(2);
            if (umFilme is not null)
            {
                umFilme.Duracao = 30;
                context.Filmes.Remove(umFilme);
                context.SaveChanges();
            }



            List<Filme> filmes = context.Filmes.OrderBy(f => f.Ano).ToList();
            filmes.ForEach(filme => Console.WriteLine(filme));
        }
    }
}