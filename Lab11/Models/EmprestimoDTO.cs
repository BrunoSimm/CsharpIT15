namespace Lab11.Models;

public class EmprestimoDTO
{
    public string TituloLivro { get; set; } = null!;
    public DateTime DataRetirada { get; set; }
    public DateTime DataDevolucao { get; set; }
    public double Multa { get; set; }
}