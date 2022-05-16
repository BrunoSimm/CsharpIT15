Conta c1 = new ContaPoupanca(12.5M, DateTime.Now, "Bruno Simm");

Console.WriteLine(c1.Id);
Console.WriteLine(c1.Titular);
c1.Depositar(100);
c1.Sacar(21.23M);
Console.WriteLine(c1.Saldo);
Console.WriteLine(c1.ToString());
