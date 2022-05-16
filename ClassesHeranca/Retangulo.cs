public class Retangulo : FiguraGeometrica
{
    public int Altura { get; set; }
    public int Largura { get; set; }
    public override int Area => Altura * Largura;
    public Retangulo(int x, int y, int altura, int largura) : base(x, y)
    {
        if (altura <= 0 || largura <= 0)
        {
            throw new Exception("Altura e Largura devem ser maiores que 0.");
        }
        Altura = altura;
        Largura = largura;
    }

    public override string ToString()
    {
        return base.ToString() + $" [Altura={Altura}, Largura={Largura}]";
    }
}