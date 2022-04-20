using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace Observer.BidirectionalObserver;

public sealed class BidirectionalBinding : IDisposable
{
    private bool disposed;

    public BidirectionalBinding(
        INotifyPropertyChanged first, Expression<Func<object>> firstProperty,
        INotifyPropertyChanged second, Expression<Func<object>> secondProperty)
    {
        // xxxProperty is MemberExpression
        // Member is PropertyInfo
        if (firstProperty.Body is MemberExpression firstExpression
            && secondProperty.Body is MemberExpression secondExpression)
        {
            if (firstExpression.Member is PropertyInfo firstProp
                && secondExpression.Member is PropertyInfo secondProp)
            {
                first.PropertyChanged += (sender, args) =>
                {
                    if (!disposed)
                    {
                        secondProp.SetValue(second, firstProp.GetValue(first));
                    }
                };

                second.PropertyChanged += (sender, args) =>
                {
                    if (!disposed)
                    {
                        firstProp.SetValue(first, secondProp.GetValue(second));
                    }
                };
            }
        }
    }

    public void Dispose()
    {
        disposed = true;
    }
}