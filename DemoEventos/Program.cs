static void OuvirExplosao(object? sender, EventArgs e) //Represents the method that will handle an event. https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler?view=net-6.0
{
    Console.WriteLine("a bomba explodiu");
}


Bomba b = new Bomba(3);
b.FezBum += OuvirExplosao; //Associa o delegate eventHandler a um método.
b.Tic();
b.Tic();
b.Tic();
b.Tic(); //Explodiu.