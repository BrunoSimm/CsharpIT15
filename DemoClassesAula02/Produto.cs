public class Produto
{
    public string Id { get; set; }
    public string Descricao { get; set; }
    public decimal ValorUnitaio { get; set; }

    public Produto(string id, string descricao, decimal valorUnitario)
    {
        this.Id = id;
        this.Descricao = descricao;
        this.ValorUnitaio = valorUnitario;
    }

}