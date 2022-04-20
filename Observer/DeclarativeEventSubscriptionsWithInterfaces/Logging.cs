using System;

namespace Observer.DeclarativeEventSubscriptionsWithInterfaces;

public class Logging : IHandle<ButtonProssedEvent>
{
    public void Handle(object sender, ButtonProssedEvent args)
    {
        Console.WriteLine($"Button clicked {args.NumberOfClicks} times");
    }
}