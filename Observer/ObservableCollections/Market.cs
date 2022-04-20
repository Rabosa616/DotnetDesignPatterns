using System.ComponentModel;

namespace Observer.ObservableCollections;

public class Market // observable
{
    // BindingList keeps the value and also add the notifications automatically
    public BindingList<float> Prices = new();

    public void AddPrice(float price)
    {
        Prices.Add(price);

        // Not need it with BindingList
        //PriceAdded?.Invoke(this, price);
    }

    // Not need it with BindingList
    // public event EventHandler<float> PriceAdded;
}