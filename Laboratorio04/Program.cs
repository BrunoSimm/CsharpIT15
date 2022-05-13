ContaCorrente cc = new ContaCorrente(10, "Bruno Simm");
Console.WriteLine($"Conta Corrente criada: {cc.NomeTitular} - {cc.DataCriacaoConta}");
cc.Depositar(5);
Console.WriteLine(cc.Saldo);
cc.Sacar(5);
cc.Depositar(55);
cc.Sacar(12.50M);
Console.WriteLine($"Saldo Atual: {cc.Saldo}");
Console.WriteLine($"Saldo Médio: {cc.SaldoMedio}");