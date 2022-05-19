public class ViaCepResposta
{
    public string? Cep { get; set; }
    public string? Logradouro { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string? Localidade { get; set; }
    public string? UF { get; set; }


    public override string ToString()
    {
        return base.ToString() + $": {Cep}, {Logradouro}, {Complemento}, {Bairro}, {Localidade}, {UF}.";
    }

}