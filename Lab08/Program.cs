string[] lista = { "Julio", "Lucia", "Daniel", "Joao" };
Console.WriteLine("Array antes da ordenacao");
for (int i = 0; i < lista.Length; i++)
{
    Console.Write(lista[i] + " ");
}
Console.WriteLine();
Array.Sort(lista);
Console.WriteLine("Array depois da ordenacao");
for (int i = 0; i < lista.Length; i++)
{
    Console.WriteLine(lista[i] + " ");
}

Console.WriteLine();
Pessoa[] lista2 = {
 new Pessoa("Jose", 25),
 new Pessoa("Ana", 35),
 new Pessoa("Paulo", 20)
};
Pessoa.OrderBy = "nome";
Console.WriteLine(Pessoa.OrderBy);
Array.Sort(lista2);
Console.WriteLine("Array depois da ordenacao");
for (int i = 0; i < lista2.Length; i++)
{
    Console.WriteLine(lista2[i].Nome + " ");
}
