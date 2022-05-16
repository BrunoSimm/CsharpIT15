public abstract class Conta
{
    private decimal saldo;
    private string titular;
    public decimal Saldo
    {
        get { return saldo; }
    }
    public string Titular
    {
        get { return titular; }
    }
    public abstract string Id { get; }
    public Conta(string nomeTitular)
    {
        titular = nomeTitular;
    }
    public virtual void Depositar(decimal valor)
    {
        saldo += valor;
    }

    public virtual void Sacar(decimal valor)
    {
        saldo -= valor;
    }



}