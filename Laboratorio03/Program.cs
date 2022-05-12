List<string> listaStrings = new List<string>();
listaStrings.Add("um");
listaStrings.Add("hello");
listaStrings.Add("world");
Console.WriteLine(listaStrings[0]);

// 2 - Queue
//2.1
Queue<Object> q = new Queue<object>();
q.Enqueue(".net framework");
q.Enqueue(new Decimal(123.456));
q.Enqueue(654.321);
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());
//2.2
Queue<int> minhaFila = new Queue<int>();
minhaFila.Enqueue(10);
minhaFila.Enqueue(20);
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());

//3 - Dicionary
Dictionary<int, string> paises = new Dictionary<int, string>();
paises[44] = "Reino Unido";
paises[33] = "França";
paises.Add(55, "Brasil");
Console.WriteLine($"O código 55 é: {paises[55]}");
foreach (KeyValuePair<int, string> pais in paises)
{
    Console.WriteLine($"Código {pais.Key} = {pais.Value}");
}

// 4 - Exercicios
// 4.1
Console.WriteLine("4.1:");
Console.WriteLine(paises.FirstOrDefault(pais => pais.Value == "Brasil").Key);

//4.2 
Console.WriteLine("4.2:");
List<decimal> nrReais = new List<decimal> { 1, 5, 10, 20, 30 };
Console.WriteLine($"Total de elementos acima da média: {totalAcimaMedia(nrReais)}");

int totalAcimaMedia(List<decimal> nrReias)
{
    decimal media = nrReais.Average();
    Console.WriteLine($"Media: {media}");
    int nrElementos = 0;

    foreach (var nr in nrReais)
    {
        if (nr > media)
        {
            nrElementos++;
        }
    }

    return nrElementos;
}
//4.3
Console.WriteLine("4.3:");
List<decimal> nrsAcimaMedia = new List<decimal>();
nrsAcimaMedia = ListaAcimaMedia(nrReais);
nrsAcimaMedia.ForEach(nr => Console.WriteLine(nr));

List<decimal> ListaAcimaMedia(List<decimal> nrReias)
{
    List<decimal> listaAcimaMedia = new List<decimal>();
    decimal media = nrReais.Average();
    Console.WriteLine($"Media: {media}");

    foreach (var nr in nrReais)
    {
        if (nr > media)
        {
            listaAcimaMedia.Add(nr);
        }
    }

    return listaAcimaMedia;
}



