namespace Lab11.Models;

public class Autor
{
    public int Id { get; set; }
    public string PrimeiroNome { get; set; } = null!;
    public string UltimoNome { get; set; } = null!;
    public ICollection<Livro> Livros { get; set; } = null!;
}