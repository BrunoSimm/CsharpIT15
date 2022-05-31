namespace Lab11.Models;

using System.ComponentModel.DataAnnotations;


public class AutorLivrosEmprestimosDTO
{
    public string NomeAutor { get; set; }
    public List<LivrosEmprestimos> Livros { get; set; }

    public AutorLivrosEmprestimosDTO(string primeiroNome, string ultimoNome)
    {
        NomeAutor = $"{primeiroNome} {ultimoNome}";
        Livros = new List<LivrosEmprestimos>();
    }

    public void AddListEmprestimo(Livro livro, bool disponivel, DateTime? dataEntrega)
    {
        Livros.Add(new LivrosEmprestimos { Id = livro.Id, Titulo = livro.Titulo, Disponivel = disponivel, DataEntrega = dataEntrega });
    }
}

public class LivrosEmprestimos
{
    public int Id { get; set; }
    public string Titulo { get; set; } = null!;
    public bool Disponivel { get; set; }
    public DateTime? DataEntrega { get; set; }
}