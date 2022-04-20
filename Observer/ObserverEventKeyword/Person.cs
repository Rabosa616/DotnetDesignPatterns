using System;

namespace Observer.ObserverEventKeyword;

public class Person
{
    public void CatchACold()
    {
        FallsIll?.Invoke(this, new FallsIllEventArgs { Address = "123 London Road" });
    }

    public event EventHandler<FallsIllEventArgs> FallsIll;
}