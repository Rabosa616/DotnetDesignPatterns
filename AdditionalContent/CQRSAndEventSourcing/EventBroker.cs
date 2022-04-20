using System;
using System.Collections.Generic;
using System.Linq;

namespace AdditionalContent.CQRSAndEventSourcing;

public class EventBroker
{
    // 1. All events that happened.
    public IList<Event> AllEvents = new List<Event>();

    // 2. Commands
    public event EventHandler<Command> Commands;

    // 3. Query
    public event EventHandler<Query> Queries;

    public void Command(Command c)
    {
        Commands?.Invoke(this, c);
    }

    public T Query<T>(Query q)
    {
        Queries?.Invoke(this, q);
        return (T)q.Result;
    }

    public void UndoLast()
    {
        var e = AllEvents.LastOrDefault();
        if (e is AgeChangedEvent ac)
        {
            Command(new ChangeAgeCommand(ac.Target, ac.OldValue) { Register = false });
            AllEvents.Remove(e);
        }
    }
}