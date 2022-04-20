using System;
using System.Collections.Generic;
using System.Linq;

namespace AdditionalContent.LocalInversionOfControl;

public static class ExtensionMethods
{
    public static T AddTo<T>(this T self, ICollection<T> coll)
    {
        coll.Add(self);
        return (self);
    }

    public static bool IsOneOf<T>(this T self, params T[] values)
    {
        return values.Contains(self);
    }

    public static bool HasNo<TSubject, T>(this TSubject self,
        Func<TSubject, IEnumerable<T>> props)
    {
        return !props(self).Any();
    }

    public static bool HasSome<TSubject, T>(this TSubject self,
        Func<TSubject, IEnumerable<T>> props)
    {
        return props(self).Any();
    }
}