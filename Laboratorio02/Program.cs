// 2
int[] array = new int[5] { 10, 20, 30, 40, 50 };
// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine(array[i]);
// }
foreach (var item in array)
{
    Console.WriteLine(item);
}


// 4
string[] str = new string[3];
str[0] = "Um";
str[1] = "Dois";
str[2] = "Tres";
// for (int i = 0; i < str.Length; i++)
// {
//     Console.WriteLine(str[i]);
// }
foreach (var item in str)
{
    Console.WriteLine(item);
}

// 6
DateTime[] dt = new DateTime[2];
dt[0] = new DateTime(2002, 5, 1);
dt[1] = new DateTime(2002, 6, 1);
// for (int i = 0; i < dt.Length; i++)
// {
//     Console.WriteLine(dt[i].ToShortDateString());
// }
foreach (var date in dt)
{
    Console.WriteLine(date.ToShortDateString());
}

//Exercicios
//1
int[] arr1 = new int[100];
int[] arr2 = new int[100];
Random rnd = new Random();
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = rnd.Next(100, 543);
}
arr1.CopyTo(arr2, 0);
Console.WriteLine(arr1[0]);
Console.WriteLine(arr2[0]);
//2
//multidimensional
Console.WriteLine("Exercicio 2 - Multidimensional");
int[,] matriz = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 6, 7, 8, 9, 10 }, { 6, 7, 8, 9, 10 }, { 6, 7, 8, 9, 10 } };
for (int i = 0; i < matriz.GetLength(1); i++) //coluna
{
    int sum = 0;
    for (int y = 0; y < matriz.GetLength(0); y++) //linha
    {
        sum += matriz[y, i];
    }
    Console.WriteLine($"SOMA DA COLUNA {i}: {sum}");
}

