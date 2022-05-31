namespace Lab11.Models;

public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; } = null!;
    public ICollection<Autor> Autores { get; set; } = null!;
    public IEnumerable<Emprestimo> Emprestimos { get; set; } = null!;
}