Pessoa pessoa = new Pessoa("Bruno", 23);
Console.WriteLine(pessoa.Nome);
pessoa.Idade = 24;
Console.WriteLine(pessoa.Idade);

Venda v1 = new Venda { Cliente = pessoa, EntregaRealizada = false };
Console.WriteLine(v1.Cliente.Nome);
Console.WriteLine(v1.EntregaRealizada);