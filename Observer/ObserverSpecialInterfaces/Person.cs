using System;
using System.Collections.Generic;

namespace Observer.ObserverSpecialInterfaces;

// When the person is observed, triggers the object with the class Event
public class Person : IObservable<Event>
{
    private readonly HashSet<Subscription> subscriptions = new();

    public IDisposable Subscribe(IObserver<Event> observer)
    {
        var subscription = new Subscription(this, observer);
        subscriptions.Add(subscription);

        return subscription;
    }

    public void FallIll()
    {
        foreach (var s in subscriptions)
        {
            s.Observer.OnNext(new FallsIllEvent { Address = "123 London Rd" });
        }
    }

    private class Subscription : IDisposable
    {
        private readonly Person person;

        public readonly IObserver<Event> Observer;

        public Subscription(Person person, IObserver<Event> observer)
        {
            this.person = person;
            Observer = observer;
        }

        public void Dispose()
        {
            person.subscriptions.Remove(this);
        }
    }
}