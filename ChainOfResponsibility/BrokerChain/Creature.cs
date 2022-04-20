namespace ChainOfResponsibility.BrokerChain;

public class Creature
{
    private readonly Game game; // Mediator object
    private readonly int attack, defense;

    public string Name { get; set; }

    public Creature(Game game, string name, int attack, int defense)
    {
        this.game = game;
        Name = name;
        this.attack = attack;
        this.defense = defense;
    }

    public int Attack
    {
        get
        {
            var query = new Query(Name, attack, Query.Argument.Attack);
            game.PerformQuery(this, query);
            return query.Value;
        }
    }

    public int Defense
    {
        get
        {
            var query = new Query(Name, defense, Query.Argument.Defense);
            game.PerformQuery(this, query);
            return query.Value;
        }
    }

    public override string ToString()
    {
        return $"{Name} - {Attack} - {Defense}";
    }
}