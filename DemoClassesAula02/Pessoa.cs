public class Pessoa
{
    //string Nome { get; set; } //private is default
    private string nome;
    // public string Nome => nome;
    public string Nome
    {
        get
        {
            return nome;
        }
    }
    // private int Idade { get; set; }
    private int idade;
    public int Idade
    {
        // get => idade;
        // set => idade = value;
        get
        {
            return idade;
        }
        set
        {
            idade = value; //value é uma palavra reservada, contendo o valor da atribuição (pessoa.Idade = 23).
        }
    }
    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    //overload default constructor.
    public Pessoa(string nome) : this(nome, 0)//calls default constructor
    { }

}