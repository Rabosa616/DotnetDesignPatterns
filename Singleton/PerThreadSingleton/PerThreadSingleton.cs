using System.Threading;

namespace Singleton.PerThreadSingleton;

public sealed class PerThreadSingleton
{
    private static readonly ThreadLocal<PerThreadSingleton> threadInstance = new(() => new PerThreadSingleton());

    public int Id { get; set; }

    private PerThreadSingleton()
    {
        Id = System.Environment.CurrentManagedThreadId;
    }

    public static PerThreadSingleton Instance => threadInstance.Value;
}