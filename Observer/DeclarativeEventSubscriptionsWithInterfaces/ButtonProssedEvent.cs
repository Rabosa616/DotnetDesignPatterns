namespace Observer.DeclarativeEventSubscriptionsWithInterfaces;

public class ButtonProssedEvent : IEvent
{
    public int NumberOfClicks { get; set; }
}