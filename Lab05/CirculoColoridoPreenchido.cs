using System.Drawing;

public class CirculoColoridoPreenchido : CirculoColorido
{
    public Color CorPreenchimento { get; set; }

    public CirculoColoridoPreenchido(double x, double y, double raio, string cor, Color corPreenchimento)
        : base(x, y, raio, cor)
    {
        CorPreenchimento = corPreenchimento;
    }

    public override string ToString()
    {
        return base.ToString() + $" Cor Preenchimento={CorPreenchimento.Name}";
    }
}