List<Pessoa> pessoas = new List<Pessoa>
{
 new Pessoa{Nome="Ana",DataNascimento=new DateTime(1980,3,14), Casada=true},
 new Pessoa{Nome="Paulo",DataNascimento=new DateTime(1978,10,23), Casada=true},
 new Pessoa{Nome="Maria",DataNascimento=new DateTime(2000,1,10), Casada=false},
 new Pessoa{Nome="Carlos",DataNascimento=new DateTime(1999,12,12), Casada=false}
};

var linq1 =
 from p in pessoas
 where p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1)
 select p;

foreach (var pessoa in linq1)
{
    Console.WriteLine(pessoa);
}

var linq2 = pessoas.Where(p => p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1));
foreach (var pessoa in linq2)
{
    Console.WriteLine(pessoa);
}


// Ex1 -  Construa uma consulta que retorne as pessoas agrupadas em casadas e solteiras e também o número de 
// pessoas casadas e solteiras.
var linq3 = pessoas.GroupBy(
    pessoa => pessoa.Casada,
    pessoa => pessoa.Nome,
    (casada, nome) => new
    {
        Key = casada,
        Count = nome.Count(),
        Nomes = nome
    });

foreach (var pessoa in linq3)
{
    Console.WriteLine($"Casada: {pessoa.Key}");
    foreach (string nome in pessoa.Nomes)
        Console.WriteLine("  {0}", nome);
}

// 2. Construa uma consulta que retorne a pessoa mais velha.
var linq4 = pessoas.MinBy(pessoa => pessoa.DataNascimento);
Console.WriteLine($"Pessoa mais velha: {linq4.Nome}");

// 3. Construa uma consulta que retorne a pessoa solteira mais nova.
var linq5 = pessoas.Where(p => p.Casada == false).MaxBy(pessoa => pessoa.DataNascimento);
Console.WriteLine($"Solteira mais nova: {linq5.Nome}");