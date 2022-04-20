using System;
using System.Reactive.Subjects;

namespace Mediator.EventBroker;

public class EventBroker : IObservable<PlayerEvent>
{
    private readonly Subject<PlayerEvent> subscriptions = new();

    public IDisposable Subscribe(IObserver<PlayerEvent> observer)
    {
        return subscriptions.Subscribe(observer);
    }

    public void Publish(PlayerEvent pe)
    {
        subscriptions.OnNext(pe);
    }
}