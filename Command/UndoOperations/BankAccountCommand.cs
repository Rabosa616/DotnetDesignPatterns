using System;

namespace Command.UndoOperations;

public class BankAccountCommand : ICommand
{
    private readonly BankAccount account;
    private readonly Action action;
    private readonly int amount;
    private bool succeeded;

    public enum Action
    {
        Deposit, Withdraw
    }

    public BankAccountCommand(BankAccount account, Action action, int amount)
    {
        this.account = account;
        this.action = action;
        this.amount = amount;
    }

    public void Call()
    {
        switch (action)
        {
            case Action.Deposit:
                account.Deposit(amount);
                succeeded = true;
                break;

            case Action.Withdraw:
                succeeded = account.Withdraw(amount);
                break;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void Undo()
    {
        if (!succeeded)
        {
            return;
        }

        switch (action)
        {
            case Action.Deposit:
                account.Withdraw(amount);
                break;

            case Action.Withdraw:
                account.Deposit(amount);
                break;

            default:
                throw new ArgumentNullException();
        }
    }
}