public class TV : IEstadoBinario
{
    private EstadoBinario estado = EstadoBinario.Desligado;
    public void Ligar()
    {
        estado = EstadoBinario.Ligado;
    }
    public void Desligar()
    {
        estado = EstadoBinario.Desligado;
    }
    public EstadoBinario Estado
    {
        get
        {
            return estado;
        }
    }
}