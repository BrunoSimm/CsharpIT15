public class Bomba
{
    public bool Explodiu { get; private set; }
    private int tics = 0;
    public int TempoLimite { get; init; }

    public event EventHandler FezBum; //https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler?view=net-6.0
    //https://docs.microsoft.com/en-us/dotnet/api/system.delegate?view=net-6.0

    public Bomba(int tempoLimite)
    {
        this.TempoLimite = tempoLimite;
    }

    public void Tic()
    {
        if (this.TempoLimite == tics && !Explodiu)
        {
            Explodiu = true;
            if (FezBum != null)
            {
                this.FezBum(this, EventArgs.Empty);

            }
        }
        else
        {
            Console.WriteLine("TIC");
            this.tics++;
        }
    }
}