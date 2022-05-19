using System.ComponentModel.DataAnnotations;

public class Pessoa
{
    [Required]
    [StringLength(60, MinimumLength = 4)]
    public string Nome { get; set; } = null!;

    [Required]
    [Range(0, 120)]
    public int Idade { get; set; }

    [EmailAddress]
    [Required]
    public string Email { get; set; } = null!;
}