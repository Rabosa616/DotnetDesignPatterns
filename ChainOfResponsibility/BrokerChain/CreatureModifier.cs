using System;

namespace ChainOfResponsibility.BrokerChain;

public abstract class CreatureModifier : IDisposable
{
    protected Game game;
    protected Creature creature;
    private bool disposedValue;

    public CreatureModifier(Game game, Creature creature)
    {
        this.game = game;
        this.creature = creature;
        game.Queries += Handle;
    }

    protected abstract void Handle(object sender, Query q);

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
                game.Queries -= Handle;
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~CreatureModifier()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}