using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder.FunctionalBuilder;

// This abstract class help us to create more generic and rehusable builders
public abstract class FunctionalBuilder<TSubject, TSelf>
    where TSelf : FunctionalBuilder<TSubject, TSelf>
    where TSubject : new()
{
    private readonly List<Func<TSubject, TSubject>> actions = new();

    public TSelf Do(Action<TSubject> action) => AddAction(action);

    // Aggregate : compact a list into a single application
    public TSubject Build() => actions.Aggregate(new TSubject(), (p, f) => f(p));

    private TSelf AddAction(Action<TSubject> action)
    {
        actions.Add(p => { action(p); return p; });
        return (TSelf)this;
    }
}