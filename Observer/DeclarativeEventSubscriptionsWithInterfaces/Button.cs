using System;

namespace Observer.DeclarativeEventSubscriptionsWithInterfaces;

public class Button : ISend<ButtonProssedEvent>
{
    public event EventHandler<ButtonProssedEvent> Sender;

    public void Fire(int clicks)
    {
        Sender?.Invoke(this, new ButtonProssedEvent { NumberOfClicks = clicks });
    }
}