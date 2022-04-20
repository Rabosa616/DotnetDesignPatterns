namespace Proxy.PropertyProxy;

public class Creature
{
    private readonly Property<int> agility = new();

    public int Agility
    {
        get => agility.Value;
        set => agility.Value = value;
    }
}