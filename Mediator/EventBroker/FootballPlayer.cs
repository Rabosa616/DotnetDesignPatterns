using System.Reactive.Linq;
using System.Linq;
using System;

namespace Mediator.EventBroker;

public class FootballPlayer : Actor
{
    public string Name { get; set; }

    public int GoalsScored { get; set; }

    public FootballPlayer(EventBroker broker, string name)
        : base(broker)
    {
        Name = name;

        broker.OfType<PlayerScoredEvent>().Where(ps => !ps.Name.Equals(Name)).Subscribe(
            ps => Console.WriteLine($"{Name}: Nicely done, {ps.Name}! It´s your {ps.GoalsScored}"));

        broker.OfType<PlayerSentOffEvent>().Where(ps => !ps.Name.Equals(Name))
            .Subscribe(ps => Console.WriteLine($"{Name}: see you in the lockers, {ps.Name}"));
    }

    public void Socre()
    {
        GoalsScored++;
        broker.Publish(new PlayerScoredEvent { Name = Name, GoalsScored = GoalsScored });
    }

    public void AssaultReferee()
    {
        broker.Publish(new PlayerSentOffEvent { Name = Name, Reason = "violence" });
    }
}