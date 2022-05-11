byte b = byte.MaxValue;
Console.WriteLine($"Valor maximo de byte: {b}");

int i = int.MaxValue;
Console.WriteLine($"Valor máximo de int: {i}");

long l = long.MaxValue;
Console.WriteLine($"Valor máximo de long: {l}");

// Strings
string strPrimeira = "Alo";
string strSegunda = "Mundo";
string strTerceira = strPrimeira + strSegunda;
Console.WriteLine(strTerceira);

string strQuarta = $"Tamanho = {strTerceira.Length}";
Console.WriteLine(strQuarta);

Console.WriteLine(strTerceira.Substring(0, 5));

// Objetos Framework
DateTime dt = new DateTime(2015, 04, 23);
string strQuinta = dt.ToString();
Console.WriteLine(strQuinta);

//Exercícios
// 1
float nota1 = 9.55f;
double nota2 = 8.234f;
decimal media = (decimal)(nota1 + nota2) / 2;
Console.WriteLine(media);

// 2 => https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
// Equivalentes => "string" é recomendado.
string greeting1 = "Hello World!";
System.String greeting2 = "Hello World!";

//Because a string "modification" is actually a new string creation, you must use caution when you create references to strings. 
// If you create a reference to a string, and then "modify" the original string, the reference will continue to point to the original object instead of the new object that was created when the string was modified. 
// The following code illustrates this behavior:
string str1 = "Hello ";
string str2 = str1;
str1 += "World";
Console.WriteLine(str2);
Console.WriteLine(str1);

// Verbatim string leterals
string filePath = @"C:\Users\scoleridge\Documents\";
//Output: C:\Users\scoleridge\Documents\

string text = @"My pensive SARA ! thy soft cheek reclined
    Thus on mine arm, most soothing sweet it is
    To sit beside our Cot,...";
Console.WriteLine(text);
/* Output:
My pensive SARA ! thy soft cheek reclined
    Thus on mine arm, most soothing sweet it is
    To sit beside our Cot,...
*/
string quote = @"Her name was ""Sara.""";
//Output: Her name was "Sara."




// Equals
var x = str1.Equals(str2, StringComparison.Ordinal);
Console.WriteLine(x);

// 3 => https://docs.microsoft.com/en-us/dotnet/api/system.datetime.compare?view=net-6.0
// https://docs.microsoft.com/en-us/dotnet/api/system.datetime.subtract?view=net-6.0
// https://docs.microsoft.com/en-us/dotnet/api/system.datetime.equals?view=net-6.0


//6 
// How to determine whether a string represents a numeric value
string numString = "1287543"; //"1287543.0" will return false for a long
long number1 = 0;
bool canConvert = long.TryParse(numString, out number1);
if (canConvert == true)
    Console.WriteLine("number1 now = {0}", number1);
else
    Console.WriteLine("numString is not a valid long");

byte number2 = 0;
numString = "255"; // A value of 256 will return false
canConvert = byte.TryParse(numString, out number2);
if (canConvert == true)
    Console.WriteLine("number2 now = {0}", number2);
else
    Console.WriteLine("numString is not a valid byte");

decimal number3 = 0;
numString = "27.3"; //"27" is also a valid decimal
canConvert = decimal.TryParse(numString, out number3);
if (canConvert == true)
    Console.WriteLine("number3 now = {0}", number3);
else
    Console.WriteLine("number3 is not a valid decimal");


