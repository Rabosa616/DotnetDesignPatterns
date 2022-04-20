using System;

namespace Observer.DeclarativeEventSubscriptionsWithInterfaces;

public interface ISend<TEvent> where TEvent : IEvent
{
    event EventHandler<TEvent> Sender;
}