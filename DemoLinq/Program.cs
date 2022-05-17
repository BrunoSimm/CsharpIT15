List<Pessoa> pessoas = new List<Pessoa> {
    new Pessoa { Casada = true, Nome = "Bruno0", DataNascimento = new DateTime(1980, 12, 12) },
    new Pessoa { Casada = false, Nome = "Bruno1", DataNascimento = new DateTime(1998,08,05) },
    new Pessoa { Casada = true, Nome = "Bruno2", DataNascimento = new DateTime(2002,3,10) },
    new Pessoa { Casada = false, Nome = "Bruno3", DataNascimento = new DateTime(1974,10,8) },
};

var linq1 = from p in pessoas
            where p.Casada == false
            select p;
foreach (var item in linq1)
{
    Console.WriteLine(item);
}

var linq2 = pessoas.Where(p => p.Casada == true).Select(p => p.Nome);
foreach (var item in linq2)
{
    Console.WriteLine(item);
}