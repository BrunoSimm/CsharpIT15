class ContaCorrente
{
    private decimal saldo;
    private string nomeTitular;
    public string NomeTitular
    {
        get
        {
            return this.nomeTitular;
        }
    }
    private DateTime dataCriacaoConta;
    public DateTime DataCriacaoConta
    {
        get
        {
            return this.dataCriacaoConta;
        }
    }
    public decimal Saldo
    {
        get
        {
            return saldo;
        }
    }

    private int contadorTransacoes = 0;
    private decimal acumuladorDoSaldo = 0;
    public decimal SaldoMedio
    {
        get
        {
            return acumuladorDoSaldo / contadorTransacoes;
        }
    }

    public ContaCorrente(decimal val, string nomeTitular)
    {
        saldo = val;
        acumuladorDoSaldo += saldo;
        contadorTransacoes++;
        this.nomeTitular = nomeTitular;
        this.dataCriacaoConta = DateTime.Now;
    }


    public void Depositar(decimal val)
    {
        saldo += val;
        acumuladorDoSaldo += saldo;
        contadorTransacoes++;
    }

    public void Sacar(decimal val)
    {
        saldo -= val;
        acumuladorDoSaldo += saldo;
        contadorTransacoes++;
    }
}