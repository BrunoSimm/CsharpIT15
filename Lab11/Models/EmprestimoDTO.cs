namespace Lab11.Models;

using System.ComponentModel.DataAnnotations;

public class EmprestimoDTO
{
    public string TituloLivro { get; set; } = null!;
    public DateTime DataRetirada { get; set; }
    public DateTime DataDevolucao { get; set; }
}