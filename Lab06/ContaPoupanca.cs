public class ContaPoupanca : Conta
{
    private decimal taxaJuros;
    private DateTime dataAniversario;
    public decimal Juros
    {
        get { return taxaJuros; }
        set { taxaJuros = value; }
    }
    public DateTime DataAniversario
    {
        get { return dataAniversario; }
    }
    public override string Id
    {
        get { return this.Titular + "(CP)"; }
    }

    public ContaPoupanca(decimal taxaJuros, DateTime dataAniversario, string nomeTitular)
     : base(nomeTitular)
    {
        this.taxaJuros = taxaJuros;
        this.dataAniversario = dataAniversario;
    }

    public void AdicionarRendimento()
    {
        DateTime hoje = DateTime.Now;
        if (hoje.Day == dataAniversario.Day && hoje.Month == dataAniversario.Month)
        {
            decimal rendimento = this.Saldo * taxaJuros;
            this.Depositar(rendimento);
        }
    }
}