using System.Drawing;

Circulo c1 = new Circulo();

Console.WriteLine(c1);

Circulo c2 = new Circulo(2.4, 5, 3);
Console.WriteLine(c2);
Console.WriteLine(c2.CentroX);
Console.WriteLine(c2.CentroY);

CirculoColorido c3 = new CirculoColorido();
Console.WriteLine(c3);

CirculoColorido c4 = new CirculoColorido(1, 2, 5, "azul");
Console.WriteLine(c4);
Console.WriteLine(c4.CentroX);
Console.WriteLine(c4.CentroY);

CirculoColoridoPreenchido c5 = new CirculoColoridoPreenchido(1, 5, 15, "verde", Color.BlueViolet);
Console.WriteLine(c5);

Circulo[] arrCirculos = new Circulo[5];
arrCirculos[0] = c1;
arrCirculos[1] = c2;
arrCirculos[2] = c3;
arrCirculos[3] = c4;
arrCirculos[4] = c5;

foreach (var circulo in arrCirculos)
{
    Console.WriteLine(circulo.ToString());
}