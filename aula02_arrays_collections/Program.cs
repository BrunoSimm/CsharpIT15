// using System.Text;

// StringBuilder sb1 = new StringBuilder("teste");
// StringBuilder sb2 = sb1;

// sb1.Append(" alterado");
// Console.WriteLine(sb1);
// Console.WriteLine(sb2);

// sb2.Append(" novamente");
// Console.WriteLine(sb1);
// Console.WriteLine(sb2);

// Arrays -> do not change length
// https://docs.microsoft.com/en-us/dotnet/api/system.array?view=net-6.0#methods
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
int[] numeros = new int[5];
numeros[0] = 10;
numeros[1] = 25;

// foreach (int number in numeros)
// {
//     Console.WriteLine(number);
// }


// int[,] matriz = new int[2, 2];
// matriz[0, 0] = 250;
// matriz[0, 1] = 100;
// matriz[1, 0] = 50;
// matriz[1, 1] = 10;

int[,] matriz = { { 1, 2, 200 }, { 7, 4, 15 } };

// foreach (int item in matriz)
// {
//     Console.WriteLine(item);
// }
Console.WriteLine($"Dimensões: {matriz.Rank}"); // numero de dimensões
Console.WriteLine($"Linhas: {matriz.GetLength(0)}"); //linha size
Console.WriteLine($"Colunas: {matriz.GetLength(1)}"); //coluna size


// Collections https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
// API => https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0#properties
List<int> numerosList = new List<int>();
numerosList.Add(12);
numerosList.Add(20);
numerosList.Add(120);

Console.WriteLine(numerosList.BinarySearch(120));
Console.WriteLine(numerosList.Contains(12));

// Dicionários => https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0
Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("RS", "Rio Grande do Sul");
estados.Add("SC", "Santa Catarina");
estados.Add("PR", "PARANA");
Console.WriteLine(estados["RS"]);

//Percorrendo os valores.
foreach (string item in estados.Values)
{
    Console.WriteLine(item);
}
//Percorrendo as chaves
foreach (string item in estados.Keys)
{
    Console.WriteLine(item);
}

// The indexer can be used to change the value associated
// with a key. Exception if key not found
estados["RS"] = "rio grandeee";

//Percorrendo o dicionário
foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

// When a program often has to try keys that turn out not to
// be in the dictionary, TryGetValue can be a more efficient
// way to retrieve values.

if (estados.ContainsKey("PR"))
{
    estados.Remove("PR");
}

string value = "";
if (estados.TryGetValue("PR", out value))
{
    Console.WriteLine("For key = \"PR\", value = {0}.", value);
}
else
{
    Console.WriteLine("Key = \"PR\" is not found.");
}

// Concurrent: https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent?view=net-6.0
