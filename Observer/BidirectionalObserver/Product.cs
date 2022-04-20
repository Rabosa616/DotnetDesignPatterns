using System.ComponentModel;

namespace Observer.BidirectionalObserver;

public class Product : INotifyPropertyChanged
{
    private string name;

    public string Name
    {
        get => name;
        set
        {
            if (value == name)
            {
                return;
            }

            name = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public override string ToString()
    {
        return $"Product {name}";
    }
}