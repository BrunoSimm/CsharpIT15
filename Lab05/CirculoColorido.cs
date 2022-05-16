public class CirculoColorido : Circulo
{
    private string minhaCor;

    public string Cor
    {
        get
        {
            return minhaCor;

        }
        set
        {
            minhaCor = value;
        }
    }

    public CirculoColorido()
    {
        minhaCor = "preto";
    }

    public CirculoColorido(double x, double y, double raio, string cor) : base(x, y, raio)
    {
        minhaCor = cor;
    }

    public override string ToString()
    {
        return base.ToString() + " cor=" + Cor;
    }


}