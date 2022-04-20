using System;
using System.Collections.Generic;

namespace Singleton.AmbientContext;

public class BuildingContext : IDisposable
{
    // We need to add a list of stack of values (depending of the context)
    public static int WallHeight { get; set; }

    private static readonly Stack<BuildingContext> stack = new();
    private bool disposedValue;

    static BuildingContext()
    {
        stack.Push(new BuildingContext(0));
    }

    public BuildingContext(int wallHeight)
    {
        WallHeight = wallHeight;
        stack.Push(this);
    }

    public static BuildingContext Current => stack.Peek();

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)

                if (stack.Count > 1)
                {
                    stack.Pop();
                }
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~BuildingContext()
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