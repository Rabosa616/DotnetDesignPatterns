using System.ComponentModel;

namespace Observer.BidirectionalObserver;

public class Window : INotifyPropertyChanged
{
    private string productName;

    public string ProductName
    {
        get => productName;
        set
        {
            productName = value;
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
        return $"Window {productName}";
    }
}