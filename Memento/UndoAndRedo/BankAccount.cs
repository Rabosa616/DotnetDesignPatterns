using System.Collections.Generic;

namespace Memento.UndoAndRedo;

public class BankAccount
{
    private int balance;
    private readonly List<Memento> changes = new();
    private int current;

    public BankAccount(int balance)
    {
        this.balance = balance;
        changes.Add(new Memento(balance));
    }

    public Memento Deposit(int amount)
    {
        balance += amount;
        var m = new Memento(balance);
        changes.Add(m);
        ++current;
        return m;
    }

    public Memento Restore(Memento m)
    {
        if (m != null)
        {
            balance = m.Balance;
            changes.Add(m);
            ++current;
            return m;
        }

        return null;
    }

    public Memento Undo()
    {
        if (current > 0)
        {
            var m = changes[--current];
            balance = m.Balance;
            return m;
        }

        return null;
    }

    public Memento Redo()
    {
        if (current + 1 < changes.Count)
        {
            var m = changes[++current];
            balance = m.Balance;
            return m;
        }

        return null;
    }

    public override string ToString()
    {
        return $"{nameof(balance)}: {balance}";
    }
}