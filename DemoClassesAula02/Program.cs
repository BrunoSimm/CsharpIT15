Pessoa pessoa = new Pessoa("Bruno", 23);
Console.WriteLine(pessoa.Nome);
pessoa.Idade = 24;
Console.WriteLine(pessoa.Idade);

Produto p1 = new Produto("abc123", "Caderno", 12.99M);
Produto p2 = new Produto("abc223", "Caneta", 5.99M);

Venda v1 = new Venda { Cliente = pessoa, EntregaRealizada = false };
v1.AdicionarItem(p1);
v1.AdicionarItem(p2, 2);
Console.WriteLine(v1.Cliente.Nome);
Console.WriteLine(v1.EntregaRealizada);
Console.WriteLine(v1.Total);
Console.WriteLine(v1.QuantidadeProdutos);

for (int i = 0; i < v1.QuantidadeProdutos; i++)
{
    Console.WriteLine($"{v1[i].Descricao}");
}