try
{
    Retangulo rt = new Retangulo(1, 2, 15, 12);
    Console.WriteLine(rt.ToString());
    Console.WriteLine(rt.Area);
    Quadrado qd = new Quadrado(1, 20, 30);
    Console.WriteLine(qd);
    Console.WriteLine(qd.Area);

    Retangulo r3 = new Quadrado(1, 1, 3);
    Console.WriteLine(r3);
}
catch (System.Exception e)
{
    Console.WriteLine(e.Message);
}