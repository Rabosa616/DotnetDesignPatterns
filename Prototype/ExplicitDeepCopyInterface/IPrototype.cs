namespace Prototype.ExplicitDeepCopyInterface;

public interface IPrototype<T>
{
    T DeepCopy();
}