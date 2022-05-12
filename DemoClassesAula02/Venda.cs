public class Venda
{
    public Pessoa Cliente { get; init; }
    public bool EntregaRealizada { get; set; }
    private List<ItemDeVenda> itensDeVenda = new List<ItemDeVenda>();
    public int QuantidadeProdutos => itensDeVenda.Count;
    public Produto this[int i] => itensDeVenda[i].Produto; //indexador
    public decimal Total
    {
        get
        {
            decimal total = 0;
            foreach (ItemDeVenda item in this.itensDeVenda)
            {
                total += item.SubTotal;
            }
            return total;
        }
    }

    public void AdicionarItem(Produto produto, int quantidade)
    {
        itensDeVenda.Add(new ItemDeVenda(produto, quantidade));
    }

    //overload default method impl
    public void AdicionarItem(Produto produto)
    {
        itensDeVenda.Add(new ItemDeVenda(produto, 1));
    }

    private class ItemDeVenda
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal SubTotal
        {
            get
            {
                return Quantidade * Produto.ValorUnitaio;
            }
        }
        public ItemDeVenda(Produto produto, int qtd)
        {
            Produto = produto;
            Quantidade = qtd;
        }
    }
}