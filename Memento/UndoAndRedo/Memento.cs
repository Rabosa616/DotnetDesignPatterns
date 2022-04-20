namespace Memento.UndoAndRedo;

public class Memento
{
    public int Balance { get; }

    public Memento(int balance)
    {
        Balance = balance;
    }
}