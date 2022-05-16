public class Pessoa : IComparable<Pessoa>
{
    private string meuNome;
    private int minhaIdade;
    private static string orderBy;
    public Pessoa(string n, int i)
    {
        meuNome = n;
        minhaIdade = i;
        OrderBy = "NOME";
    }
    public string Nome
    {
        get { return meuNome; }
    }
    public int Idade
    {
        get { return minhaIdade; }
        set { minhaIdade = value; }
    }

    public static string OrderBy
    {
        get { return orderBy; }
        set
        {
            if (value.ToUpper().Equals("NOME") || value.ToUpper().Equals("IDADE"))
            {
                orderBy = value.ToUpper();
            }
            else
            {
                throw new Exception("Invalid orderBy parameter.");
            }
        }
    }

    public int CompareTo(Pessoa outro)
    {
        if (OrderBy.Equals("NOME"))
        {
            return meuNome.CompareTo(outro.meuNome);
        }

        if (OrderBy.Equals("IDADE"))
        {
            return minhaIdade - outro.minhaIdade;
        }

        return meuNome.CompareTo(outro.meuNome);
    }
}
