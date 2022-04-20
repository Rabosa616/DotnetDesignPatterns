using ImpromptuInterface;
using System;
using System.Dynamic;

namespace NullObject.DynamicNullObject;

public class Null<TInterface> : DynamicObject where TInterface : class
{
    // ActLike converts the dynamic object into an object implementing the TInterface
    public static TInterface Instance => new Null<TInterface>().ActLike<TInterface>();

    public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
    {
        result = Activator.CreateInstance(binder.ReturnType);
        return true;
    }
}