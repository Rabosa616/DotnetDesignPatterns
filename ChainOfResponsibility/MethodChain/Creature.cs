namespace ChainOfResponsibility.MethodChain;

public class Creature
{
    public string Name { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public Creature(string name, int attack, int defense)
    {
        Name = name;
        Attack = attack;
        Defense = defense;
    }

    public override string ToString()
    {
        return $"{Name} - {Attack} - {Defense}";
    }
}